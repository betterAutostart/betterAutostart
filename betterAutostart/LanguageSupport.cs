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
    class LanguageSupport
    {
        private String[] allLanguageJSON = Directory.GetFiles("./../../languagePackages");
        private List<LanguageObj> languages = new List<LanguageObj>();
        private List<LanguageObj> possibleLanguages = new List<LanguageObj>();
        private List<String> possibleLanguageNames = new List<String>();


        public void loadAllLanguages()
        {
            Console.WriteLine("loading Languages");
            for (int i = 0; i < this.allLanguageJSON.Length; i++)
            {
                LanguageObj tempLang = JsonConvert.DeserializeObject<LanguageObj>(File.ReadAllText(this.allLanguageJSON[i]));

                languages.Add(tempLang);
                if (tempLang.active == 1) 
                {
                    possibleLanguages.Add(tempLang);
                    possibleLanguageNames.Add(tempLang.name);
                }
            }

        }

        public Object getTranslation(String property)
        {
            Console.WriteLine(property);
            try
            {
                return Config.ActiveLanguage.strings.GetType().GetField(property).GetValue(Config.ActiveLanguage.strings);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public LanguageObj getLanguageByName(String name) 
        {
            return possibleLanguages.Find(lang => lang.name == name);
        }

        public List<String> getPossibleLanguagesNames() 
        {
            return possibleLanguageNames;
        }

        public List<LanguageObj> getAllPossibleLanguages()
        {
            return possibleLanguages;
        }
    }
}
