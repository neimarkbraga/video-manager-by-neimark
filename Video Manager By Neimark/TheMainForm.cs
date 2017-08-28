using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using Video_Manager_By_Neimark;
using System.Text.RegularExpressions;

namespace Video_Manager_By_Neimark
{
    public partial class TheMainForm : Form
    {
        //Public Variables
        public bool Loaded = false;
        public string ApplicationName = "Video Manager By Neimark";
        public FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        public List<Video> VideoList = new List<Video>();
        public List<Video> NoInfoVideoList = new List<Video>();
        public List<Video> VideoList_SearchResult = new List<Video>();
        public List<Video> NoInfoVideoList_SearchResult = new List<Video>();

        public TheMainForm()
        {
            InitializeComponent();
        }

        //============Global============
        private void TheMainForm_Load(object sender, EventArgs e)
        {
            //Initialization
            this.Text = ApplicationName;
            statusLabel_statusLabel.Text = "Welcome to Video Manager By Neimark!";
            InitializeFolderBrowser();

            int s_colswidth = columnHeader_mvYear.Width + columnHeader_mvResolution.Width + columnHeader_Duration.Width;
            int availablewidth = listView_mvResult.Width - s_colswidth;
            columnHeader_mvTitle.Width = (int)Math.Ceiling(availablewidth * 0.55);
            columnHeader_mvGenre.Width = availablewidth - columnHeader_mvTitle.Width;

            textBox_mvSearchYear.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Year.ToString();
            EnableTab(tabPage_manageVideos, false);
            EnableTab(tabPage_manageNoInfoVideos, false);
        }

