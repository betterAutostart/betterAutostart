using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using betterAutostart.Application.Common.ProfileClasses;

namespace betterAutostart.Application.Common.ProfileClasses
{
    public class Profile
    {
        /// <summary>
        /// Name of the Profile
        /// </summary>
        public string Name { get; set; } // Individual Name important for saveSystem
        /// <summary>
        /// boolean whether the profile is currently active/displayed
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Boolean whether the whole profile should be executed on App startup
        /// </summary>
        public bool ShouldAutostart { get; set; }
        /// <summary>
        /// Boolean whether the whole profile should be executed as an admin
        /// </summary>
        public bool ExecuteAsAdmin { get; set; }
        /// <summary>
        /// List of all ExecutableApp's contained in the profile
        /// </summary>
        public List<ExecutableApp> ExecutableApps { get; set; }

        /// <summary>
        /// Instantiate new Profile
        /// </summary>
        public Profile()
        {
            this.Name = Config.ActiveLanguage.Strings.ProfileDefaultName;
            this.Active = false;
            this.ShouldAutostart = false;
            this.ExecuteAsAdmin = false;
            this.ExecutableApps = new List<ExecutableApp>();

            if (this.ShouldAutostart)
            {
                this.ExecuteAllApps();
            }
        }

        /// <summary>
        /// Add new ExecutableApp 
        /// </summary>
        /// <param name="path">Path leading to the executable</param>
        /// <param name="customName">Custom Name of the executable (instead of someApp.exe)</param>
        /// <param name="startAsAdmin">Whether the app should execute as admin</param>
        public void AddNewExecutableApp(string path, string customName = "", bool startAsAdmin = false)
        {
            this.ExecutableApps.Add(new ExecutableApp(path, customName, startAsAdmin));
        }

        /// <summary>
        /// Executes specific executable
        /// </summary>
        /// <param name="index">Index of executable which to execute</param>
        public void ExecuteApp(int index)
        {
            this.ExecutableApps[index].Execute();
        }

        /// <summary>
        /// Executes all executables in the profile
        /// </summary>
        public void ExecuteAllApps()
        {
            for(int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                this.ExecutableApps[i].Execute();
            }
        }

        /// <summary>
        /// Kills all executables in the profile
        /// </summary>
        public void StopProfile()
        {
            for (int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                this.ExecutableApps[i].Kill();
            }
        }
        
        public List<ExecutableApp> GetExecutableList()
        {
            return this.ExecutableApps;
        }

        /// <summary>
        /// Get a List containing custom names of all executables
        /// </summary>
        /// <returns>A list with the custom names of all executables</returns>
        public List<string> GetCustomExecutablesList()
        {
            List<string> executables = new List<string>();

            for(int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                executables.Add(this.ExecutableApps[i].GetExecutableCustomName());
            }
            return executables;
        }

        /// <summary>
        /// Get a List containing name and path of all executables
        /// Format: name (C:\the\path)
        /// </summary>
        /// <returns>A list with the name and path of all executables</returns>
        public List<string> GetEditableExecutablesList()
        {
            List<string> executables = new List<string>();

            for (int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                executables.Add(this.ExecutableApps[i].GetExecutableCustomName() + " (" + this.ExecutableApps[i].Path + ")");
            }
            return executables;
        }

        /// <summary>
        /// Gets an ExecutableApp via the index
        /// </summary>
        /// <param name="index">Index of the ExecutableApp</param>
        /// <returns>The ExecutableApp at the given index, if nothing was found it returns null</returns>
        public ExecutableApp GetExecutableByIndex(int index)
        {
            if ((this.ExecutableApps.Count() - 1) < index) return null;
            return this.ExecutableApps[index];
        }

        /// <summary>
        /// Remove an executable
        /// </summary>
        /// <param name="app">ExecutableApp which to remove</param>
        public void DeleteExecutable(ExecutableApp app)
        {
            if (app == null) return;
            this.ExecutableApps = this.ExecutableApps.Where(val => val != app).ToList();
            Config.SaveSystem.SaveProfile(this, this.Name);
        }

        /// <summary>
        /// Removes an executable by index
        /// </summary>
        /// <param name="index">Index of the executable</param>
        public void RemoveExecutableByIndex(int index)
        {
            this.ExecutableApps.Remove(this.ExecutableApps[index]);
        }
        
        /// <summary>
        /// Get the number of running executables from the profile
        /// </summary>
        /// <returns>Number of running executables</returns>
        public int GetNumberOfRunningExecutables()
        {
            int running = 0;
            for (int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                if (this.ExecutableApps[i].IsRunning()) running++;
            }
            return running;
        }
        
    }
}
