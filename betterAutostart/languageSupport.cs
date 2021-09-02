using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using Newtonsoft.Json;


namespace betterAutostart
{
    class languageSupport
    {
        private String[] allLanguageJSON = Directory.GetFiles("./../../languagePackages");
        private List<Root> languages = new List<Root>();
        private List<Root> possibleLanguages = new List<Root>();
        private List<String> possibleLanguageNames = new List<String>();


        public void loadAllLanguages()
        {
            Console.WriteLine("loading Languages");
            for (int i = 0; i < this.allLanguageJSON.Length; i++)
            {
                Root tempLang = JsonConvert.DeserializeObject<Root>(File.ReadAllText(this.allLanguageJSON[i]));

                languages.Add(tempLang);
                if (tempLang.active == 1) 
                {
                    possibleLanguages.Add(tempLang);
                    possibleLanguageNames.Add(tempLang.name);
                }
            }

        }

        public void applyLanguageSettings() 
        {
            Config.applicationForm.updateTranslation();
            Config.settingsForm.updateTranslation();
        }

        public Object getTranslation(String property)
        {
            Console.WriteLine(property);
            try
            {
                return Config.activeLanguage.strings.GetType().GetField(property).GetValue(Config.activeLanguage.strings);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Root getLanguageByName(String name) 
        {
            return possibleLanguages.Find(lang => lang.name == name);
        }

        public List<String> getPossibleLanguagesNames() 
        {
            return possibleLanguageNames;
        }

        public List<Root> getAllPossibleLanguages()
        {
            return possibleLanguages;
        }
    }
}
