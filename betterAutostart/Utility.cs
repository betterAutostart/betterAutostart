using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace betterAutostart
{
    class Utility
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public static bool DesignMode = false;
        
        public static void ExploreFile(String filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            filePath = Path.GetFullPath(filePath);
            Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
        }

        public static bool IsProgrammRunning(string fullPath)
        {
            string filePath = Path.GetDirectoryName(fullPath);
            string fileName = Path.GetFileNameWithoutExtension(fullPath).ToLower();
            bool isRunning = false;

            Process[] pList = Process.GetProcessesByName(fileName);

            if (pList.Length >= 1)
            {
                isRunning = true;
            }

            return isRunning;
        }

        public static void OpenWebsite(String link)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(link);
                Process.Start(sInfo).Close();
            }
            catch { }
        }


        public static void DebugLog(String msg)
        {
            if (DesignMode)
            {
                Console.WriteLine("DEBUG: {0}", msg);
            }
        }

        public static void SetIcon(Form activeForm)
        {
            if (DesignMode)
            {
                activeForm.Icon = new Icon(@"../../assets/betterAutostartIcon.ico");
            }
            else
            {
                activeForm.Icon = new Icon(@"./assets/betterAutostartIcon.ico");
            }
        }

        public static String GetTranslation(String keyword)
        {
            return Config.LangSupport.getTranslation(keyword).ToString();
        }

        public static void AddAutostartRegistry()
        {
            if (Properties.Settings.Default["SelectedLanguage"].ToString() != null && Properties.Settings.Default["SelectedLanguage"].ToString().Equals("False"))
            {
                Properties.Settings.Default["SelectedLanguage"] = "True";

                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("betterAutostart", Application.ExecutablePath.ToString());

                Properties.Settings.Default.Save();
            }
        }

        // Add a method that takes in a file ending and decides if its a executable or normal file
        public static bool IsExecutable(String filepath)
        {
            String[] splitPath = filepath.Split(new string[] { "\\" }, StringSplitOptions.None);
            String[] splitFilePath = splitPath[splitPath.Length - 1].Split('.');
            String fileEnding = splitFilePath[splitFilePath.Length - 1].ToLower();

            if (fileEnding.Equals("exe") || fileEnding.Equals("bat") || fileEnding.Equals("cmd"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
