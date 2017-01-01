using SaveMyHard.Util;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SaveMyHard
{
    delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

    /// <summary>
    /// Determine the protection type
    /// All: Disable all format processes 
    /// Size: Disable format processes for hard disks with size greater that value determined by the user
    /// </summary>
    public enum DisableStatus { All, Size }
    public class TaskTrayApplicationContext : ApplicationContext
    {
        #region Fields

        private NotifyIcon trayIcon;
        public NotifyIcon TrayIcon
        {
            get { return trayIcon; }
            set { trayIcon = value; }
        }

        private WinEventDelegate dele = null;

        #region Static Fields

        /// <summary>
        /// Used to invoke notification from another windows inside the application
        /// </summary>
        public static Action<bool> DisplayProtectionNotification;

        #endregion

        #region Messages Codes

        /* OLD Messages
         //For more information see http://stackoverflow.com/questions/5083954/send-message-in-c-sharp
         static uint WM_CLOSE = 0x10;
         static uint WM_DESTROY = 0x2;
         static uint WM_NCDESTROY = 0x0082;
         */

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;

        #endregion

        #region Windows

        private SaveMyHard.GUIs.Configurations configWindow;
        public SaveMyHard.GUIs.Configurations ConfigWindow
        {
            get { return configWindow; }
            set { configWindow = value; }
        }

        private IntPtr previousWindowPointer;
        public IntPtr PreviousWindowPointer
        {
            get { return previousWindowPointer; }
            set { previousWindowPointer = value; }
        }

        #endregion

        #endregion

        #region Constructors
        public TaskTrayApplicationContext()
        {
            #region Add the Program into Startup (incase if it was not their)

            var isAppAtStartup = Tools.CheckStartup();
            if (!isAppAtStartup)
            {
                var addfileToStartup = MessageBox.Show("Would you like to lunch save my hard at system startup?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (addfileToStartup == DialogResult.Yes)
                {
                    Tools.AddToStartup();
                    isAppAtStartup = true;
                }
            }

            #endregion

            #region Setting up Tray Icon

            ToolStripMenuItem configMenuItem = new ToolStripMenuItem("Configuration", SaveMyHard.Properties.Resources.Settings, new EventHandler(ShowConfig));
            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("About", SaveMyHard.Properties.Resources.About, new EventHandler(ShowAbout));
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit", SaveMyHard.Properties.Resources.Exit, new EventHandler(Exit));

            #region Setting up configuration Window

            ConfigWindow = new GUIs.Configurations();
            ConfigWindow.RunAtStartup = isAppAtStartup;
            ConfigWindow.LoadInitialSettings();

            #endregion

            TrayIcon = new NotifyIcon();
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;
            TrayIcon.Text = Tools.ShortcutFileDescription;
            TrayIcon.Icon = SaveMyHard.Properties.Resources.Icon;
            TrayIcon.ContextMenuStrip = new ContextMenuStrip();
            TrayIcon.ContextMenuStrip.Items.AddRange(new ToolStripItem[] { configMenuItem, aboutMenuItem, new ToolStripSeparator(), exitMenuItem });
            TrayIcon.Visible = true;
            //Register the Static event
            DisplayProtectionNotification = new Action<bool>(DisplayNotification);

            #endregion

            DisplayNotification(Properties.Settings.Default.Protection);

            #region Register monitoring events

            dele = new WinEventDelegate(WinEventProc);
            IntPtr m_hhook = NativeMethods.SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, dele, 0, 0, WINEVENT_OUTOFCONTEXT);

            #endregion
        }

        #endregion

        #region Methods

        #region Native Methods From user32.dll and support methods

        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        #endregion

        /// <summary>
        /// Used to get the title of the active window inside windows
        /// </summary>
        /// <returns>The title of the active window</returns>
        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            IntPtr handle = IntPtr.Zero;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = NativeMethods.GetForegroundWindow();

            if (NativeMethods.GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        /// <summary>
        /// The handle of window change event inside windows
        /// </summary>
        /// <param name="hWinEventHook"></param>
        /// <param name="eventType"></param>
        /// <param name="hwnd"></param>
        /// <param name="idObject"></param>
        /// <param name="idChild"></param>
        /// <param name="dwEventThread"></param>
        /// <param name="dwmsEventTime"></param>
        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (!Properties.Settings.Default.Protection)
                return;

            var windowTitle = GetActiveWindowTitle();
            //safety condition (in some cases the title is null)
            if (windowTitle == null)
                return;

            string driverLetter = null;
            var validateResult = Tools.ValidateWindowTitle(windowTitle, out driverLetter);

            if (validateResult)
            {
                //Get the setting of disable
                var disableStatus = Properties.Settings.Default.DisableType;
                switch (disableStatus)
                {
                    case DisableStatus.All:
                        {
                            closeWindow(hwnd);
                            break;
                        }
                    case DisableStatus.Size:
                        {
                            var driverInfo = Tools.GetDriverInfo(driverLetter);
                            var driverSizeGB = Tools.ConvertFromBytesToGegaBytes(driverInfo.TotalSize);
                            if (driverSizeGB > (double)Properties.Settings.Default.Size)
                            {
                                closeWindow(hwnd);
                            }
                            break;
                        }

                }
            }
        }




        /// <summary>
        /// Used to close a window based on its pointer by using user32.dll methods
        /// </summary>
        /// <param name="hWindow"></param>
        public void closeWindow(IntPtr hWindow)
        {
            if (hWindow == PreviousWindowPointer)
                return;
            PreviousWindowPointer = hWindow;
            //Send close message to hWindow
            NativeMethods.SendMessage((int)hWindow, WM_SYSCOMMAND, SC_CLOSE, 0);
            MessageBox.Show("Attention , You are trying to format a forbidden Driver ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Used to display startup notication for the user about the protection status
        /// </summary>
        public void DisplayNotification(bool protectionEnabled)
        {
            //Check if the user allows notification to be displayed
            if (!Properties.Settings.Default.DisplayNotification)
            {
                return;
            }

            #region Display notification for the user
            if (protectionEnabled)
            {
                TrayIcon.ShowBalloonTip(2000, "Save my hard", "Protection is enabled", ToolTipIcon.Info);
            }
            else
            {
                TrayIcon.ShowBalloonTip(2000, "Save my hard", "Protection is disabled", ToolTipIcon.Warning);
            }
            #endregion
        }

        #region Tray Events

        /// <summary>
        /// Used to open configuration window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            // If we are already showing the window meerly focus it.
            if (ConfigWindow.Visible)
                ConfigWindow.Focus();
            else
                ConfigWindow.ShowDialog();
        }
        void ShowConfig(object sender, EventArgs e)
        {
            // If we are already showing the window meerly focus it.
            if (ConfigWindow.Visible)
                ConfigWindow.Focus();
            else
                ConfigWindow.ShowDialog();
        }
        void ShowAbout(object sender, EventArgs e)
        {
            var aboutWindow = new GUIs.About();
            aboutWindow.ShowDialog();
        }
        void Exit(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            TrayIcon.Visible = false;

            Application.Exit();
        }

        #endregion

        #endregion

    }
}
