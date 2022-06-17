using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using betterAutostart.Application.Common;
using betterAutostart.Application.Common.Translation;

namespace betterAutostart.Application
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            drpD_languages.Items.AddRange(LanguageSupport.GetPossibleLanguagesNames().Cast<object>().ToArray());
            drpD_languages.SelectedItem = Config.ActiveLanguage.Name;

            this.UpdateTranslation();
        }

        private void UpdateTranslation()
        {
            lbl_settings_languages.Text = Config.ActiveLanguage.Strings.SettingsLanguage;

            this.btn_settingsBuyMeACoffe.Text = Config.ActiveLanguage.Strings.SettingsBuyMeACoffee;
            this.btn_settings_apply.Text = Config.ActiveLanguage.Strings.SettingsSave;
        }

        private void btn_settings_applySettingsClick(object sender, EventArgs e)
        {
            this.SaveSettings();
        }
        private void btn_settings_applySettingsClickAndClose(object sender, EventArgs e)
        {
            this.SaveSettings();
            this.Close();
        }

        private void SaveSettings() 
        {
            if (drpD_languages.SelectedItem == null) return;
            Properties.Settings.Default["SelectedLanguage"] = drpD_languages.SelectedItem.ToString();
            Config.ActiveLanguage = LanguageSupport.GetLanguageByName(Properties.Settings.Default.SelectedLanguage);
            Config.ApplicationForm.UpdateTranslation();
            this.UpdateTranslation();

            Properties.Settings.Default.Save();
        }

        private void btn_settingsBuyMeACoffee_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://www.buymeacoffee.com/erijl");
        }

        private void lbl_creditsDevE_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://erijl.de");
        }

        private void lbl_creditsDesignE_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://erijl.de");
        }

        private void lbl_creditsLogoF_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://www.freepik.com");
        }

        private void lbl_creditsSptB_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://open.spotify.com/artist/7AviffPlMm0d1bhzuQ4KF3?si=Yh1v4mEFQTSHwswkNWbeUQ&nd=1");
        }
    }
}
