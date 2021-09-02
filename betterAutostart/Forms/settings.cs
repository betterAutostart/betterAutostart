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
    public partial class settings : Form
    {
        public settings()
        {
            Config.settingsForm = this;
            InitializeComponent();
            drpD_languages.Items.AddRange(Config.langSupport.getPossibleLanguagesNames().Cast<object>().ToArray());
            drpD_languages.SelectedItem = Config.activeLanguage.name;

            this.updateTranslation();
        }

        public void updateTranslation()
        {
            //lbl_settings_languages
            lbl_settings_languages.Text = Config.langSupport.getTranslation("LANGUAGE").ToString();
            btn_settings_applySettings.Text = Config.langSupport.getTranslation("SAVE_SETTINGS").ToString();
            btn_settings_applySettingsAndClose.Text = Config.langSupport.getTranslation("SAVE_SETTINGS_AND_CLOSE").ToString();
        }

        private void btn_settings_applySettingsClick(object sender, EventArgs e)
        {
            this.saveSettings();
        }
        private void btn_settings_applySettingsClickAndClose(object sender, EventArgs e)
        {
            this.saveSettings();
            this.Close();
        }

        private void saveSettings() 
        {
            Properties.Settings.Default["SelectedLanguage"] = drpD_languages.SelectedItem.ToString();
            Config.activeLanguage = Config.langSupport.getLanguageByName(Properties.Settings.Default["SelectedLanguage"].ToString());
            Config.langSupport.applyLanguageSettings();

            Properties.Settings.Default.Save();
        }

    }
}
