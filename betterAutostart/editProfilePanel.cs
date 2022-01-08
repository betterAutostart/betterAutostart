using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betterAutostart
{
    public partial class editProfilePanel : Form
    {
        private Profile selectedProfile;
        private ContextMenuStrip listboxContextMenu;

        public editProfilePanel(Profile profile)
        {
            InitializeComponent();
            selectedProfile = profile;
            this.init();
            this.updateTranslation();
        }

        private void updateTranslation()
        {
            this.lbl_pName.Text = Utility.GetTranslation("EDITP_NAME");
            this.lbl_pNameMaxChars.Text = Utility.GetTranslation("EDITP_MAX16CHARACTERS");
            this.lbl_pExecutables.Text = Utility.GetTranslation("EDITP_EXECUTABLELIST");
            this.btn_addNewExecutable.Text = Utility.GetTranslation("EDITP_ADDNEWEXECUTABLE");
            this.lbl_pAttributes.Text = Utility.GetTranslation("EDITP_ATTRIBUTES");
            this.chkBx_autostartWSys.Text = Utility.GetTranslation("EDITP_AUTOSTARTWITHSYSTEM");
            this.chkBx_execAsAdmin.Text = Utility.GetTranslation("EDITP_EXECUTEASADMIN");
            this.lbl_pHotkeySettings.Text = Utility.GetTranslation("EDITP_HOTKEYSETTINGS");
            this.lbl_hotkeyStartAll.Text = Utility.GetTranslation("EDITP_HOTKEYSTARTALL");
            this.lbl_hotkeyStopAll.Text = Utility.GetTranslation("EDITP_HOTKEYSTOPALL");
            this.btn_deleteProfile.Text = Utility.GetTranslation("EDITP_DELETEPROFILE");
            this.btn_saveChanges.Text = Utility.GetTranslation("EDITP_SAVEPROFILE");
            this.btn_back.Text = Utility.GetTranslation("EDITP_BACK");
        }

        private void init()
        {
            this.txtBx_pName.Text = this.selectedProfile.Name;
            this.lstBx_pExecutables.Items.AddRange(this.selectedProfile.GetEditableExecutablesList().ToArray());

            this.chkBx_autostartWSys.Checked = this.selectedProfile.ShouldAutostart;
            this.chkBx_execAsAdmin.Checked = this.selectedProfile.ExecuteAsAdmin;

            Config.ApplicationForm.OpenChildForm(this);
            Config.ApplicationForm.HighlightNav(null);
            
            this.lstBx_pExecutables.ContextMenuStrip = listboxContextMenu;
        }

        private void lstBx_pExecutables_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.lstBx_pExecutables.SelectedIndex = this.lstBx_pExecutables.IndexFromPoint(e.Location);
                if (this.lstBx_pExecutables.SelectedIndex >= 0 && this.lstBx_pExecutables.SelectedIndex < this.selectedProfile.GetEditableExecutablesList().Count())
                {
                    listboxContextMenu = new ContextMenuStrip();
                    this.generateContextMenu(listboxContextMenu);

                    listboxContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void generateContextMenu(ContextMenuStrip listboxContextMenu)
        {
            this.listboxContextMenu.Items.Clear();
            this.listboxContextMenu.Items.Add(Utility.GetTranslation("EDITP_LSTBXCONTEXTM_EDIT"), null, new EventHandler(listBxContextMenu_editEntry));
            this.listboxContextMenu.Items.Add(Utility.GetTranslation("EDITP_LSTBXCONTEXTM_OPENINEXPLORER"), null, new EventHandler(listBxContextMenu_openEntryInExplorer));
            this.listboxContextMenu.Items.Add("-");
            this.listboxContextMenu.Items.Add(Utility.GetTranslation("EDITP_LSTBXCONTEXTM_REMOVE"), null, new EventHandler(this.listBxContextMenu_deleteEntry));
        }

        private void listBxContextMenu_deleteEntry(object sender, EventArgs e)
        {
            int selectedIndex = this.lstBx_pExecutables.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < this.selectedProfile.GetEditableExecutablesList().Count())
            {
                this.selectedProfile.RemoveExecutableByIndex(selectedIndex);
                this.reloadListBox();
            }
        }

        private void listBxContextMenu_openEntryInExplorer(object sender, EventArgs e)
        {
            int selectedIndex = this.lstBx_pExecutables.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < this.selectedProfile.GetEditableExecutablesList().Count())
            {
                Utility.ExploreFile(this.selectedProfile.GetExecutableByIndex(selectedIndex).GetPath());
            }
        }

        private void listBxContextMenu_editEntry(object sender, EventArgs e)
        {
            int selectedIndex = this.lstBx_pExecutables.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < this.selectedProfile.GetEditableExecutablesList().Count())
            {
                executableAppPanel execPnl = new executableAppPanel(this.selectedProfile.GetExecutableByIndex(selectedIndex), this.selectedProfile);
                execPnl.FormClosing += new FormClosingEventHandler(this.onEditExecPanelClose);
                execPnl.Show();
            }
        }

        private void onEditExecPanelClose(object sender, EventArgs e)
        {
            this.reloadListBox();
        }

        private void btn_addNewExecutable_Click(object sender, EventArgs e)
        {
            String filePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            if (filePath != "")
            {
                this.selectedProfile.addNewExecutableApp(filePath);
                this.reloadListBox();
            }
        }

        private void txtBx_pName_TextChanged(object sender, EventArgs e)
        {
            String text = txtBx_pName.Text;
            if (text.Length <= 0 || text == null) return;

            char[] chars = text.ToCharArray();
            bool wronChar = false;
            for(int i = 0; i < chars.Count(); i++)
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(chars[i].ToString(), @"^[a-zA-Z _-]"))
                {
                    txtBx_pName.Text = text.Replace(chars[i], ' ');
                    lbl_txtBxError.Text = Utility.GetTranslation("EDITP_ERROR_ONLYALPHABETICCHARS");
                    wronChar = true;
                }
            }

            if(!wronChar)
            {
                lbl_txtBxError.Text = "";
            }


            if (text.Length > 16) 
            {
                txtBx_pName.Text = text.Remove(text.Length - 1);
            }
        }

        private void reloadListBox()
        {
            this.lstBx_pExecutables.Items.Clear();
            this.lstBx_pExecutables.Items.AddRange(this.selectedProfile.GetEditableExecutablesList().ToArray());
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            String oldName = this.selectedProfile.Name;
            this.selectedProfile.Name = this.txtBx_pName.Text;
            this.selectedProfile.ExecuteAsAdmin = this.chkBx_execAsAdmin.Checked;
            this.selectedProfile.ShouldAutostart = this.chkBx_autostartWSys.Checked;
            Config.SaveSystem.SaveProfile(this.selectedProfile, oldName);
            Config.ApplicationForm.OpenAutostartProfilePanel();
            this.Close();

            if (this.chkBx_autostartWSys.Checked)
            {
                Utility.AddAutostartRegistry();
            }
        }

        private void btn_deleteProfile_Click(object sender, EventArgs e)
        {
            Config.PHandler.DeleteProfile(this.selectedProfile);
            this.Close();
            Config.ApplicationForm.OpenAutostartProfilePanel();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Config.ApplicationForm.OpenAutostartProfilePanel();
        }
    }
}
