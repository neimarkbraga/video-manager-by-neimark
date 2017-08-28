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

namespace Video_Manager_By_Neimark
{
    public partial class SettingsFileExtensionForm : Form
    {
        private TheMainForm MainForm;
        private List<string> DefaultList = new List<string>();
        private List<string> CurrentList = new List<string>();
        private List<string> DraftList = new List<string>();
        private int SelectedIndex = -1;
        public SettingsFileExtensionForm(TheMainForm MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            MainForm.Enabled = false;
        }

        private void SettingsFileExtensionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Enabled = true;
        }

        private void SettingsFileExtensionForm_Load(object sender, EventArgs e)
        {
            foreach (string extension in Properties.Settings.Default.DefaultVideoExtensionsList)
                DefaultList.Add(extension);
            foreach (string extension in Properties.Settings.Default.VideoExtensionsToScan)
                CurrentList.Add(extension);
            DraftList = CurrentList.GetRange(0, CurrentList.Count);
            RenderDraftList();
            checkListIsDefault();
        }

        private void listBox_Extensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Extensions.SelectedIndex >= 0)
            {
                SelectedIndex = listBox_Extensions.SelectedIndex;
                btn_Remove.Enabled = true;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void Remove()
        {
            if (DraftList.Count < 2)
            {
                MessageBox.Show("You cannot clear all the items.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DraftList.Remove(DraftList[SelectedIndex]);
            RenderDraftList();
            SelectedIndex--;
            if (SelectedIndex < 0)
                SelectedIndex = 0;
            listBox_Extensions.SelectedIndex = SelectedIndex;
            checkListIsDefault();
        }

        private void btn_resetToDefault_Click(object sender, EventArgs e)
        {
            DraftList = DefaultList.GetRange(0, DefaultList.Count);
            RenderDraftList();
            checkListIsDefault();
        }

        private void SaveList()
        {
            System.Collections.Specialized.StringCollection newsetting = new System.Collections.Specialized.StringCollection();
            foreach (string extension in DraftList)
                newsetting.Add(extension);
            Properties.Settings.Default.VideoExtensionsToScan = newsetting;
            Properties.Settings.Default.Save();
            CurrentList = DraftList.GetRange(0, DraftList.Count);
        }

        private void Add()
        {
            if (txtBox_input.Text.Trim() == "")
            {
                MessageBox.Show("Enter an extension name.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DraftList.Contains(txtBox_input.Text.ToUpper()))
            {
                MessageBox.Show("Looks like it's already in the list.", "Already in list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBox_input.Text.Split('.').Count() > 1)
            {
                MessageBox.Show("You don't have to put a dot.", "Remove Dot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBox_input.Text.Trim().Split(' ').Count() > 1)
            {
                MessageBox.Show("An extension doesn't contain space/s.", "Space/s is not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DraftList.Add(txtBox_input.Text.ToUpper());
                RenderDraftList();
                txtBox_input.Text = "";
            }
            checkListIsDefault();
        }

        private void RenderDraftList()
        {
            listBox_Extensions.Items.Clear();
            btn_Remove.Enabled = false; 
            foreach (string extension in DraftList)
                listBox_Extensions.Items.Add(extension);
        }

        private void SettingsFileExtensionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            JavaScriptSerializer s = new JavaScriptSerializer();
            if (s.Serialize(CurrentList) != s.Serialize(DraftList))
            {
                SaveList();
                if (MainForm.Loaded)
                    if (MessageBox.Show("Do you want to reload videos in \"" + MainForm.folderBrowser.SelectedPath + "\"?", "Extension to scan changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        MainForm.loadVideos();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txtBox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Add();
            }
        }

        private void listBox_Extensions_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (listBox_Extensions.SelectedIndex >= 0)
                    Remove();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_input_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_input.Text.Trim() == "")
                btn_add.Enabled = false;
            else
                btn_add.Enabled = true;
        }

        private void checkListIsDefault()
        {
            List<string> l1 = DefaultList.GetRange(0, DefaultList.Count);
            List<string> l2 = DraftList.GetRange(0, DraftList.Count);
            l1.Sort();
            l2.Sort();
            JavaScriptSerializer s = new JavaScriptSerializer();
            if (s.Serialize(l1) != s.Serialize(l2))
                btn_resetToDefault.Enabled = true;
            else
                btn_resetToDefault.Enabled = false;
        }
    }
}
