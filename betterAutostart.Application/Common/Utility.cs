using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace betterAutostart.Application
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

        /// <summary>
        /// Boolean telling whether the application is running in an development environment
        /// </summary>
        public static bool DesignMode = false;
        
        /// <summary>
        /// Opens the explorer at the given path
        /// </summary>
        /// <param name="filePath">The path to the file</param>
        public static void ExploreFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            filePath = Path.GetFullPath(filePath);
            Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
        }

        /// <summary>
        /// Checks if a specific executable is running
        /// </summary>
        /// <param name="fullPath">The path to the file</param>
        /// <returns>Whether the given executable is running or not</returns>
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

        /// <summary>
        /// Opens a website within the standard browser
        /// </summary>
        /// <param name="link">The link to the website</param>
        public static void OpenWebsite(string link)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(link);
                Process.Start(sInfo).Close();
            }
            catch { }
        }

        /// <summary>
        /// Logs message to the standard output when in development mode
        /// </summary>
        /// <param name="msg">Message to log in the console</param>
        public static void DebugLog(string msg)
        {
            if (DesignMode)
            {
                Console.WriteLine("DEBUG: {0}", msg);
            }
        }

        /// <summary>
        /// Sets the appropriate icon for a form
        /// </summary>
        /// <param name="activeForm">The form which to set the icon</param>
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

        /// <summary>
        /// Adds BetterAutostart to the Windows Autostart on startup via the registry
        /// </summary>
        public static void AddAutostartRegistry()
        {
            if (Properties.Settings.Default["SelectedLanguage"].ToString() != null && Properties.Settings.Default["SelectedLanguage"].ToString().Equals("False"))
            {
                Properties.Settings.Default["SelectedLanguage"] = "True";

                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("betterAutostart.Application", System.Windows.Forms.Application.ExecutablePath.ToString());

                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Checks if given filepath is an supported executable
        /// </summary>
        /// <param name="filepath">Path to file which to check</param>
        /// <returns>If the given path leads to an execitable</returns>
        public static bool IsExecutable(string filepath)
        {
            string[] splitPath = filepath.Split(new string[] { "\\" }, StringSplitOptions.None);
            string[] splitFilePath = splitPath[splitPath.Length - 1].Split('.');
            string fileEnding = splitFilePath[splitFilePath.Length - 1].ToLower();

            return fileEnding.Equals("exe") || fileEnding.Equals("bat") || fileEnding.Equals("cmd");
        }

    }
}
