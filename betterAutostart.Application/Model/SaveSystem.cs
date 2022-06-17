using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using betterAutostart.Application.Common;
using betterAutostart.Application.Common.ProfileClasses;

namespace betterAutostart.Application.Model
{
    class SaveSystem
    {
        private string[] allSaveFiles;
        private string filePrefix = @"profileSaveFile_";
        private string fileEndingPrefix = @".json";
        private string saveDirectory = @"./saveFiles/";

        /// <summary>
        /// Create a new instant of the SaveSystem
        /// </summary>
        public SaveSystem()
        {
            if (Utility.DesignMode)
            {
                this.saveDirectory = @"./../../saveFiles/";
            }
            
            this.CheckSaveFilePath();
            this.allSaveFiles = Directory.GetFiles(this.saveDirectory, 
                this.filePrefix + 
                "*" + 
                this.fileEndingPrefix);
            
            this.LoadAllProfiles();
        }

        /// <summary>
        /// Reads in all the Profiles and adds them into the ProfileHandler
        /// </summary>
        public void LoadAllProfiles()
        {
            for(int i = 0; i < allSaveFiles.Count(); i++)
            {
                string json = File.ReadAllText(allSaveFiles[i]);
                Profile tempProfile = JsonConvert.DeserializeObject<Profile>(json);
                Config.PHandler.AddExistingProfile(tempProfile);
            }
        }

        /// <summary>
        /// Save all Autostart Profiles to .Json files
        /// </summary>
        public void SaveAllProfiles()
        {
            List<Profile> allProfiles = Config.PHandler.GetProfiles();

            for(int i = 0; i < allProfiles.Count(); i++)
            {
                string filePath = this.saveDirectory + this.filePrefix + allProfiles[i].Name + this.fileEndingPrefix;

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.CreateText(filePath).Close();


                var model = new Profile();
                model.Name = allProfiles[i].Name;
                model.Active = allProfiles[i].Active;
                model.ShouldAutostart = allProfiles[i].ShouldAutostart;
                model.ExecutableApps = new List<ExecutableApp>
                {
                    allProfiles[i].ExecutableApps[0]
                };

                string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
        }

        /// <summary>
        /// Save a specific Autostart Profile
        /// </summary>
        /// <param name="profile">Autostart Profile which to save</param>
        /// <param name="oldProfileName">The old Profile name, if the name got changed</param>
        public void SaveProfile(Profile profile, string oldProfileName)
        {
            string filePath = this.saveDirectory + this.filePrefix + profile.Name + this.fileEndingPrefix;
            string oldFilePath = this.saveDirectory + this.filePrefix + oldProfileName + this.fileEndingPrefix;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            if (File.Exists(oldFilePath))
            {
                File.Delete(oldFilePath);
            }

            File.CreateText(filePath).Close();

            string json = JsonConvert.SerializeObject(profile, Formatting.Indented);
            File.WriteAllText(filePath, json);       
        }

        /// <summary>
        /// Deletes a specific Autostart Profile
        /// </summary>
        /// <param name="profile">Autostart Profile which to save</param>
        /// <param name="oldProfileName">The old Profile name, if the name got changed</param>
        public void DeleteProfile(Profile profile, string oldProfileName)
        {
            string filePath = this.saveDirectory + this.filePrefix + profile.Name + this.fileEndingPrefix;
            string oldFilePath = this.saveDirectory + this.filePrefix + oldProfileName + this.fileEndingPrefix;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            if (File.Exists(oldFilePath))
            {
                File.Delete(oldFilePath);
            }
        }

        /// <summary>
        /// Checks if the directory for the save files exists and creates a new one if needed
        /// </summary>
        private void CheckSaveFilePath()
        {
            if(!Directory.Exists(this.saveDirectory))
            {
                Directory.CreateDirectory(this.saveDirectory);
            }
        }
    }
}
