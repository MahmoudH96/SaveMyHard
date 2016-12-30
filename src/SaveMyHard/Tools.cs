using IWshRuntimeLibrary;
using Shell32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMyHard
{
    public static class Tools
    {

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
        /// Used to get the target path for a shortcut file
        /// </summary>
        /// <param name="shortcutFilename"></param>
        /// <returns></returns>
        public static string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = System.IO.Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = System.IO.Path.GetFileName(shortcutFilename);

            Shell shell = new Shell();
            Shell32.Folder folder = shell.NameSpace(pathOnly);
            FolderItem folderItem = folder.ParseName(filenameOnly);
            if (folderItem != null)
            {
                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return string.Empty;
        }

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

            //Check other shortcuts targets
            bool isExist = false;
            foreach (var file in startupFilesList)
            {
                if (GetShortcutTargetFile(file) == System.Reflection.Assembly.GetExecutingAssembly().Location)
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }
        #endregion
    }
}
