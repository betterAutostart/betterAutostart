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
    public partial class application : Form
    {

        public application()
        {
            Config.applyConfig();
            Config.applicationForm = this;
            InitializeComponent();

            this.updateTranslation();
        }

        public void updateTranslation() 
        {
            btn_createNewProfile.Text = Config.langSupport.getTranslation("CREATE_NEW_PROFILE").ToString();
            btn_editProfiles.Text = Config.langSupport.getTranslation("EDIT_PROFILE").ToString();
            btn_settings.Text = Config.langSupport.getTranslation("SETTINGS").ToString();
        }

        private void btn_createNewProfile_Click(object sender, EventArgs e)
        {
        }

        private void btn_editProfiles_Click(object sender, EventArgs e)
        {
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

            var settingsForm = new settings();
            settingsForm.Show();
        }
    }
}
