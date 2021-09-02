using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;


namespace betterAutostart
{
    [JsonObject]
    class ExecutableApp
    {
        public String path = "";
        public String customName = "";
        public bool executeAsAdmin = false;
        private Process process;

        public ExecutableApp(String path, String customName, bool executeAsAdmin)
        {
            this.path = path;
            this.customName = customName;
            this.executeAsAdmin = executeAsAdmin;
        }

        public void Execute()
        {
            Console.WriteLine("EXECUTING: " + this.path);
                this.process = Process.Start(this.path);
        }

        public void Kill()
        {
            if (this.process != null)
            {
                Process activeProcess = Process.GetProcessById(this.process.Id);
                if(activeProcess != null)
                {
                    this.process.Kill();
                    this.process = null;
                }
            }
        }
    }
}
