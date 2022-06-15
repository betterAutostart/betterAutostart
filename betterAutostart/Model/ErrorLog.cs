using System;
using System.Linq;
using System.IO;

namespace betterAutostart.Model
{
    public class ErrorLog
    {
        private string errorDirectory = @"./log/";
        private string[] errorLogs;
        private string activeLogFilePath;

        private string fileNamePrefix = "clientLog_";
        private string fileEndingPrefix = ".log";

        private int maxLogFileCount = 9;

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

        private void CreateNewLogFile()
        {
            string filePath = this.errorDirectory + this.GenerateLogFileName();
            File.CreateText(filePath).Close();

            this.activeLogFilePath = filePath;
        }

        private string GenerateLogFileName()
        {
            string fileName = this.fileNamePrefix;
            fileName += DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss");
            fileName += this.fileEndingPrefix;

            return fileName;
        }

        private string GetLogTimestamp()
        {
            return DateTime.Now.ToString("[HH:mm:ss] ");
        }

        public void LogError(string err)
        {
            using (StreamWriter st = new StreamWriter(this.activeLogFilePath))
            {
                st.WriteLine(GetLogTimestamp() + err);
                st.Close();
            }
        }
        public void LogError(Exception e)
        {
            this.LogError(e.Message);
        }
    }
}