        private void btn_browseMoviesFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.LastAccessedFolder = folderBrowser.SelectedPath;
                Properties.Settings.Default.Save();
                lbl_currentDirectory.Text = folderBrowser.SelectedPath;
                btn_loadVideos.Enabled = true;
            }
        }

        private void btn_loadVideos_Click(object sender, EventArgs e)
        {
            loadVideos();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileExtensionsToScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsFileExtensionForm(this).ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Neimark Junsay Braga", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListViewColumnClickSorter(object sender, ColumnClickEventArgs e)
        {
            ListView listview = (ListView)sender;
            int l_column = -1;
            try{ l_column = (int)listview.Tag; } catch { l_column = -1; }
            if (e.Column != l_column)
            {
                listview.Tag = e.Column;
                listview.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (listview.Sorting == SortOrder.Ascending)
                    listview.Sorting = SortOrder.Descending;
                else
                    listview.Sorting = SortOrder.Ascending;
            }
            listview.Sort();
            listview.ListViewItemSorter = new ListViewItemStringComparer(e.Column, listview.Sorting);
        }

        private void InitializeFolderBrowser()
        {
            lbl_currentDirectory.Text = folderBrowser.SelectedPath = "C:\\";
            if (Directory.Exists(Properties.Settings.Default.LastAccessedFolder))
                lbl_currentDirectory.Text = folderBrowser.SelectedPath = Properties.Settings.Default.LastAccessedFolder;
        }

        private bool stringContainsStrings(string str, List<string> strs)
        {
            foreach (string str_ in strs)
                if (str.IndexOf(str_) >= 0)
                    return true;
            return false;
        }

        private bool listContainsList(List<string> list1, List<string> list2)
        {
            foreach (string s_gen in list1)
            {
                bool exists = false;
                foreach (string v_gen in list2)
                    if (s_gen.ToUpper().Trim() == v_gen.ToUpper().Trim())
                        exists = true;
                if (!exists)
                    return false;
            }
            return true;
        }

        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }

        public void loadVideos()
        {
            pnl_mvInfo.Controls.Clear();
            btn_loadVideos.Enabled = false;
            VideoList = new List<Video>();
            NoInfoVideoList = new List<Video>();
            new LoadDirectoryForm(this).ShowDialog(this);
            this.Text = ApplicationName + " - \"" + folderBrowser.SelectedPath + "\"";
        }

        public void RefreshTabsToEnable()
        {
            if (VideoList.Count > 0)
                EnableTab(tabPage_manageVideos, true);
            else
                EnableTab(tabPage_manageVideos, false);

            if (NoInfoVideoList.Count > 0)
                EnableTab(tabPage_manageNoInfoVideos, true);
            else
                EnableTab(tabPage_manageNoInfoVideos, false);
        }


        //============MV============
        #region
        private void listView_mvResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_mvResult.SelectedItems.Count > 0)
            {
                try
                {
                    mvDisplayInfo(VideoList_SearchResult[(int)listView_mvResult.SelectedItems[0].Tag]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_mvDisplayAll_Click(object sender, EventArgs e)
        {
            if (VideoList.Count > 0)
                mvDisplayAllVideos();
            else
                MessageBox.Show("There are no videos to search please load first.", "Nothing To Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_mvSearch_Click(object sender, EventArgs e)
        {
            mvSearch();
        }

        private void mvSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
                mvSearch();
        }

        public void mvEnsureSelected()
        {
            listView_mvResult.Focus();
            listView_mvResult.Select();
            if (listView_mvResult.SelectedItems.Count > 0)
            {
                listView_mvResult.SelectedItems[0].Selected = true;
                listView_mvResult.SelectedItems[0].Focused = true;
                listView_mvResult.SelectedItems[0].EnsureVisible();
            }
        }

        public void mvDisplayInfo(Video v)
        {
            pnl_mvInfo.Controls.Clear();
            VideoPreviewControl vpc = new VideoPreviewControl(this, v);
            vpc.Dock = DockStyle.Fill;
            pnl_mvInfo.Controls.Add(vpc);
        }

        public void mvRenderVideos()
        {
            listView_mvResult.Items.Clear();
            int index = 0;
            foreach (Video video in VideoList_SearchResult)
            {
                ListViewItem l = video.createListViewItemCompleteInfo();
                l.Tag = index;
                listView_mvResult.Items.Add(l);
                index++;
            }
        }

        public void mvDisplayAllVideos()
        {
            VideoList_SearchResult = VideoList.GetRange(0, VideoList.Count);
            pnl_mvInfo.Controls.Clear();
            mvRefreshResolutionList();
            mvCheckAllResolution();
            textBox_mvSearchTitle.Text = "";
            textBox_mvSearchGenre.Text = "";
            checkBox_mvGenre.Checked = true;
            if(VideoList.Count > 0)
                textBox_mvSearchYear.Text = mvGetAllYears().Min() + "-" + mvGetAllYears().Max();
            mvRenderVideos();
        }

        private void mvSearch()
        {
            pnl_mvInfo.Controls.Clear();
            if (VideoList.Count > 0)
            {
                List<Video> PriorityResult = VideoList;
                List<Video> ExtraResult1 = new List<Video>();
                List<Video> ExtraResult2 = new List<Video>();

                //Keyword
                #region
                if (textBox_mvSearchTitle.Text.Trim() != "")
                {
                    List<string> keywords = textBox_mvSearchTitle.Text.ToUpper().Split(' ').ToList();
                    PriorityResult = VideoList.Where(v => v.Info.Title.ToUpper().IndexOf(textBox_mvSearchTitle.Text.ToUpper()) >= 0).ToList<Video>();
                    ExtraResult1 = VideoList.Where(v => stringContainsStrings(v.Info.Title.ToUpper(), keywords) && !PriorityResult.Contains(v)).ToList<Video>();
                    ExtraResult2 = VideoList.Where(v => stringContainsStrings(v.Info.Description.ToUpper(), keywords) && !PriorityResult.Contains(v) && !ExtraResult1.Contains(v)).ToList<Video>();
                    ExtraResult1.AddRange(ExtraResult2);
                    PriorityResult.AddRange(ExtraResult1);
                }
                #endregion

                //Genre
                #region
                if (textBox_mvSearchGenre.Text.Trim() != "")
                {
                    List<string> Genres = textBox_mvSearchGenre.Text.ToUpper().Split(',').ToList();
                    for (int i = 0; i < Genres.Count; i++)
                        Genres[i] = Genres[i].Trim();
                    ExtraResult1 = PriorityResult.Where(v => v.Info.Genre.Count > 0 && listContainsList(Genres, v.Info.Genre)).ToList<Video>();
                    if (checkBox_mvGenre.Checked)
                        ExtraResult1.AddRange(PriorityResult.Where(v => v.Info.Genre.Count == 0).ToList<Video>());
                    PriorityResult = ExtraResult1;
                }
                #endregion

                //Year
                #region
                if (textBox_mvSearchYear.Text.Trim() != "")
                {
                    string y_input = textBox_mvSearchYear.Text.Trim();
                    Regex y_single_pattern = new Regex("^[0-9]+$");
                    Regex y_range_pattern = new Regex("^[0-9]+-[0-9]+$");
                    if (y_single_pattern.IsMatch(y_input))
                    {
                        PriorityResult = PriorityResult.Where(v => v.Info.Year == Convert.ToInt32(y_input)).ToList<Video>();
                    }
                    else if (y_range_pattern.IsMatch(y_input))
                    {
                        int y_min = Convert.ToInt32(y_input.Split('-').First());
                        int y_max = Convert.ToInt32(y_input.Split('-').Last());
                        if (y_min > y_max)
                        {
                            int temp = y_max;
                            y_max = y_min;
                            y_min = temp;
                        }
                        PriorityResult = PriorityResult.Where(v => v.Info.Year <= y_max && v.Info.Year >= y_min).ToList<Video>();
                    }
                    else
                    {
                        MessageBox.Show("Invalid year input. here are the examples of valid input: \nFor single year: 2005 \nFor range year: 2000-2010", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                #endregion

                //Resoltuion
                #region
                if (checkedListBox_mvSearchResolution.CheckedItems.Count > 0)
                {
                    List<int> resolutions = new List<int>();
                    foreach (string res_string in checkedListBox_mvSearchResolution.CheckedItems)
                        resolutions.Add(Convert.ToInt32(res_string.Replace("p", "")));
                    PriorityResult = PriorityResult.Where(v => resolutions.Contains(v.Info.Resolution)).ToList<Video>();
                }
                else
                {
                    MessageBox.Show("You need to check at least one resolution", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                VideoList_SearchResult = PriorityResult.GetRange(0, PriorityResult.Count);
                mvRenderVideos();
            }
            else
            {
                MessageBox.Show("There are no videos to search please load first.", "Nothing To Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void mvRefreshResolutionList()
        {
            List<int> checked_resoultions = new List<int>();
            foreach (string checked_item in checkedListBox_mvSearchResolution.CheckedItems)
                checked_resoultions.Add(Convert.ToInt32(checked_item.Replace("p", "")));
            checkedListBox_mvSearchResolution.Items.Clear();
            List<int> resolutions = VideoList.Select(v => v.Info.Resolution).Distinct().ToList();
            resolutions.Sort();
            for (int i = 0; i < resolutions.Count; i++)
            {
                checkedListBox_mvSearchResolution.Items.Add(resolutions[i] + "p");
                if (checked_resoultions.Contains(resolutions[i]))
                    checkedListBox_mvSearchResolution.SetItemChecked(i, true);
            }
        }

        public void mvCheckAllResolution()
        {
            for (int i = 0; i < checkedListBox_mvSearchResolution.Items.Count; i++)
                checkedListBox_mvSearchResolution.SetItemChecked(i, true);
        }

        public List<int> mvGetAllYears()
        {
            return VideoList.Select(v => v.Info.Year).Distinct().ToList();
        }
        #endregion



        //============NIF===========
        private void listView_nifResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_nifResult.SelectedItems.Count > 0)
            {
                try
                {
                    nifDisplayInfo(NoInfoVideoList_SearchResult[(int)listView_nifResult.SelectedItems[0].Tag]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nifSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
                nifSearch();
        }

        private void btn_nifSearch_Click(object sender, EventArgs e)
        {
            nifSearch();
        }

        public void nifRenderVideos()
        {
            pnl_nifInfo.Controls.Clear();
            listView_nifResult.Items.Clear();
            int index = 0;
            foreach (Video video in NoInfoVideoList_SearchResult)
            {
                ListViewItem l = new ListViewItem(video.VideoFile.Name);
                l.SubItems.Add(video.VideoFile.DirectoryName);
                l.Tag = index;
                listView_nifResult.Items.Add(l);
                index++;
            }
        }

        public void nifDisplayAllVideos()
        {
            NoInfoVideoList_SearchResult = NoInfoVideoList.GetRange(0, NoInfoVideoList.Count);
            nifRenderVideos();
        }

        public void nifDisplayInfo(Video v)
        {
            pnl_nifInfo.Controls.Clear();
            NoInfoVideoPreviewControl vpc = new NoInfoVideoPreviewControl(this, v);
            vpc.Dock = DockStyle.Fill;
            pnl_nifInfo.Controls.Add(vpc);
        }

        public void nifEnsureSelected()
        {
            listView_nifResult.Focus();
            listView_nifResult.Select();
            if (listView_nifResult.SelectedItems.Count > 0)
            {
                listView_nifResult.SelectedItems[0].Selected = true;
                listView_nifResult.SelectedItems[0].Focused = true;
                listView_nifResult.SelectedItems[0].EnsureVisible();
            }
        }

        private void nifSearch()
        {
            pnl_mvInfo.Controls.Clear();
            if (NoInfoVideoList.Count > 0)
            {
                List<Video> PriorityResult = NoInfoVideoList;
                List<Video> ExtraResult1 = new List<Video>();
                if (textBox_nifSearch.Text.Trim() != "")
                {
                    List<string> keywords = textBox_nifSearch.Text.ToUpper().Split(' ').ToList();
                    PriorityResult = NoInfoVideoList.Where(v => v.VideoFile.FullName.ToUpper().IndexOf(textBox_nifSearch.Text.ToUpper()) >= 0).ToList<Video>();
                    ExtraResult1 = NoInfoVideoList.Where(v => stringContainsStrings(v.VideoFile.FullName.ToUpper(), keywords) && !PriorityResult.Contains(v)).ToList<Video>();
                    PriorityResult.AddRange(ExtraResult1);
                    NoInfoVideoList_SearchResult = PriorityResult.GetRange(0, PriorityResult.Count);
                    nifRenderVideos();
                }
            }
            else
            {
                MessageBox.Show("There are no videos to search please load first.", "Nothing To Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_nifDisplayAll_Click(object sender, EventArgs e)
        {
            nifDisplayAllVideos();
            textBox_nifSearch.Text = "";
        }

        public void nifDeleteVideoFromList(Video video)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                int v_index = NoInfoVideoList.IndexOf(video);
                int vr_index = NoInfoVideoList_SearchResult.IndexOf(video);
                NoInfoVideoList.RemoveAt(v_index);
                for (int i = 0; i < listView_nifResult.Items.Count; i++)
                    if (listView_nifResult.Items[i].Tag.ToString() == vr_index.ToString())
                        listView_nifResult.Items.RemoveAt(i);
            }));
        }

    }
}
