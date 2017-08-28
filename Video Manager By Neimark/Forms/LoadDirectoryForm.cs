using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Web.Script.Serialization;
using NReco.VideoConverter;
using NReco.VideoInfo;

namespace Video_Manager_By_Neimark
{
    public partial class LoadDirectoryForm : Form
    {
        private TheMainForm MainForm;
        private bool Closable = false;
        private bool Stopped = false;
        private VideoScanner Scanner;

        public CancellationTokenSource TS;
        public CancellationToken CT;

        public LoadDirectoryForm(TheMainForm MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        private void LoadDirectoryForm_Load(object sender, EventArgs e)
        {
            MainForm.VideoList = new List<Video>();
            MainForm.VideoList_SearchResult = new List<Video>();
            MainForm.NoInfoVideoList = new List<Video>();
            MainForm.NoInfoVideoList_SearchResult = new List<Video>();
            this.Text = "Scanning for Videos in \"" + MainForm.folderBrowser.SelectedPath + "\"";
            lbl_extraInfo.Text = "Scanning for: ";
            foreach (string extension in Properties.Settings.Default.VideoExtensionsToScan)
                lbl_extraInfo.Text += "\"." + extension.ToLower() + "\", ";
            lbl_extraInfo.Text = lbl_extraInfo.Text.Substring(0, lbl_extraInfo.Text.Length - 2);
            MainForm.Enabled = false;
            TS = new CancellationTokenSource();
            CT = TS.Token;
            Action ScanTask = () =>
            {
                Scanner = new VideoScanner(MainForm, this, CT);
                Scanner.Scan(MainForm.folderBrowser.SelectedPath);
            };
            System.Threading.Tasks.Task.Factory.StartNew(ScanTask);
        }

        private void LoadDirectoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Enabled = true;
        }

        private void LoadDirectoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Closable)
            {
                e.Cancel = true;
                this.Enabled = false;
                if (MessageBox.Show("Do you want to stop scanning for videos in \"" + MainForm.folderBrowser.SelectedPath + "\"?", "Close Loading", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Stopped = true;
                    TS.Cancel();
                }
                this.Enabled = true;
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void WriteLog(string text, Color color)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    int start = richtxtbox_Logs.TextLength;
                    richtxtbox_Logs.AppendText(text);
                    int end = richtxtbox_Logs.TextLength;
                    richtxtbox_Logs.Select(start, end - start);
                    richtxtbox_Logs.SelectionColor = color;
                    richtxtbox_Logs.SelectionLength = 0;
                    richtxtbox_Logs.AppendText(Environment.NewLine);
                    richtxtbox_Logs.SelectionStart = richtxtbox_Logs.Text.Length;
                    richtxtbox_Logs.ScrollToCaret();
                }));
            }
            catch (Exception ex)
            {
                this.Enabled = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
        }

        public void WriteLog(string text)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    richtxtbox_Logs.AppendText(text + Environment.NewLine);
                    richtxtbox_Logs.SelectionStart = richtxtbox_Logs.Text.Length;
                    richtxtbox_Logs.ScrollToCaret();
                }));
            }
            catch (Exception ex)
            {
                this.Enabled = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
        }

        public void DoneScan()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    Closable = true;
                    btn_close.Text = "Close";
                    WriteLog(Environment.NewLine + Environment.NewLine);
                    if (Stopped)
                    {
                        WriteLog(" =====Scan Stopped=====", Color.Violet);
                        MainForm.statusLabel_statusLabel.Text = "Videos(Incomplete - Scan Stopped) Loaded from \"" + MainForm.folderBrowser.SelectedPath + "\"";
                    }
                    else
                    {
                        WriteLog(" =====Scan Complete=====", Color.Green);
                        MainForm.statusLabel_statusLabel.Text = "Videos Loaded from \"" + MainForm.folderBrowser.SelectedPath + "\"";
                    }
                    MainForm.mvDisplayAllVideos();
                    MainForm.nifDisplayAllVideos();
                    MainForm.RefreshTabsToEnable();
                    MainForm.Loaded = true;
                }));
            }
            catch (Exception ex)
            {
                this.Enabled = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
        }
    }
    public class VideoScanner
    {
        private TheMainForm MainForm;
        private LoadDirectoryForm LoadForm;
        private CancellationToken CT;
        private bool LoopInitialized = false;

        public VideoScanner(TheMainForm MainForm, LoadDirectoryForm LoadForm, CancellationToken CT)
        {
            this.MainForm = MainForm;
            this.LoadForm = LoadForm;
            this.CT = CT;
        }
        public void Scan(string directory)
        {
            //Check if it the first call of method
            bool Callback = false;
            if (!LoopInitialized)
            {
                Callback = true;
                LoopInitialized = true;
            }

            //Code Start=================================================================
            DirectoryInfo Folder = new DirectoryInfo(directory);
            LoadForm.WriteLog("Scanning: \"" + Folder.FullName + "\"");
            try
            {
                foreach (FileInfo file in Folder.GetFiles())
                {
                    if (CT.IsCancellationRequested)
                        break;
                    if (Properties.Settings.Default.VideoExtensionsToScan.Contains(file.Extension.ToUpper().Split('.').Last().Trim()))
                    {
                        string VideoInfoFileaname = new Video(file, new VideoInfo()).getInfoFullName();
                        FileInfo VideoInfoFile = new FileInfo(VideoInfoFileaname);
                        if (VideoInfoFile.Exists)
                        {
                            try
                            {
                                //Valid Video
                                VideoInfo info = new JavaScriptSerializer().Deserialize<VideoInfo>(File.ReadAllText(VideoInfoFile.FullName));
                                Video video = new Video(file, info);
                                MainForm.VideoList.Add(video);
                                LoadForm.WriteLog("Valid Video: " + file.Name, Color.Blue);

                                //Check Thumbnail
                                if (!new FileInfo(video.getThumbnailFullName()).Exists)
                                {
                                    LoadForm.WriteLog("Creating Thumnail for: " + file.Name, Color.Indigo);
                                    video.createThumbnail();
                                }
                            }
                            catch
                            {
                                //Corrupted File
                                MainForm.NoInfoVideoList.Add(new Video(file, new VideoInfo()));
                                LoadForm.WriteLog("Corrupted Info Video: " + file.Name, Color.BlueViolet);
                            }
                        }
                        else
                        {
                            //No Info
                            MainForm.NoInfoVideoList.Add(new Video(file, new VideoInfo()));
                            LoadForm.WriteLog("No Info Video: " + file.Name, Color.BlueViolet);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                LoadForm.WriteLog("Error: " + ex.Message, Color.Red);
            }


            try
            {
                foreach (DirectoryInfo SubFolder in Folder.GetDirectories())
                {
                    if (CT.IsCancellationRequested)
                        break;
                    Scan(SubFolder.FullName);
                }
            }
            catch (Exception ex)
            {
                LoadForm.WriteLog("Error: " + ex.Message, Color.Red);
            }
            //Code End===================================================================




            //Check to signal that scan is done
            if (Callback)
            {
                LoadForm.DoneScan();
                for (int i = 0; i < MainForm.NoInfoVideoList.Count; i++)
                {
                    try
                    {
                        if (myTools.SupplyVideoInfos_ReturnErrorMessage(MainForm.NoInfoVideoList[i]) != null)
                            MainForm.nifDeleteVideoFromList(MainForm.NoInfoVideoList[i]);
                        else
                            MainForm.NoInfoVideoList[i].Info.Title = "data-loaded";
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
