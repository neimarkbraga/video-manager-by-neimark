namespace Video_Manager_By_Neimark
{
    partial class VideoPreviewControl
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
            this.pnl_editInfo = new System.Windows.Forms.Button();
            this.pnl_play = new System.Windows.Forms.Button();
            this.btn_openDirectory = new System.Windows.Forms.Button();
            this.pnl_contentContainer = new System.Windows.Forms.Panel();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_videoInfo = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox_imagePreview = new System.Windows.Forms.PictureBox();
            this.pnl_footer.SuspendLayout();
            this.pnl_contentContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.pnl_editInfo);
            this.pnl_footer.Controls.Add(this.pnl_play);
            this.pnl_footer.Controls.Add(this.btn_openDirectory);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 604);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(300, 116);
            this.pnl_footer.TabIndex = 1;
            // 
            // pnl_editInfo
            // 
            this.pnl_editInfo.Location = new System.Drawing.Point(25, 80);
            this.pnl_editInfo.Name = "pnl_editInfo";
            this.pnl_editInfo.Size = new System.Drawing.Size(250, 30);
            this.pnl_editInfo.TabIndex = 2;
            this.pnl_editInfo.Text = "Edit Info";
            this.pnl_editInfo.UseVisualStyleBackColor = true;
            this.pnl_editInfo.Click += new System.EventHandler(this.pnl_editInfo_Click);
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
            this.pnl_contentContainer.Controls.Add(this.lbl_genre);
            this.pnl_contentContainer.Controls.Add(this.lbl_videoInfo);
            this.pnl_contentContainer.Controls.Add(this.lbl_description);
            this.pnl_contentContainer.Controls.Add(this.lbl_title);
            this.pnl_contentContainer.Controls.Add(this.pictureBox_imagePreview);
            this.pnl_contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contentContainer.Location = new System.Drawing.Point(0, 0);
            this.pnl_contentContainer.Name = "pnl_contentContainer";
            this.pnl_contentContainer.Size = new System.Drawing.Size(300, 604);
            this.pnl_contentContainer.TabIndex = 2;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_genre.Location = new System.Drawing.Point(0, 280);
            this.lbl_genre.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_genre.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lbl_genre.Size = new System.Drawing.Size(300, 23);
            this.lbl_genre.TabIndex = 10;
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
            this.lbl_videoInfo.Text = "Information";
            this.lbl_videoInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Black;
            this.lbl_description.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_description.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_description.Location = new System.Drawing.Point(0, 229);
            this.lbl_description.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_description.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Padding = new System.Windows.Forms.Padding(20, 5, 20, 10);
            this.lbl_description.Size = new System.Drawing.Size(300, 28);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Video Description:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Black;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(0, 200);
            this.lbl_title.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_title.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lbl_title.Size = new System.Drawing.Size(300, 29);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Video Title";
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
            // VideoPreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_contentContainer);
            this.Controls.Add(this.pnl_footer);
            this.Name = "VideoPreviewControl";
            this.Size = new System.Drawing.Size(300, 720);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_contentContainer.ResumeLayout(false);
            this.pnl_contentContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button pnl_editInfo;
        private System.Windows.Forms.Button pnl_play;
        private System.Windows.Forms.Button btn_openDirectory;
        private System.Windows.Forms.Panel pnl_contentContainer;
        private System.Windows.Forms.PictureBox pictureBox_imagePreview;
        private System.Windows.Forms.Label lbl_videoInfo;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_genre;
    }
}
