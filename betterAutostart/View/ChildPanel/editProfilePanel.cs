using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using betterAutostart.Common.ProfileClasses;

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
            this.Init();
            this.UpdateTranslation();
        }

        private void UpdateTranslation()
        {
            this.lbl_pName.Text = Config.ActiveLanguage.Strings.EditPName;
            this.lbl_pNameMaxChars.Text = Config.ActiveLanguage.Strings.EditPMax16Characters;
            this.lbl_pExecutables.Text = Config.ActiveLanguage.Strings.EditPExecutableList;
            this.btn_addNewExecutable.Text = Config.ActiveLanguage.Strings.EditPAddNewExecutable;
            this.lbl_pAttributes.Text = Config.ActiveLanguage.Strings.EditPAttributes;
            this.chkBx_autostartWSys.Text = Config.ActiveLanguage.Strings.EditPAutostartWithSystem;
            this.chkBx_execAsAdmin.Text = Config.ActiveLanguage.Strings.EditPExecuteAsAdmin;
            this.lbl_pHotkeySettings.Text = Config.ActiveLanguage.Strings.EditPHotkeySettings;
            this.lbl_hotkeyStartAll.Text = Config.ActiveLanguage.Strings.EditPHotkeyStartAll;
            this.lbl_hotkeyStopAll.Text = Config.ActiveLanguage.Strings.EditPHotkeyStopAll;
            this.btn_deleteProfile.Text = Config.ActiveLanguage.Strings.EditPDeleteProfile;
            this.btn_saveChanges.Text = Config.ActiveLanguage.Strings.EditPSaveProfile;
            this.btn_back.Text = Config.ActiveLanguage.Strings.EditPBack;
        }

        private void Init()
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
                    this.GenerateContextMenu(listboxContextMenu);

                    listboxContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void GenerateContextMenu(ContextMenuStrip listboxContextMenu)
        {
            this.listboxContextMenu.Items.Clear();
            this.listboxContextMenu.Items.Add(Config.ActiveLanguage.Strings.EditPLstbxContextMenuEdit, null, new EventHandler(listBxContextMenu_editEntry));
            this.listboxContextMenu.Items.Add(Config.ActiveLanguage.Strings.EditPLstbxContextMenuOpenInExplorer, null, new EventHandler(listBxContextMenu_openEntryInExplorer));
            this.listboxContextMenu.Items.Add("-");
            this.listboxContextMenu.Items.Add(Config.ActiveLanguage.Strings.EditPLstbxContextMenuRemove, null, new EventHandler(this.listBxContextMenu_deleteEntry));
        }

        private void listBxContextMenu_deleteEntry(object sender, EventArgs e)
        {
            int selectedIndex = this.lstBx_pExecutables.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < this.selectedProfile.GetEditableExecutablesList().Count())
            {
                this.selectedProfile.RemoveExecutableByIndex(selectedIndex);
                this.ReloadListBox();
            }
        }

        private void listBxContextMenu_openEntryInExplorer(object sender, EventArgs e)
        {
            int selectedIndex = this.lstBx_pExecutables.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < this.selectedProfile.GetEditableExecutablesList().Count())
            {
                Utility.ExploreFile(this.selectedProfile.GetExecutableByIndex(selectedIndex).Path);
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
            this.ReloadListBox();
        }

        private void btn_addNewExecutable_Click(object sender, EventArgs e)
        {
            string filePath = "";
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
                this.selectedProfile.AddNewExecutableApp(filePath);
                this.ReloadListBox();
            }
        }

        private void txtBx_pName_TextChanged(object sender, EventArgs e)
        {
            string text = txtBx_pName.Text;
            if (text.Length <= 0 || text == null) return;

            char[] chars = text.ToCharArray();
            bool wronChar = false;
            for(int i = 0; i < chars.Count(); i++)
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(chars[i].ToString(), @"^[a-zA-Z _-]"))
                {
                    txtBx_pName.Text = text.Replace(chars[i], ' ');
                    lbl_txtBxError.Text = Config.ActiveLanguage.Strings.EditPErrorOnlyAlphabeticChars;
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

        private void ReloadListBox()
        {
            this.lstBx_pExecutables.Items.Clear();
            this.lstBx_pExecutables.Items.AddRange(this.selectedProfile.GetEditableExecutablesList().ToArray());
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            string oldName = this.selectedProfile.Name;
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
