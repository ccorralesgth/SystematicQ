using System;
using System.Diagnostics;
using Microsoft.Win32;
using SystematicQ.Utils.Const;

namespace SystematicQ.Utils
{
    public static class ChromeUtil
    {
        /// <summary>
        /// property to hold chrome exe location
        /// </summary>
        public static string ChromeAppExecutableLocation { get; set; }//= @"\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";

        /// <summary>
        /// get chrome windows location 
        /// TODO find same for linux 
        /// </summary>
        public static string ChromeWindowsAppFileName =>
            (string)(Registry.GetValue("HKEY_LOCAL_MACHINE" + ChromeAppExecutableLocation, "", null) ??
                     Registry.GetValue("HKEY_CURRENT_USER" + ChromeAppExecutableLocation, "", null));

        /// <summary>
        /// init chrome with specific url
        /// </summary>
        /// <param name="url"></param>
        public static void ChromeStart(string url, OS os)
        {
            switch (os)
            {   
                case OS.Windows:
                    try
                    {
                        Process.Start(ChromeWindowsAppFileName, url);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }                    

                    break;
                case OS.Linux:
                    break;
                case OS.Mac:
                    break;
                default:
                    break;
            }
            
        }
    }
}
