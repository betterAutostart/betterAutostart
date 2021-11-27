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

            this.updateTranslation();

            Region = Region.FromHrgn(Utility.CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            this.pnl_background.Region = Region.FromHrgn(Utility.CreateRoundRectRgn(0, 0, this.pnl_background.Width, this.pnl_background.Height, 12, 12));

            this.txtBx_eName.Text = this.selectedApp.customName;
            this.lbl_path.Text = this.selectedApp.path;
            this.chkBx_execAsAdmin.Checked = this.selectedApp.executeAsAdmin;
        }

        private void updateTranslation()
        {
            this.lbl_eName.Text = Utility.GetTranslation("EDITEXEC_NAME");
            this.lbl_eNameMaxChars.Text = Utility.GetTranslation("EDITEXEC_NAME");
            this.lbl_pathHeader.Text = Utility.GetTranslation("EDITEXEC_PATHHEADER");
            this.btn_editPath.Text = Utility.GetTranslation("EDITEXEC_EDITPATH");
            this.lbl_eAttributes.Text = Utility.GetTranslation("EDITEXEC_ATTRIBUTEHEADER");
            this.chkBx_execAsAdmin.Text = Utility.GetTranslation("EDITEXEC_EXECASADMIN");
            this.btn_deleteExecutableApp.Text = Utility.GetTranslation("EDITEXEC_DELETEEXECAPP");
            this.btn_saveChanges.Text = Utility.GetTranslation("EDITEXEC_SAVEEXECAPP");
            this.chkBx_autoRestart.Text = Utility.GetTranslation("EDITEXEC_AUTORESTART");
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
            String text = txtBx_eName.Text;
            if (text.Length <= 0 || text == null) return;

            char[] chars = text.ToCharArray();
            bool wronChar = false;
            for (int i = 0; i < chars.Count(); i++)
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(chars[i].ToString(), @"^[a-zA-Z ]"))
                {
                    txtBx_eName.Text = text.Replace(chars[i], ' ');
                    lbl_txtBxError.Text = Utility.GetTranslation("EDITP_ERROR_ONLYALPHABETICCHARS");
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
            String filePath = "";
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
            this.selectedApp.customName = this.txtBx_eName.Text;
            this.selectedApp.path = this.lbl_path.Text;
            this.selectedApp.autoRestart = this.chkBx_autoRestart.Checked;
            this.selectedApp.executeAsAdmin = this.chkBx_execAsAdmin.Checked;

            this.Close();
        }
    }
}
