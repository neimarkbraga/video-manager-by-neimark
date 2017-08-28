using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using NReco.VideoConverter;
using System.IO;

namespace Video_Manager_By_Neimark
{
    public partial class UpdateVideoInfoForm : Form
    {
        private TheMainForm MainForm;
        private VideoPreviewControl PreviewForm;
        private Video OriginalVideo;
        private Video DraftVideo;
        private int ImageFrame = -1;
        private Image SelectedImage;


        public UpdateVideoInfoForm(TheMainForm MainForm, VideoPreviewControl PreviewForm, Video OriginalVideo)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.PreviewForm = PreviewForm;
            this.OriginalVideo = OriginalVideo;
        }

        private void UpdateVideoInfoForm_Load(object sender, EventArgs e)
        {
            DraftVideo = OriginalVideo.Clone();
            textBox_title.Text = DraftVideo.Info.Title;
            richTextBox_description.Text = DraftVideo.Info.Description;
            richTextBox_genre.Text = DraftVideo.Info.getGenreString();
            numericUpDown_resolution.Value = DraftVideo.Info.Resolution;
            numericUpDown_year.Value = DraftVideo.Info.Year;
            lbl_Dimension.Text = "(" + DraftVideo.Info.getDimensionString() + ")";
            lbl_duration.Text = DraftVideo.Info.getDurationString();


            this.Text = "Update Video Info: \"" + DraftVideo.Info.Title + "\"";
            pictureBox_image.ImageLocation = DraftVideo.getThumbnailFullName();
            trackBar_thumbnail.Minimum = 0;
            trackBar_thumbnail.Maximum = DraftVideo.Info.getTotalSeconds();
            trackBar_thumbnail.Value = DraftVideo.Info.getTotalSeconds() / 2;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar_thumbnail_MouseUp(object sender, MouseEventArgs e)
        {
            if (ImageFrame != trackBar_thumbnail.Value)
            {
                try
                {
                    ImageFrame = trackBar_thumbnail.Value;
                    Stream stream = new MemoryStream();
                    new FFMpegConverter().GetVideoThumbnail(DraftVideo.VideoFile.FullName, stream, ImageFrame);
                    SelectedImage = Image.FromStream(stream);
                    pictureBox_image.Image = SelectedImage;
                    pictureBox_image.ImageLocation = null;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool NewImageSet = pictureBox_image.ImageLocation == null;
            DraftVideo.Info.Title = textBox_title.Text;
            DraftVideo.Info.Description = richTextBox_description.Text;
            DraftVideo.Info.Genre = new List<string>();
            foreach (string genre in richTextBox_genre.Text.Split(richTextBox_genre.Text.Contains(',') ? ',' : '|'))
                if (!DraftVideo.Info.Genre.Contains(genre.Trim()) && genre.Trim() != "")
                    DraftVideo.Info.Genre.Add(genre.Trim());
            DraftVideo.Info.Year = (int)numericUpDown_year.Value;
            DraftVideo.Info.Resolution = (int)numericUpDown_resolution.Value;

            if (new JavaScriptSerializer().Serialize(DraftVideo.Info) != new JavaScriptSerializer().Serialize(OriginalVideo.Info) || NewImageSet)
            {
                try
                {
                    DraftVideo.saveInfo();
                    if (NewImageSet)
                        SelectedImage.Save(DraftVideo.getThumbnailFullName());
                    int v_index = MainForm.VideoList.IndexOf(OriginalVideo);
                    int vr_index = MainForm.VideoList_SearchResult.IndexOf(OriginalVideo);
                    MainForm.VideoList[v_index] = DraftVideo.Clone();
                    MainForm.VideoList_SearchResult[vr_index] = MainForm.VideoList[v_index];
                    for (int i = 0; i < MainForm.listView_mvResult.Items.Count; i++)
                        if (MainForm.listView_mvResult.Items[i].Tag.ToString() == vr_index.ToString())
                        {
                            ListViewItem l = DraftVideo.createListViewItemCompleteInfo();
                            MainForm.listView_mvResult.Focus();
                            MainForm.listView_mvResult.Select();
                            MainForm.listView_mvResult.Items[i] = l;
                            MainForm.listView_mvResult.Items[i].Tag = vr_index;
                            MainForm.listView_mvResult.Items[i].Selected = true;
                            MainForm.listView_mvResult.Items[i].Focused = true;
                            MainForm.mvRefreshResolutionList();
                        }
                    this.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nothing to save. There are no changes.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
