namespace Video_Manager_By_Neimark
{
    partial class NoInfoVideoPreviewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.pnl_createInfo = new System.Windows.Forms.Button();
            this.pnl_play = new System.Windows.Forms.Button();
            this.btn_openDirectory = new System.Windows.Forms.Button();
            this.pnl_contentContainer = new System.Windows.Forms.Panel();
            this.lbl_videoInfo = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.pictureBox_imagePreview = new System.Windows.Forms.PictureBox();
            this.pnl_footer.SuspendLayout();
            this.pnl_contentContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.pnl_createInfo);
            this.pnl_footer.Controls.Add(this.pnl_play);
            this.pnl_footer.Controls.Add(this.btn_openDirectory);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 604);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(300, 116);
            this.pnl_footer.TabIndex = 3;
            // 
            // pnl_createInfo
            // 
            this.pnl_createInfo.Location = new System.Drawing.Point(25, 80);
            this.pnl_createInfo.Name = "pnl_createInfo";
            this.pnl_createInfo.Size = new System.Drawing.Size(250, 30);
            this.pnl_createInfo.TabIndex = 2;
            this.pnl_createInfo.Text = "Create Info";
            this.pnl_createInfo.UseVisualStyleBackColor = true;
            this.pnl_createInfo.Click += new System.EventHandler(this.pnl_createInfo_Click);
            // 
            // pnl_play
            // 
            this.pnl_play.Location = new System.Drawing.Point(25, 44);
            this.pnl_play.Name = "pnl_play";
            this.pnl_play.Size = new System.Drawing.Size(250, 30);
            this.pnl_play.TabIndex = 1;
            this.pnl_play.Text = "Play";
            this.pnl_play.UseVisualStyleBackColor = true;
            this.pnl_play.Click += new System.EventHandler(this.pnl_play_Click);
            // 
            // btn_openDirectory
            // 
            this.btn_openDirectory.Location = new System.Drawing.Point(25, 8);
            this.btn_openDirectory.Name = "btn_openDirectory";
            this.btn_openDirectory.Size = new System.Drawing.Size(250, 30);
            this.btn_openDirectory.TabIndex = 0;
            this.btn_openDirectory.Text = "Open Directory";
            this.btn_openDirectory.UseVisualStyleBackColor = true;
            this.btn_openDirectory.Click += new System.EventHandler(this.btn_openDirectory_Click);
            // 
            // pnl_contentContainer
            // 
            this.pnl_contentContainer.AutoScroll = true;
            this.pnl_contentContainer.Controls.Add(this.lbl_videoInfo);
            this.pnl_contentContainer.Controls.Add(this.lbl_location);
            this.pnl_contentContainer.Controls.Add(this.lbl_filename);
            this.pnl_contentContainer.Controls.Add(this.pictureBox_imagePreview);
            this.pnl_contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contentContainer.Location = new System.Drawing.Point(0, 0);
            this.pnl_contentContainer.Name = "pnl_contentContainer";
            this.pnl_contentContainer.Size = new System.Drawing.Size(300, 720);
            this.pnl_contentContainer.TabIndex = 4;
            // 
            // lbl_videoInfo
            // 
            this.lbl_videoInfo.AutoSize = true;
            this.lbl_videoInfo.BackColor = System.Drawing.Color.Gray;
            this.lbl_videoInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_videoInfo.Location = new System.Drawing.Point(0, 257);
            this.lbl_videoInfo.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_videoInfo.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbl_videoInfo.Name = "lbl_videoInfo";
            this.lbl_videoInfo.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lbl_videoInfo.Size = new System.Drawing.Size(300, 23);
            this.lbl_videoInfo.TabIndex = 8;
            this.lbl_videoInfo.Text = "---";
            this.lbl_videoInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.BackColor = System.Drawing.Color.Black;
            this.lbl_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_location.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_location.Location = new System.Drawing.Point(0, 229);
            this.lbl_location.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_location.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Padding = new System.Windows.Forms.Padding(20, 5, 20, 10);
            this.lbl_location.Size = new System.Drawing.Size(300, 28);
            this.lbl_location.TabIndex = 6;
            this.lbl_location.Text = "Location";
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.BackColor = System.Drawing.Color.Black;
            this.lbl_filename.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filename.ForeColor = System.Drawing.Color.White;
            this.lbl_filename.Location = new System.Drawing.Point(0, 200);
            this.lbl_filename.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_filename.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lbl_filename.Size = new System.Drawing.Size(300, 29);
            this.lbl_filename.TabIndex = 5;
            this.lbl_filename.Text = "Filename";
            // 
            // pictureBox_imagePreview
            // 
            this.pictureBox_imagePreview.BackColor = System.Drawing.Color.Black;
            this.pictureBox_imagePreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_imagePreview.ErrorImage = null;
            this.pictureBox_imagePreview.InitialImage = null;
            this.pictureBox_imagePreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_imagePreview.Name = "pictureBox_imagePreview";
            this.pictureBox_imagePreview.Size = new System.Drawing.Size(300, 200);
            this.pictureBox_imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_imagePreview.TabIndex = 3;
            this.pictureBox_imagePreview.TabStop = false;
            // 
            // NoInfoVideoPreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_contentContainer);
            this.Name = "NoInfoVideoPreviewControl";
            this.Size = new System.Drawing.Size(300, 720);
            this.Load += new System.EventHandler(this.NoInfoVideoPreviewControl_Load);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_contentContainer.ResumeLayout(false);
            this.pnl_contentContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button pnl_createInfo;
        private System.Windows.Forms.Button pnl_play;
        private System.Windows.Forms.Button btn_openDirectory;
        private System.Windows.Forms.Panel pnl_contentContainer;
        private System.Windows.Forms.Label lbl_videoInfo;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.PictureBox pictureBox_imagePreview;

    }
}
