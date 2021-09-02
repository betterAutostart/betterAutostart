using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace betterAutostart
{
    class Profile
    {
        public String Name = ""; // Individual Name important for saveSystem
        public bool Active = false;
        public bool ShouldAutostart = false;
        public List<ExecutableApp> executableApps;

        public Profile()
        {
            executableApps = new List<ExecutableApp>();
        }

        public void addNewExecutableApp(String path, String customName = "", bool startAsAdmin = false)
        {
            Console.WriteLine(path);
            executableApps.Add(new ExecutableApp(path, customName, startAsAdmin));

            Console.WriteLine("Added new Executable App: " +  this.executableApps[this.executableApps.Count()-1].path);
        }

        public void ExecuteApp(int index)
        {
            executableApps[index].Execute();
        }

        public void stopProfile()
        {
            for (int i = 0; i < executableApps.Count(); i++)
            {
                executableApps[i].Kill();
            }
        }

        public List<String> GetDemoList()
        {
            List<String> demoList = new List<String>();

            for(int i = 0; i < this.executableApps.Count(); i++)
            {
                demoList.Add(this.executableApps[i].path);
            }
            return demoList;
        }
    }
}
