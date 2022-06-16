using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using Newtonsoft.Json;


namespace betterAutostart.Common.Translation
{
    class LanguageSupport
    {
        private static string[] allLanguageJsonFiles;
        private static List<LanguageObj> languages = new List<LanguageObj>();
        private static List<LanguageObj> possibleLanguages = new List<LanguageObj>();
        private static List<string> possibleLanguageNames = new List<string>();


        /// <summary>
        /// Reads and loads all language Files
        /// </summary>
        public static void LoadAllLanguages()
        {
            if (Utility.DesignMode)
            {
                allLanguageJsonFiles = Directory.GetFiles("./../../languagePackages");
            }
            else
            {
                allLanguageJsonFiles = Directory.GetFiles("./languagePackages");
            }
            
            for (int i = 0; i < allLanguageJsonFiles.Length; i++)
            {
                LanguageObj tempLang = JsonConvert.DeserializeObject<LanguageObj>(File.ReadAllText(allLanguageJsonFiles[i]));

                languages.Add(tempLang);
                if (tempLang.Active == 1) 
                {
                    possibleLanguages.Add(tempLang);
                    possibleLanguageNames.Add(tempLang.Name);
                }
            }

        }

        /// <summary>
        /// Get a specific language by name
        /// </summary>
        /// <param name="name">Name of the language</param>
        /// <returns>LanguageObj containing the found language, if none where found it returns null</returns>
        public static LanguageObj GetLanguageByName(string name) 
        {
            return possibleLanguages.Find(lang => lang.Name == name);
        }

        /// <summary>
        /// Get all names of loaded languages
        /// </summary>
        /// <returns>Names of loaded language</returns>
        public static List<string> GetPossibleLanguagesNames() 
        {
            return possibleLanguageNames;
        }
    }
}
