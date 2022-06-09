using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;


namespace betterAutostart.Common.ProfileClasses
{
    [JsonObject]
    public class ExecutableApp
    {
        public String Path { get; set; }
        public String CustomName { get; set; }
        public bool ExecuteAsAdmin { get; set; }
        public bool AutoRestart { get; set; }

        private Process process;
        private bool isRunning = false;
        private Timer intervalT;
        private bool killed = false;
        private int restarts = 0;

        public ExecutableApp(String path, String customName, bool executeAsAdmin)
        {
            this.Path = path;
            this.CustomName = customName;
            this.ExecuteAsAdmin = executeAsAdmin;

            intervalT = new Timer();
            this.intervalT.Elapsed += new ElapsedEventHandler(ElapsedTimerEvent);
            this.intervalT.Interval = 2000; // 2sec
            this.intervalT.Start();
        }

        public void ElapsedTimerEvent(object source, ElapsedEventArgs e)
        {
            this.isRunning = Utility.IsProgrammRunning(this.Path);

            if(!this.isRunning && this.AutoRestart && !this.killed)
            {
                this.Execute();
                this.restarts += 2;
            }

            this.restarts--;
            if (this.restarts <= 0) this.restarts = 0;
            if(this.restarts >= 2)
            {
                this.intervalT.Stop();
            }
        }

        public void Execute()
        {
            if (!this.isRunning || this.process == null)
            {
                this.process = Process.Start(this.Path);
                killed = false;
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
                        this.killed = true;
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
            if (this.CustomName == "")
            {
                String[] splitPath = this.Path.Split(new string[] { "\\" }, StringSplitOptions.None);
                return splitPath[splitPath.Length - 1];
            }
            return this.CustomName;
        }
        
        public bool IsRunning()
        {
            return this.isRunning;
        }
    }
}
