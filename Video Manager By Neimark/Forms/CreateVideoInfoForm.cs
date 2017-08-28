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
using NReco.VideoConverter;

namespace Video_Manager_By_Neimark
{
    public partial class CreateVideoInfoForm : Form
    {
        TheMainForm MainForm;
        Video OriginalVideo;
        Video DraftVideo;
        private int ImageFrame = -1;

        public CreateVideoInfoForm(TheMainForm MainForm, Video OriginalVideo)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.OriginalVideo = OriginalVideo;
        }

        private void CreateVideoInfoForm_Load(object sender, EventArgs e)
        {
            DraftVideo = OriginalVideo.Clone();
            DraftVideo.Info.Title = Path.GetFileNameWithoutExtension(DraftVideo.VideoFile.FullName);
            DraftVideo.Info.Year = DraftVideo.VideoFile.LastWriteTime.Year;
            DraftVideo.Info.Resolution = DraftVideo.Info.getGuessResolution();
            Text = "Create Video Info for \"" + DraftVideo.VideoFile.FullName + "\"";
            textBox_title.Text = DraftVideo.Info.Title;
            richTextBox_description.Text = DraftVideo.Info.Description;
            richTextBox_genre.Text = DraftVideo.Info.getGenreString();
            numericUpDown_resolution.Value = DraftVideo.Info.Resolution;
            numericUpDown_year.Value = DraftVideo.Info.Year;
            lbl_Dimension.Text = "(" + DraftVideo.Info.getDimensionString() + ")";
            lbl_duration.Text = DraftVideo.Info.getDurationString();
            trackBar_thumbnail.Minimum = 0;
            trackBar_thumbnail.Maximum = DraftVideo.Info.getTotalSeconds();
            trackBar_thumbnail.Value = trackBar_thumbnail.Maximum / 2;
            if (DraftVideo.TemporaryImage == null)
                LoadThumbnail();
            else
                pictureBox_image.Image = DraftVideo.TemporaryImage;
        }

        private void trackBar_thumbnail_MouseUp(object sender, MouseEventArgs e)
        {
            LoadThumbnail();
        }

        private void LoadThumbnail()
        {
            if (ImageFrame != trackBar_thumbnail.Value)
            {
                try
                {
                    ImageFrame = trackBar_thumbnail.Value;
                    Stream stream = new MemoryStream();
                    new FFMpegConverter().GetVideoThumbnail(DraftVideo.VideoFile.FullName, stream, ImageFrame);
                    DraftVideo.TemporaryImage = Image.FromStream(stream);
                    pictureBox_image.Image = DraftVideo.TemporaryImage;
                    pictureBox_image.ImageLocation = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                DraftVideo.Info.Title = textBox_title.Text;
                DraftVideo.Info.Description = richTextBox_description.Text;
                DraftVideo.Info.Genre = new List<string>();
                foreach (string genre in richTextBox_genre.Text.Split(richTextBox_genre.Text.Contains(',') ? ',' : '|'))
                    if (!DraftVideo.Info.Genre.Contains(genre.Trim()) && genre.Trim() != "")
                        DraftVideo.Info.Genre.Add(genre.Trim());
                DraftVideo.Info.Year = (int)numericUpDown_year.Value;
                DraftVideo.Info.Resolution = (int)numericUpDown_resolution.Value;
                DraftVideo.saveInfo();
                DraftVideo.createThumbnail(DraftVideo.TemporaryImage);
                int v_index = MainForm.NoInfoVideoList.IndexOf(OriginalVideo);
                int vr_index = MainForm.NoInfoVideoList_SearchResult.IndexOf(OriginalVideo);
                MainForm.pnl_nifInfo.Controls.Clear();
                MainForm.NoInfoVideoList.RemoveAt(v_index);
                MainForm.NoInfoVideoList_SearchResult.RemoveAt(vr_index);
                MainForm.VideoList.Add(DraftVideo);
                MainForm.nifRenderVideos();
                MainForm.mvDisplayAllVideos();
                MainForm.RefreshTabsToEnable();
                this.Close();



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
