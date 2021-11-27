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

namespace betterAutostart
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            drpD_languages.Items.AddRange(Config.LangSupport.GetPossibleLanguagesNames().Cast<object>().ToArray());
            drpD_languages.SelectedItem = Config.ActiveLanguage.name;

            this.UpdateTranslation();
        }

        private void UpdateTranslation()
        {
            lbl_settings_languages.Text = Utility.GetTranslation("SETTINGS_LANGUAGE").ToString();
            this.lbl_links.Text = Utility.GetTranslation("SETTINGS_LINKS").ToString();
            this.lbl_websiteHeader.Text = Utility.GetTranslation("SETTINGS_WEBSITE").ToString();
            this.lbl_wikiHeader.Text = Utility.GetTranslation("SETTINGS_WIKI").ToString();
            this.lbl_srccHeader.Text = Utility.GetTranslation("SETTINGS_SOURCECODE").ToString();
            this.lbl_docHeader.Text = Utility.GetTranslation("SETTINGS_DOCUMENTATION").ToString();
            this.lbl_credits.Text = Utility.GetTranslation("SETTINGS_CREDITS").ToString();

            this.btn_websiteOpen.Text = Utility.GetTranslation("SETTINGS_VISITWEBSITE").ToString();
            this.btn_wikiOpen.Text = Utility.GetTranslation("SETTINGS_VISITWEBSITE").ToString();
            this.btn_srccOpen.Text = Utility.GetTranslation("SETTINGS_VISITWEBSITE").ToString();
            this.btn_docOpen.Text = Utility.GetTranslation("SETTINGS_VISITWEBSITE").ToString();

            this.btn_settingsBuyMeACoffe.Text = Utility.GetTranslation("SETTINGS_BUYMEACOFEE").ToString();
            this.btn_settings_apply.Text = Utility.GetTranslation("SETTINGS_SAVE").ToString();

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
            Config.ActiveLanguage = Config.LangSupport.GetLanguageByName(Properties.Settings.Default["SelectedLanguage"].ToString());
            Config.ApplicationForm.UpdateTranslation();
            this.UpdateTranslation();

            Properties.Settings.Default.Save();
        }

        private void btn_websiteOpen_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://betterautostart.com");
        }

        private void btn_wikiOpen_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://betterautostart.com/wiki");
        }

        private void btn_srccOpen_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://betterautostart.com/sourcecode");
        }

        private void btn_docOpen_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://betterautostart.com/documentation");
        }

        private void btn_settingsBuyMeACoffe_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://www.buymeacoffee.com/erijl");
        }
    }
}
