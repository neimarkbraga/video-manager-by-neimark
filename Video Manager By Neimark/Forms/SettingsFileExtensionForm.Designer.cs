namespace Video_Manager_By_Neimark
{
    partial class SettingsFileExtensionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFileExtensionForm));
            this.listBox_Extensions = new System.Windows.Forms.ListBox();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.txtBox_input = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_resetToDefault = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Extensions
            // 
            this.listBox_Extensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Extensions.FormattingEnabled = true;
            this.listBox_Extensions.Location = new System.Drawing.Point(5, 38);
            this.listBox_Extensions.Name = "listBox_Extensions";
            this.listBox_Extensions.Size = new System.Drawing.Size(324, 208);
            this.listBox_Extensions.TabIndex = 0;
            this.listBox_Extensions.SelectedIndexChanged += new System.EventHandler(this.listBox_Extensions_SelectedIndexChanged);
            this.listBox_Extensions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox_Extensions_KeyUp);
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.txtBox_input);
            this.pnl_footer.Controls.Add(this.btn_add);
            this.pnl_footer.Controls.Add(this.btn_Remove);
            this.pnl_footer.Controls.Add(this.btn_resetToDefault);
            this.pnl_footer.Controls.Add(this.btn_close);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(5, 246);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(324, 60);
            this.pnl_footer.TabIndex = 1;
            // 
            // txtBox_input
            // 
            this.txtBox_input.Location = new System.Drawing.Point(3, 6);
            this.txtBox_input.Name = "txtBox_input";
            this.txtBox_input.Size = new System.Drawing.Size(156, 20);
            this.txtBox_input.TabIndex = 5;
            this.txtBox_input.TextChanged += new System.EventHandler(this.txtBox_input_TextChanged);
            this.txtBox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_input_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(165, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Enabled = false;
            this.btn_Remove.Location = new System.Drawing.Point(246, 4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_resetToDefault
            // 
            this.btn_resetToDefault.Location = new System.Drawing.Point(135, 32);
            this.btn_resetToDefault.Name = "btn_resetToDefault";
            this.btn_resetToDefault.Size = new System.Drawing.Size(105, 23);
            this.btn_resetToDefault.TabIndex = 3;
            this.btn_resetToDefault.Text = "Reset to Default";
            this.btn_resetToDefault.UseVisualStyleBackColor = true;
            this.btn_resetToDefault.Click += new System.EventHandler(this.btn_resetToDefault_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_description.Location = new System.Drawing.Point(5, 5);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_description.Size = new System.Drawing.Size(324, 33);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "List of video extensions to scan.";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(246, 33);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // SettingsFileExtensionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.listBox_Extensions);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.pnl_footer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "SettingsFileExtensionForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Extension to Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsFileExtensionForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsFileExtensionForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsFileExtensionForm_Load);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Extensions;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_resetToDefault;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txtBox_input;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_close;
    }
}