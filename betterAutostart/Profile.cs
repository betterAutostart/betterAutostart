using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betterAutostart
{
    class Profile
    {
        private bool active = false;
        private bool shouldAutosart = false;
        private List<ExecutableApp> executableApps;

        public Profile()
        {
            executableApps = new List<ExecutableApp>();
        }

        public void addNewExecutableApp(String path, String customName = "", bool startAsAdmin = false)
        {
            executableApps.Add(new ExecutableApp(path, customName, startAsAdmin));
        }
    }
}
