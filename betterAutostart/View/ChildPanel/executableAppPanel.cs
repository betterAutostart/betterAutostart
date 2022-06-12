using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using betterAutostart.Common.ProfileClasses;

namespace betterAutostart
{
    public partial class executableAppPanel : Form
    {
        ExecutableApp selectedApp;
        Profile appProfile;

       

        public executableAppPanel(ExecutableApp app, Profile profile)
        {
            InitializeComponent();
            this.selectedApp = app;
            this.appProfile = profile;

            this.Text = "BetterAutostart";
            Utility.SetIcon(this);

            this.UpdateTranslation();

            Region = Region.FromHrgn(Utility.CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            this.pnl_background.Region = Region.FromHrgn(Utility.CreateRoundRectRgn(0, 0, this.pnl_background.Width, this.pnl_background.Height, 12, 12));

            this.txtBx_eName.Text = this.selectedApp.CustomName;
            this.lbl_path.Text = this.selectedApp.Path;
            this.chkBx_execAsAdmin.Checked = this.selectedApp.ExecuteAsAdmin;
            if (!Utility.IsExecutable(this.selectedApp.Path))
            {
                this.chkBx_autoRestart.Hide();
            }
        }

        private void UpdateTranslation()
        {
            this.lbl_eName.Text = Config.ActiveLanguage.Strings.EditExecName;
            this.lbl_eNameMaxChars.Text = Config.ActiveLanguage.Strings.EditExecName;
            this.lbl_pathHeader.Text = Config.ActiveLanguage.Strings.EditExecPathHeader;
            this.btn_editPath.Text = Config.ActiveLanguage.Strings.EditExecEditPath;
            this.lbl_eAttributes.Text = Config.ActiveLanguage.Strings.EditExecAttributeHeader;
            this.chkBx_execAsAdmin.Text = Config.ActiveLanguage.Strings.EditExecExecAsAdmin;
            this.btn_deleteExecutableApp.Text = Config.ActiveLanguage.Strings.EditExecDeleteExecApp;
            this.btn_saveChanges.Text = Config.ActiveLanguage.Strings.EditExecSaveExecApp;
            this.chkBx_autoRestart.Text = Config.ActiveLanguage.Strings.EditExecAutostart;
        }
        
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBx_eName_TextChanged(object sender, EventArgs e)
        {
            string text = txtBx_eName.Text;
            if (text.Length <= 0 || text == null) return;

            char[] chars = text.ToCharArray();
            bool wronChar = false;
            for (int i = 0; i < chars.Count(); i++)
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(chars[i].ToString(), @"^[a-zA-Z _-]"))
                {
                    txtBx_eName.Text = text.Replace(chars[i], ' ');
                    lbl_txtBxError.Text = Config.ActiveLanguage.Strings.EditPErrorOnlyAlphabeticChars;
                    wronChar = true;
                }
            }

            if (!wronChar)
            {
                lbl_txtBxError.Text = "";
            }

            if (text.Length > 16)
            {
                this.txtBx_eName.Text = text.Remove(text.Length - 1);
            }
        }

        private void btn_editPath_Click(object sender, EventArgs e)
        {
            string filePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (this.lbl_path.Text == "")
                {
                    openFileDialog.InitialDirectory = "c:\\";
                }
                else
                {
                    openFileDialog.InitialDirectory = this.lbl_path.Text;
                }
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
                this.lbl_path.Text = filePath;
            }
        }

        private void btn_deleteExecutableApp_Click(object sender, EventArgs e)
        {
            this.appProfile.DeleteExecutable(this.selectedApp);
            this.Close();
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            this.selectedApp.CustomName = this.txtBx_eName.Text;
            this.selectedApp.Path = this.lbl_path.Text;
            this.selectedApp.AutoRestart = this.chkBx_autoRestart.Checked;
            this.selectedApp.ExecuteAsAdmin = this.chkBx_execAsAdmin.Checked;

            this.Close();
        }
    }
}
