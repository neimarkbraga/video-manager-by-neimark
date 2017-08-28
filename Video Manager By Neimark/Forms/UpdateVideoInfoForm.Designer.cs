namespace Video_Manager_By_Neimark
{
    partial class UpdateVideoInfoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVideoInfoForm));
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.lbl_durationlbl = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_dimensionlbl = new System.Windows.Forms.Label();
            this.lbl_Dimension = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_resolution = new System.Windows.Forms.Label();
            this.numericUpDown_year = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_resolution = new System.Windows.Forms.NumericUpDown();
            this.lbl_genreInstruction = new System.Windows.Forms.Label();
            this.richTextBox_genre = new System.Windows.Forms.RichTextBox();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.trackBar_thumbnail = new System.Windows.Forms.TrackBar();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.openFileDialog_image = new System.Windows.Forms.OpenFileDialog();
            this.pnl_footer.SuspendLayout();
            this.pnl_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.btn_cancel);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(5, 521);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(424, 35);
            this.pnl_footer.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(265, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(346, 6);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.AutoScroll = true;
            this.pnl_content.Controls.Add(this.lbl_durationlbl);
            this.pnl_content.Controls.Add(this.lbl_duration);
            this.pnl_content.Controls.Add(this.lbl_dimensionlbl);
            this.pnl_content.Controls.Add(this.lbl_Dimension);
            this.pnl_content.Controls.Add(this.lbl_p);
            this.pnl_content.Controls.Add(this.label2);
            this.pnl_content.Controls.Add(this.lbl_resolution);
            this.pnl_content.Controls.Add(this.numericUpDown_year);
            this.pnl_content.Controls.Add(this.numericUpDown_resolution);
            this.pnl_content.Controls.Add(this.lbl_genreInstruction);
            this.pnl_content.Controls.Add(this.richTextBox_genre);
            this.pnl_content.Controls.Add(this.lbl_genre);
            this.pnl_content.Controls.Add(this.richTextBox_description);
            this.pnl_content.Controls.Add(this.lbl_description);
            this.pnl_content.Controls.Add(this.trackBar_thumbnail);
            this.pnl_content.Controls.Add(this.textBox_title);
            this.pnl_content.Controls.Add(this.lbl_title);
            this.pnl_content.Controls.Add(this.pictureBox_image);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(5, 5);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(424, 516);
            this.pnl_content.TabIndex = 2;
            // 
            // lbl_durationlbl
            // 
            this.lbl_durationlbl.AutoSize = true;
            this.lbl_durationlbl.Location = new System.Drawing.Point(244, 460);
            this.lbl_durationlbl.Name = "lbl_durationlbl";
            this.lbl_durationlbl.Size = new System.Drawing.Size(47, 13);
            this.lbl_durationlbl.TabIndex = 17;
            this.lbl_durationlbl.Text = "Duration";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(297, 460);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(49, 13);
            this.lbl_duration.TabIndex = 16;
            this.lbl_duration.Text = "00:00:00";
            // 
            // lbl_dimensionlbl
            // 
            this.lbl_dimensionlbl.AutoSize = true;
            this.lbl_dimensionlbl.Location = new System.Drawing.Point(61, 460);
            this.lbl_dimensionlbl.Name = "lbl_dimensionlbl";
            this.lbl_dimensionlbl.Size = new System.Drawing.Size(56, 13);
            this.lbl_dimensionlbl.TabIndex = 15;
            this.lbl_dimensionlbl.Text = "Dimension";
            // 
            // lbl_Dimension
            // 
            this.lbl_Dimension.AutoSize = true;
            this.lbl_Dimension.Location = new System.Drawing.Point(123, 460);
            this.lbl_Dimension.Name = "lbl_Dimension";
            this.lbl_Dimension.Size = new System.Drawing.Size(24, 13);
            this.lbl_Dimension.TabIndex = 14;
            this.lbl_Dimension.Text = "0x0";
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Location = new System.Drawing.Point(231, 441);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(13, 13);
            this.lbl_p.TabIndex = 13;
            this.lbl_p.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Year";
            // 
            // lbl_resolution
            // 
            this.lbl_resolution.AutoSize = true;
            this.lbl_resolution.Location = new System.Drawing.Point(60, 436);
            this.lbl_resolution.Name = "lbl_resolution";
            this.lbl_resolution.Size = new System.Drawing.Size(57, 13);
            this.lbl_resolution.TabIndex = 11;
            this.lbl_resolution.Text = "Resolution";
            // 
            // numericUpDown_year
            // 
            this.numericUpDown_year.Location = new System.Drawing.Point(297, 434);
            this.numericUpDown_year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_year.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown_year.Name = "numericUpDown_year";
            this.numericUpDown_year.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown_year.TabIndex = 5;
            this.numericUpDown_year.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // numericUpDown_resolution
            // 
            this.numericUpDown_resolution.Location = new System.Drawing.Point(123, 434);
            this.numericUpDown_resolution.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown_resolution.Name = "numericUpDown_resolution";
            this.numericUpDown_resolution.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown_resolution.TabIndex = 4;
            this.numericUpDown_resolution.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // lbl_genreInstruction
            // 
            this.lbl_genreInstruction.AutoSize = true;
            this.lbl_genreInstruction.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genreInstruction.Location = new System.Drawing.Point(14, 384);
            this.lbl_genreInstruction.Name = "lbl_genreInstruction";
            this.lbl_genreInstruction.Size = new System.Drawing.Size(103, 15);
            this.lbl_genreInstruction.TabIndex = 8;
            this.lbl_genreInstruction.Text = "Separate by comma (,)";
            // 
            // richTextBox_genre
            // 
            this.richTextBox_genre.Location = new System.Drawing.Point(123, 368);
            this.richTextBox_genre.Name = "richTextBox_genre";
            this.richTextBox_genre.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_genre.Size = new System.Drawing.Size(276, 60);
            this.richTextBox_genre.TabIndex = 3;
            this.richTextBox_genre.Text = "";
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Location = new System.Drawing.Point(71, 371);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(46, 13);
            this.lbl_genre.TabIndex = 7;
            this.lbl_genre.Text = "Genre/s";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(123, 302);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_description.Size = new System.Drawing.Size(276, 60);
            this.richTextBox_description.TabIndex = 2;
            this.richTextBox_description.Text = "";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(57, 305);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 5;
            this.lbl_description.Text = "Description";
            // 
            // trackBar_thumbnail
            // 
            this.trackBar_thumbnail.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_thumbnail.Location = new System.Drawing.Point(0, 196);
            this.trackBar_thumbnail.Name = "trackBar_thumbnail";
            this.trackBar_thumbnail.Size = new System.Drawing.Size(424, 45);
            this.trackBar_thumbnail.TabIndex = 4;
            this.trackBar_thumbnail.TabStop = false;
            this.trackBar_thumbnail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_thumbnail_MouseUp);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(123, 276);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(276, 20);
            this.textBox_title.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(90, 279);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title";
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_image.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(424, 196);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 1;
            this.pictureBox_image.TabStop = false;
            // 
            // UpdateVideoInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_footer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "UpdateVideoInfoForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateVideoInfoForm";
            this.Load += new System.EventHandler(this.UpdateVideoInfoForm_Load);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.OpenFileDialog openFileDialog_image;
        private System.Windows.Forms.TrackBar trackBar_thumbnail;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label lbl_genreInstruction;
        private System.Windows.Forms.RichTextBox richTextBox_genre;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_resolution;
        private System.Windows.Forms.NumericUpDown numericUpDown_year;
        private System.Windows.Forms.NumericUpDown numericUpDown_resolution;
        private System.Windows.Forms.Label lbl_Dimension;
        private System.Windows.Forms.Label lbl_durationlbl;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_dimensionlbl;

    }
}