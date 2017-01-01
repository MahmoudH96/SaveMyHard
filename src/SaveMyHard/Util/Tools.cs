using IWshRuntimeLibrary;
using SaveMyHard.Util;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;

namespace SaveMyHard
{
    public static class Tools
    {

        #region Font Tools

        #region Fonts
        /// <summary>
        /// Font Lists:
        /// 0-OpenSans Regular
        /// 1-OpenSans Semibold
        /// </summary>
        internal static PrivateFontCollection Fonts = new PrivateFontCollection();

        #endregion


        /// <summary>
        /// Used to load Fonts into Static Fields from embedded resources
        /// http://stackoverflow.com/questions/556147/how-to-quickly-and-easily-embed-fonts-in-winforms-app-in-c-sharp
        /// </summary>
        internal static void LoadFontsFromResources()
        {

            byte[] fontData;
            IntPtr fontPtr;
            uint dummy = 0;

            #region Load OpenSans Regular

            fontData = Properties.Resources.OpenSans_Regular;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            Fonts.AddMemoryFont(fontPtr, Properties.Resources.OpenSans_Regular.Length);
            NativeMethods.AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.OpenSans_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            
            #endregion

            #region Load OpenSans Semibold

            fontData = Properties.Resources.OpenSans_Semibold;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            Fonts.AddMemoryFont(fontPtr, Properties.Resources.OpenSans_Semibold.Length);
            NativeMethods.AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.OpenSans_Semibold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            
            #endregion
        }
        #endregion

        #region Driver Tools
        public static DriveInfo GetDriverInfoFromTitle(String windowTitle)
        {
            var driverLetterIndex = windowTitle[windowTitle.IndexOf("(") + 1] + ":\\";
            var driverInfo = DriveInfo.GetDrives().Where(c => c.Name == driverLetterIndex.ToString()).FirstOrDefault();
            return driverInfo;
        }
        public static DriveInfo GetDriverInfo(string driverLetter)
        {
            var driverInfo = DriveInfo.GetDrives().Where(c => c.Name == driverLetter.ToString()).FirstOrDefault();
            return driverInfo;
        }
        public static double ConvertFromBytesToGegaBytes(double bytes)
        {
            return bytes / (1024.0 * 1024 * 1024);
        }
        #endregion

        #region String processing Tools
        /// <summary>
        /// Used to make sure that the title of the window is the format window
        /// </summary>
        public static bool ValidateWindowTitle(string windowtitle, out string DriverLetter)
        {
            DriverLetter = null;
            if (windowtitle.Contains("Format"))
            {
                var openBracketIndex = windowtitle.IndexOf("(");
                if (openBracketIndex == -1)
                {
                    return false;
                }//check for close bracket
                if (windowtitle[openBracketIndex + 3] != ')')
                {
                    return false;
                }
                //valid case
                DriverLetter = windowtitle[openBracketIndex + 1] + ":\\";
                return true;

            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Shortcut Tools

        public const string ShortcutFileName = "SaveMyHard.lnk";
        public const string ShortcutFileDescription = "Save my hard";




        /// <summary>
        /// Used to add the program into startup list
        /// </summary>
        public static void AddToStartup()
        {
            var startupDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";

            WshShell wsh = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(
                startupDir + "\\" + ShortcutFileName) as IWshRuntimeLibrary.IWshShortcut;
            shortcut.TargetPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            shortcut.WindowStyle = 1;
            shortcut.Description = ShortcutFileDescription;
            shortcut.WorkingDirectory = System.IO.Path.GetDirectoryName(shortcut.TargetPath);
            shortcut.Save();
        }

        /// <summary>
        /// Used to remove the program from startup list
        /// </summary>
        public static void RemoveFromStartup()
        {
            var startupDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";
            var fileName = startupDir + "\\" + ShortcutFileName;
            System.IO.File.Delete(fileName);
        }

        /// <summary>
        /// Used to check if the program will be lunched at windows startup
        /// </summary>
        /// <returns></returns>
        public static bool CheckStartup()
        {
            var startupDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";
            var startupFilesList = System.IO.Directory.GetFiles(startupDir).Where(c => Path.GetExtension(c).Equals(".lnk"));
            //Check for the default startup icon
            if (startupFilesList.Where(c => Path.GetFileName(c) == ShortcutFileName).Any())
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
