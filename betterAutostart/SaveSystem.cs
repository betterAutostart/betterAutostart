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
        private String saveDirectory = @"./../../saveFiles/";

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
                Config.pHandler.AddExistingProfile(tempProfile);
            }
        }

        public void SaveAllProfiles()
        {
            List<Profile> allProfiles = Config.pHandler.GetProfiles();

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

        private void checkSaveFilePath()
        {
            Console.WriteLine("checking saveFilePath");
            Console.WriteLine(Directory.GetCurrentDirectory());
            if(!Directory.Exists(this.saveDirectory))
            {
                Directory.CreateDirectory(this.saveDirectory);
            }
        }
    }
}
