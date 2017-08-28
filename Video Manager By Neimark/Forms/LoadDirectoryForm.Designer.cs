namespace Video_Manager_By_Neimark
{
    partial class LoadDirectoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadDirectoryForm));
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_extraInfo = new System.Windows.Forms.Label();
            this.richtxtbox_Logs = new System.Windows.Forms.RichTextBox();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Controls.Add(this.btn_close);
            this.pnl_Footer.Controls.Add(this.lbl_extraInfo);
            this.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Footer.Location = new System.Drawing.Point(5, 427);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(474, 29);
            this.pnl_Footer.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(396, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Stop";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_extraInfo
            // 
            this.lbl_extraInfo.AutoSize = true;
            this.lbl_extraInfo.Location = new System.Drawing.Point(3, 8);
            this.lbl_extraInfo.Name = "lbl_extraInfo";
            this.lbl_extraInfo.Size = new System.Drawing.Size(0, 13);
            this.lbl_extraInfo.TabIndex = 1;
            // 
            // richtxtbox_Logs
            // 
            this.richtxtbox_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtbox_Logs.Location = new System.Drawing.Point(5, 5);
            this.richtxtbox_Logs.Name = "richtxtbox_Logs";
            this.richtxtbox_Logs.ReadOnly = true;
            this.richtxtbox_Logs.Size = new System.Drawing.Size(474, 422);
            this.richtxtbox_Logs.TabIndex = 1;
            this.richtxtbox_Logs.Text = "";
            // 
            // LoadDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.richtxtbox_Logs);
            this.Controls.Add(this.pnl_Footer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "LoadDirectoryForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadDirectoryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadDirectoryForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadDirectoryForm_FormClosed);
            this.Load += new System.EventHandler(this.LoadDirectoryForm_Load);
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox richtxtbox_Logs;
        private System.Windows.Forms.Label lbl_extraInfo;
    }
}