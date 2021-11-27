using System;
using System.Linq;
using System.IO;

namespace betterAutostart
{
    public class ErrorLog
    {
        private String errorDirectory = @"./log/";
        private String[] errorLogs;
        private String activeLogFilePath;

        private String fileNamePrefix = "clientLog_";
        private String fileEndingPrefix = ".log";

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

            if (files.Length >= 9)
            {
                for (int i = 9; i < files.Length; i++)
                {
                    files[i].Delete();
                }
            }
        }

        private void CreateNewLogFile()
        {
            String filePath = this.errorDirectory + this.GenerateLogFileName();
            File.CreateText(filePath).Close();

            this.activeLogFilePath = filePath;
        }

        private String GenerateLogFileName()
        {
            String fileName = this.fileNamePrefix;
            fileName += DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss");
            fileName += this.fileEndingPrefix;

            return fileName;
        }

        private String GetLogTimestamp()
        {
            return DateTime.Now.ToString("[HH:mm:ss] ");
        }

        public void LogError(String err)
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