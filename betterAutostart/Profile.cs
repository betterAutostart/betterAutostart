using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace betterAutostart
{
    public class Profile
    {
        public String Name; // Individual Name important for saveSystem
        public bool Active = false;
        public bool ShouldAutostart = false;
        public bool ExecuteAsAdmin = false;
        public List<ExecutableApp> executableApps;

        public Profile()
        {
            this.executableApps = new List<ExecutableApp>();
            this.Name = Utility.GetTranslation("PROFILE_DEFAULTNAME");
            if (this.ShouldAutostart) this.ExecuteAllApps();
        }

        public void addNewExecutableApp(String path, String customName = "", bool startAsAdmin = false)
        {
            this.executableApps.Add(new ExecutableApp(path, customName, startAsAdmin));
        }

        public void ExecuteApp(int index)
        {
            this.executableApps[index].Execute();
        }

        public void ExecuteAllApps()
        {
            for(int i = 0; i < this.executableApps.Count(); i++)
            {
                this.executableApps[i].Execute();
            }
        }

        public void stopProfile()
        {
            for (int i = 0; i < this.executableApps.Count(); i++)
            {
                this.executableApps[i].Kill();
            }
        }

        public List<String> GetCustomExecutablesList()
        {
            List<String> executables = new List<String>();

            for(int i = 0; i < this.executableApps.Count(); i++)
            {
                executables.Add(this.executableApps[i].GetExecutableCustomName());
            }
            return executables;
        }

        public List<String> GetEditableExecutablesList()
        {
            List<String> executables = new List<String>();

            for (int i = 0; i < this.executableApps.Count(); i++)
            {
                executables.Add(this.executableApps[i].GetExecutableCustomName() + " (" + this.executableApps[i].GetPath() + ")");
            }
            return executables;
        }

        public ExecutableApp GetExecutableByIndex(int index)
        {
            if ((this.executableApps.Count() - 1) < index) return null;
            return this.executableApps[index];
        }

        public void DeleteExecutable(ExecutableApp app)
        {
            if (app == null) return;
            this.executableApps = this.executableApps.Where(val => val != app).ToList();
            Config.SaveSystem.SaveProfile(this, this.Name);
        }

        public void RemoveExecutableByIndex(int index)
        {
            this.executableApps.Remove(this.executableApps[index]);
        }
    }
}
