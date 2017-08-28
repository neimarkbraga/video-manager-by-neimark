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
using NReco.VideoConverter;
using NReco.VideoInfo;
using System.IO;
using System.Threading;
using System.Web.Script.Serialization;

namespace Video_Manager_By_Neimark
{
    public partial class NoInfoVideoPreviewControl : UserControl
    {
        TheMainForm MainForm;
        Video video;
        VideoInfoLoader InfoLoader;

        public NoInfoVideoPreviewControl(TheMainForm MainForm, Video video)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.video = video;
        }

        private void NoInfoVideoPreviewControl_Load(object sender, EventArgs e)
        {
            lbl_filename.Text = video.VideoFile.Name;
            lbl_location.Text = video.VideoFile.DirectoryName;
            if (video.Info.Title == "data-loaded")
            {
                LoadInformation();
            }
            else
            {
                Action LoadInfoTask = () =>
                {
                    InfoLoader = new VideoInfoLoader(MainForm, this);
                    InfoLoader.Load();
                };
                System.Threading.Tasks.Task.Factory.StartNew(LoadInfoTask);
            }
        }

        public void CancelLoading()
        {
            try
            {
                InfoLoader.TS.Cancel();
            }
            catch
            {

            }
        }

        private void btn_openDirectory_Click(object sender, EventArgs e)
        {
            MainForm.nifEnsureSelected();
            Process.Start("explorer.exe", "/select,\"" + video.VideoFile.FullName);
        }

        private void pnl_play_Click(object sender, EventArgs e)
        {
            MainForm.nifEnsureSelected();
            Process.Start(video.VideoFile.FullName);
        }

        private void LoadInformation()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                pictureBox_imagePreview.Image = video.TemporaryImage;
                lbl_videoInfo.Text = video.Info.getResolutionString() + "       |       (" + video.Info.getDimensionString() + ")       |       " + video.Info.getDurationString();
            }));
        }

        private class VideoInfoLoader
        {
            TheMainForm MainForm;
            NoInfoVideoPreviewControl PreviewControl;
            public CancellationTokenSource TS;
            private CancellationToken CT;


            public VideoInfoLoader(TheMainForm MainForm, NoInfoVideoPreviewControl PreviewControl)
            {
                this.MainForm = MainForm;
                this.PreviewControl = PreviewControl;
                TS = new CancellationTokenSource();
                CT = TS.Token;
            }

            public void Load()
            {   
                try
                {
                    string VideoInfo__ = myTools.SupplyVideoInfos_ReturnErrorMessage(PreviewControl.video);
                    if (VideoInfo__ != null)
                        MessageBox.Show(VideoInfo__, "Error 01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        PreviewControl.video.Info.Title = "data-loaded";
                    if (!CT.IsCancellationRequested)
                        PreviewControl.LoadInformation();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error 00", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pnl_createInfo_Click(object sender, EventArgs e)
        {
            MainForm.nifEnsureSelected();
            new CreateVideoInfoForm(MainForm, video).ShowDialog(MainForm);
        }
    }
}
