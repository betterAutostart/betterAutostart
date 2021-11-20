using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace betterAutostart
{
    class SaveSystem
    {
        private String[] allSaveFiles;
        private String filePrefix = @"profileSaveFile_";
        private String fileEndingPrefix = @".json";
        private String saveDirectory = @"./../../saveFiles/"; // DEBUG MODE SETTING
        //private String saveDirectory = @"./saveFiles/"; // RELEASE MODE SETTING

        public SaveSystem()
        {
            this.checkSaveFilePath();
            this.allSaveFiles = Directory.GetFiles(this.saveDirectory, this.filePrefix + "*" + this.fileEndingPrefix);
            this.LoadAllProfiles();
        }

        public void LoadAllProfiles()
        {
            for(int i = 0; i < allSaveFiles.Count(); i++)
            {
                String json = File.ReadAllText(allSaveFiles[i]);
                Profile tempProfile = JsonConvert.DeserializeObject<Profile>(json);
                Config.PHandler.AddExistingProfile(tempProfile);
            }
        }

        public void SaveAllProfiles()
        {
            List<Profile> allProfiles = Config.PHandler.GetProfiles();

            for(int i = 0; i < allProfiles.Count(); i++)
            {
                String filePath = this.saveDirectory + this.filePrefix + allProfiles[i].Name + this.fileEndingPrefix;

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.CreateText(filePath).Close();


                var model = new Profile();
                model.Name = allProfiles[i].Name;
                model.Active = allProfiles[i].Active;
                model.ShouldAutostart = allProfiles[i].ShouldAutostart;
                model.executableApps = new List<ExecutableApp>
                {
                    allProfiles[i].executableApps[0]
                };

                String json = JsonConvert.SerializeObject(model, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
        }

        public void SaveProfile(Profile profile, String oldProfileName)
        {
            String filePath = this.saveDirectory + this.filePrefix + profile.Name + this.fileEndingPrefix;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            File.CreateText(filePath).Close();

            
            String json = JsonConvert.SerializeObject(profile, Formatting.Indented);
            File.WriteAllText(filePath, json);

            String oldFilePath = this.saveDirectory + this.filePrefix + oldProfileName + this.fileEndingPrefix;
            if (File.Exists(oldFilePath))
            {
                File.Delete(oldFilePath);
            }
        }

        private void checkSaveFilePath()
        {
            if(!Directory.Exists(this.saveDirectory))
            {
                Directory.CreateDirectory(this.saveDirectory);
            }
        }
    }
}
