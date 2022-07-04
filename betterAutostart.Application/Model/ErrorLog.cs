using System;
using System.Linq;
using System.IO;

namespace betterAutostart.Application.Model
{
    public class ErrorLog
    {
        private string errorDirectory = @"./log/";
        private string[] errorLogs;
        private string activeLogFilePath;

        private string fileNamePrefix = "clientLog_";
        private string fileEndingPrefix = ".log";

        private int maxLogFileCount = 9;

        /// <summary>
        /// Instantiate a new ErrorLog
        /// </summary>
        public ErrorLog()
        {
            if (Utility.DesignMode)
            {
                errorDirectory = @"./../../log/";
            }
            
            this.CheckDirectory();
            this.errorLogs = Directory.GetFiles(this.errorDirectory, this.fileNamePrefix + "*" + this.fileEndingPrefix);
            this.CreateNewLogFile();
        }

        /// <summary>
        /// Checking if the error directory exists, if not a new directory will be created.
        /// Also, if the maximum number of log files is exceeded, the oldest ones are removed.
        /// </summary>
        private void CheckDirectory()
        {
            if (!Directory.Exists(this.errorDirectory))
            {
                Directory.CreateDirectory(this.errorDirectory);
            }
            
            DirectoryInfo info = new DirectoryInfo(this.errorDirectory);
            FileInfo[] files = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();

            if (files.Length >= maxLogFileCount)
            {
                for (int i = maxLogFileCount; i < files.Length; i++)
                {
                    files[i].Delete();
                }
            }
        }

        /// <summary>
        /// Creates a new logfile in the error directory
        /// </summary>
        private void CreateNewLogFile()
        {
            string filePath = this.errorDirectory + this.GenerateLogFileName();
            File.CreateText(filePath).Close();

            this.activeLogFilePath = filePath;
        }

        /// <summary>
        /// Generates a name for a log file based of the current date and prefixes
        /// </summary>
        /// <returns>The generated name</returns>
        private string GenerateLogFileName()
        {
            string fileName = this.fileNamePrefix;
            fileName += DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss");
            fileName += this.fileEndingPrefix;

            return fileName;
        }

        /// <summary>
        /// Generates the timestamp for a log entry
        /// </summary>
        /// <returns>The formatted timestamp</returns>
        private string GetLogTimestamp()
        {
            return DateTime.Now.ToString("[HH:mm:ss] ");
        }

        /// <summary>
        /// Writes the given string to the current log file
        /// </summary>
        /// <param name="err">A string containing the error message</param>
        public void LogError(string err)
        {
            using (StreamWriter st = new StreamWriter(this.activeLogFilePath))
            {
                st.WriteLine(GetLogTimestamp() + err);
                st.Close();
            }
        }
        
        /// <summary>
        /// Writes the given exception to the current log file
        /// </summary>
        /// <param name="e">Thrown exception</param>
        public void LogError(Exception e)
        {
            this.LogError(e.Message);
        }
    }
}