﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using betterAutostart.Common.ProfileClasses;

namespace betterAutostart.Common.ProfileClasses
{
    public class Profile
    {
        public string Name { get; set; } // Individual Name important for saveSystem
        public bool Active { get; set; }
        public bool ShouldAutostart { get; set; }
        public bool ExecuteAsAdmin { get; set; }
        public List<ExecutableApp> ExecutableApps { get; set; }

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

        public void AddNewExecutableApp(string path, string customName = "", bool startAsAdmin = false)
        {
            this.ExecutableApps.Add(new ExecutableApp(path, customName, startAsAdmin));
        }

        public void ExecuteApp(int index)
        {
            this.ExecutableApps[index].Execute();
        }

        public void ExecuteAllApps()
        {
            for(int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                this.ExecutableApps[i].Execute();
            }
        }

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

        public List<string> GetCustomExecutablesList()
        {
            List<string> executables = new List<string>();

            for(int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                executables.Add(this.ExecutableApps[i].GetExecutableCustomName());
            }
            return executables;
        }

        public List<string> GetEditableExecutablesList()
        {
            List<string> executables = new List<string>();

            for (int i = 0; i < this.ExecutableApps.Count(); i++)
            {
                executables.Add(this.ExecutableApps[i].GetExecutableCustomName() + " (" + this.ExecutableApps[i].Path + ")");
            }
            return executables;
        }

        public ExecutableApp GetExecutableByIndex(int index)
        {
            if ((this.ExecutableApps.Count() - 1) < index) return null;
            return this.ExecutableApps[index];
        }

        public void DeleteExecutable(ExecutableApp app)
        {
            if (app == null) return;
            this.ExecutableApps = this.ExecutableApps.Where(val => val != app).ToList();
            Config.SaveSystem.SaveProfile(this, this.Name);
        }

        public void RemoveExecutableByIndex(int index)
        {
            this.ExecutableApps.Remove(this.ExecutableApps[index]);
        }
        
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