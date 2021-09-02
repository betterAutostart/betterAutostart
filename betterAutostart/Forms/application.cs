using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace betterAutostart
{
    public partial class application : Form
    {
        public application()
        {
            Config.applyConfig();
            Config.applicationForm = this;
            InitializeComponent();

            this.updateTranslation();
            lstBx_demoProfile.Items.AddRange(Config.pHandler.GetProfiles()[0].GetDemoList().ToArray());
        }

        public void updateTranslation() 
        {
            btn_createNewProfile.Text = Config.langSupport.getTranslation("CREATE_NEW_PROFILE").ToString();
            btn_editProfiles.Text = Config.langSupport.getTranslation("EDIT_PROFILE").ToString();
            btn_settings.Text = Config.langSupport.getTranslation("SETTINGS").ToString();
        }

        private void btn_createNewProfile_Click(object sender, EventArgs e)
        {
            Config.pHandler.addNewProfile();
        }

        private void btn_editProfiles_Click(object sender, EventArgs e)
        {
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

            var settingsForm = new settings();
            settingsForm.Show();
        }

        private void btn_startProfile_Click(object sender, EventArgs e)
        {
            Profile accessedProfile = Config.pHandler.GetProfiles()[0];
            accessedProfile.ExecuteApp(0);
        }

        private void btn_stopProfile_Click(object sender, EventArgs e)
        {
            Profile accessedProfile = Config.pHandler.GetProfiles()[0];
            accessedProfile.stopProfile();
        }

        private void btn_addNewPath_Click(object sender, EventArgs e)
        {
            Profile accessedProfile = Config.pHandler.GetProfiles()[0];

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
                accessedProfile.addNewExecutableApp(filePath);
                lstBx_demoProfile.Items.AddRange(accessedProfile.GetDemoList().ToArray());
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Config.SaveSystem.SaveAllProfiles();
        }

        private void lstBx_demoProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
