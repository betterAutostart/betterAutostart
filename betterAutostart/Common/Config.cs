using System;
using System.IO;
using System.Diagnostics;
using betterAutostart.Common.ProfileClasses;
using betterAutostart.Common.Translation;
using betterAutostart.Model;

namespace betterAutostart.Common
{
    class Config
    {
        /// <summary>
        /// The global currently selected language 
        /// </summary>
        public static LanguageObj ActiveLanguage;
        public static application ApplicationForm;
        public static ProfileHandler PHandler;
        public static SaveSystem SaveSystem;
        public static ErrorLog ErrorLog;

        /*
         * Used packages:
         * Newtonsoft.Json (https://www.newtonsoft.com/json)
         * NHotkey.WindowsForms (https://github.com/thomaslevesque/NHotkey)
         * Microsoft Visual Studio Installer Projects (https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects)
         */

        /// <summary>
        /// 
        /// </summary>
        public static void InstantiateConfig()
        {
            LanguageSupport.LoadAllLanguages();
            ActiveLanguage = LanguageSupport.GetLanguageByName(Properties.Settings.Default["SelectedLanguage"].ToString());
            PHandler = new ProfileHandler();
            ErrorLog = new ErrorLog();
            SaveSystem = new SaveSystem();
        }
    }
}
