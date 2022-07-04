using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;


namespace betterAutostart.Application.Common.ProfileClasses
{
    [JsonObject]
    public class ExecutableApp
    {
        /// <summary>
        /// Path leading to the executable
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// CustomName of the executable (instead of someName.exe)
        /// </summary>
        public string CustomName { get; set; }
        
        /// <summary>
        /// Boolean whether the executable should be executed as an admin
        /// </summary>
        public bool ExecuteAsAdmin { get; set; }
        
        /// <summary>
        /// Boolean whether the executable should be automatically restarted after closing/crashing
        /// </summary>
        public bool AutoRestart { get; set; }

        private Process process;
        private bool isRunning = false;
        private Timer intervalT;
        private bool killed = false;
        private int restarts = 0;

        /// <summary>
        /// Instantiate a new ExecutableApp
        /// </summary>
        /// <param name="path">Path leading to the executable</param>
        /// <param name="customName">CustomName of the Executable</param>
        /// <param name="executeAsAdmin">Whether the Executable should be executed as an admin</param>
        public ExecutableApp(string path, string customName, bool executeAsAdmin)
        {
            this.Path = path;
            this.CustomName = customName;
            this.ExecuteAsAdmin = executeAsAdmin;

            intervalT = new Timer();
            this.intervalT.Elapsed += new ElapsedEventHandler(ElapsedTimerEvent);
            this.intervalT.Interval = 2000; // 2sec
            this.intervalT.Start();
        }

        /// <summary>
        /// Event which gets triggered everytime the interval reaches 0
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="e">ElapsedEventArgs</param>
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

        /// <summary>
        /// Execute the ExecutableApp
        /// </summary>
        public void Execute()
        {
            if (!this.isRunning || this.process == null)
            {
                this.process = Process.Start(this.Path);
                killed = false;
            }
        }

        /// <summary>
        /// Kills the ExecutableApp, if it's currently running
        /// </summary>
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

        /// <summary>
        /// Get the CustomName of the executable, if there is none the original name will be displayed (someName.exe)
        /// </summary>
        /// <returns>The CustomName or sth original</returns>
        public string GetExecutableCustomName()
        {
            if (this.CustomName == "")
            {
                string[] splitPath = this.Path.Split(new string[] { "\\" }, StringSplitOptions.None);
                return splitPath[splitPath.Length - 1];
            }
            return this.CustomName;
        }
        
        /// <summary>
        /// Check if the ExecutableApp is running
        /// </summary>
        /// <returns>Whether the ExecutableApp is currently running</returns>
        public bool IsRunning()
        {
            return this.isRunning;
        }
    }
}
