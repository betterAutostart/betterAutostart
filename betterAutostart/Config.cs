using System;
using System.IO;
using System.Diagnostics;

namespace betterAutostart
{
    class Config
    {
        public static LanguageObj ActiveLanguage;
        public static LanguageSupport LangSupport;
        public static application ApplicationForm;
        public static ProfileHandler PHandler;
        public static SaveSystem SaveSystem;

        /*
         * Used packages:
         * Newtonsoft.Json (https://www.newtonsoft.com/json)
         * NHotkey.WindowsForms (https://github.com/thomaslevesque/NHotkey)
         * Microsoft Visual Studio Installer Projects (https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects)
         */

        public static void ApplyConfig() 
        {
            LangSupport = new LanguageSupport();
            LangSupport.loadAllLanguages();
            ActiveLanguage = LangSupport.getLanguageByName(Properties.Settings.Default["SelectedLanguage"].ToString());
            PHandler = new ProfileHandler();

            SaveSystem = new SaveSystem();
        }
    }
}
