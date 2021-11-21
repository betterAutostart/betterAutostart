using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;

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

        public static bool DesignMode;
        
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
        
        public static bool IsInDesignMode() {
                bool isInDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || Debugger.IsAttached == true;
                Console.WriteLine(LicenseManager.UsageMode == LicenseUsageMode.Designtime);
                Console.WriteLine(Debugger.IsAttached == true);

                if (!isInDesignMode) {
                    using (var process = Process.GetCurrentProcess()) {
                        
                        return process.ProcessName.ToLowerInvariant().Contains("devenv");
                    }
                }
                return isInDesignMode;
        }

        public static void CheckDebugMode()
        {
            DesignMode = IsInDesignMode();
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

    }
}
