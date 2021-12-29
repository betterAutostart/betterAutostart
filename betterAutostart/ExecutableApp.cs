using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;


namespace betterAutostart
{
    [JsonObject]
    public class ExecutableApp
    {
        public String path = "";
        public String customName = "";
        public bool executeAsAdmin = false;
        public bool autoRestart = false;
        private Process process;
        private bool isRunning = false;
        private Timer intervalT;

        public ExecutableApp(String path, String customName, bool executeAsAdmin)
        {
            this.path = path;
            this.customName = customName;
            this.executeAsAdmin = executeAsAdmin;

            intervalT = new Timer();
            this.intervalT.Elapsed += new ElapsedEventHandler(ElapsedTimerEvent);
            this.intervalT.Interval = 2000; // 2sec
            this.intervalT.Start();
        }

        public void ElapsedTimerEvent(object source, ElapsedEventArgs e)
        {
            this.isRunning = Utility.IsProgrammRunning(this.path);

            if(!this.isRunning && autoRestart)
            {
                this.process = Process.Start(this.path);
            }
        }

        public void Execute()
        {
            if (!this.isRunning || this.process == null)
            {
                this.process = Process.Start(this.path);
            }
        }

        public void Kill()
        {
            try
            {
                if (this.process != null)
                {
                    Process activeProcess = Process.GetProcessById(this.process.Id);
                    if (activeProcess != null)
                    {
                        this.process.Kill();
                        this.process = null;
                    }
                }
            }
            catch (Exception e)
            {
                Config.ErrorLog.LogError(e);
            }
        }

        public String GetExecutableCustomName()
        {
            if (this.customName == "")
            {
                String[] splitPath = this.path.Split(new string[] { "\\" }, StringSplitOptions.None);
                return splitPath[splitPath.Length - 1];
            }
            return this.customName;
        }

        public String GetPath()
        {
            return this.path;
        }
        
        public bool IsRunning()
        {
            return this.isRunning;
        }
    }
}
