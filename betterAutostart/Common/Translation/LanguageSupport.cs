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


namespace betterAutostart
{
    class LanguageSupport
    {
        private string[] allLanguageJsonFiles;
        private List<LanguageObj> languages = new List<LanguageObj>();
        private List<LanguageObj> possibleLanguages = new List<LanguageObj>();
        private List<string> possibleLanguageNames = new List<string>();


        public void LoadAllLanguages()
        {
            if (Utility.DesignMode)
            {
                this.allLanguageJsonFiles = Directory.GetFiles("./../../languagePackages");
            }
            else
            {
                this.allLanguageJsonFiles = Directory.GetFiles("./languagePackages");
            }
            
            for (int i = 0; i < this.allLanguageJsonFiles.Length; i++)
            {
                LanguageObj tempLang = JsonConvert.DeserializeObject<LanguageObj>(File.ReadAllText(this.allLanguageJsonFiles[i]));

                languages.Add(tempLang);
                if (tempLang.Active == 1) 
                {
                    possibleLanguages.Add(tempLang);
                    possibleLanguageNames.Add(tempLang.Name);
                }
            }

        }

        public LanguageObj GetLanguageByName(string name) 
        {
            return possibleLanguages.Find(lang => lang.Name == name);
        }

        public List<string> GetPossibleLanguagesNames() 
        {
            return possibleLanguageNames;
        }
    }
}
