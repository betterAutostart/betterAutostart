using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betterAutostart
{
    class Config
    {
        public static Root activeLanguage;
        public static languageSupport langSupport;
        public static application applicationForm;
        public static settings settingsForm;
        public static ProfileHandler pHandler;
        public static SaveSystem SaveSystem;

        /*
         * Used packages:
         * Newtonsoft.Json (https://www.newtonsoft.com/json)
         * 
         * 
         * Used to Convert JSON to Root.cs class:
         * https://json2csharp.com/json-to-csharp
         *  !!IMPORTANT!! in settings (left hand corner) you need to check "Use Fields"
         */

        public static void applyConfig() 
        {
            Config.langSupport = new languageSupport();
            Config.langSupport.loadAllLanguages();
            Config.activeLanguage = Config.langSupport.getLanguageByName(Properties.Settings.Default["SelectedLanguage"].ToString());
            Config.pHandler = new ProfileHandler();

            Config.SaveSystem = new SaveSystem();
        }

    }
}
