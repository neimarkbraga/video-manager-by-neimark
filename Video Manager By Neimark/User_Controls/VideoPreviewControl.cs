using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Video_Manager_By_Neimark
{
    public partial class VideoPreviewControl : UserControl
    {
        TheMainForm MainForm;
        Video video;
        public VideoPreviewControl(TheMainForm MainForm, Video video)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.video = video;
            this.pictureBox_imagePreview.ImageLocation = video.getThumbnailFullName();
            this.lbl_title.Text = video.Info.Title + " (" + video.Info.Year + ")";
            this.lbl_description.Text = video.Info.Description;
            this.lbl_videoInfo.Text = video.Info.getResolutionString() + "       |       (" + video.Info.getDimensionString() + ")       |       " + video.Info.getDurationString();
            if(video.Info.Genre.Count > 0)
                this.lbl_genre.Text = video.Info.getGenreString();
        }

        private void btn_openDirectory_Click(object sender, EventArgs e)
        {
            MainForm.mvEnsureSelected();
            Process.Start("explorer.exe", "/select,\"" + video.VideoFile.FullName);
        }

        private void pnl_play_Click(object sender, EventArgs e)
        {
            MainForm.mvEnsureSelected();
            Process.Start(video.VideoFile.FullName);
        }

        private void pnl_editInfo_Click(object sender, EventArgs e)
        {
            MainForm.mvEnsureSelected();
            new UpdateVideoInfoForm(MainForm, this, video).ShowDialog(MainForm);
        }
    }
}
