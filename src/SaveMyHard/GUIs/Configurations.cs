using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMyHard.GUIs
{

    /// <summary>
    /// Used to setup the program settings
    /// </summary>
    public partial class Configurations : Form
    {
        #region Fields

        #region Runtime-Settings
        private bool runAtStartup;
        /// <summary>
        /// Used to determine if the program will run at system startup
        /// </summary>
        public bool RunAtStartup
        {
            get { return runAtStartup; }
            set { runAtStartup = value; }
        }

        #endregion

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Configurations()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void chk_Options_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rad_DisableAll)
            {
                SetDisableAll(rad_DisableAll.Checked);

            }
            if (sender == rad_DisableSize)
            {
                SetDisableSize(rad_DisableSize.Checked);

            }
            if (sender == chk_EnableProtection)
            {
                SetProtection(chk_EnableProtection.Checked);
            }
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Set the protection and resotre the previous settings
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetProtection(bool isEnable)
        {
            if (isEnable)
            {
                Properties.Settings.Default.Protection = isEnable;
                Protection(isEnable);
                LoadInitialSettings();
            }
            else
            {
                Properties.Settings.Default.Protection = isEnable;
                Protection(isEnable);
            }
            TaskTrayApplicationContext.DisplayProtectionNotification?.Invoke(isEnable);
        }

        /// <summary>
        /// Used to activate "Disable all format process"
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetDisableAll(bool isEnable)
        {
            if (isEnable == true)
            {
                //Set resource file
                Properties.Settings.Default.DisableType = DisableStatus.All;
                //Set the GUI
                num_Size.Enabled = false;
            }
        }

        /// <summary>
        /// Used to active "Disable format process for certain size"
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetDisableSize(bool isEnable)
        {
            if (isEnable == true)
            {
                //Set resource file
                Properties.Settings.Default.DisableType = DisableStatus.Size;

                //Set the GUI
                num_Size.Enabled = true;
            }
        }

        private void num_Size_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Size = num_Size.Value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Used to set the GUI based on user settings
        /// </summary>
        public void LoadInitialSettings()
        {
            chk_Startup.Checked = RunAtStartup;

            chk_DisplayNotification.Checked = SaveMyHard.Properties.Settings.Default.DisplayNotification;
            //load num value
            num_Size.Value = SaveMyHard.Properties.Settings.Default.Size;

            Protection(SaveMyHard.Properties.Settings.Default.Protection);

            var disableStatus = SaveMyHard.Properties.Settings.Default.DisableType;

            switch (disableStatus)
            {
                case DisableStatus.All:
                    {
                        rad_DisableAll.Checked = true;
                        SetDisableAll(true);
                        break;
                    }
                case DisableStatus.Size:
                    {
                        rad_DisableSize.Checked = true;
                        SetDisableSize(true);
                        break;
                    }
            }

        }

        /// <summary>
        /// Used to enable GUI controls or disable them based on param
        /// </summary>
        private void Protection(bool isEnable)
        {
            if (isEnable)
            {
                chk_EnableProtection.Checked = isEnable;
                grpBox_Protection.Enabled = isEnable;
            }
            else
            {
                chk_EnableProtection.Checked = isEnable;
                grpBox_Protection.Enabled = isEnable;
            }
        }

        /// <summary>
        /// Used to add or remove the Program from startup list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_Startup_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Startup.Checked)
            {
                Tools.AddToStartup();
            }
            else
            {
                Tools.RemoveFromStartup();
            }
        }

        /// <summary>
        /// Used to enable or disable notifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_DisplayNotification_CheckedChanged(object sender, EventArgs e)
        {
            SaveMyHard.Properties.Settings.Default.DisplayNotification = chk_DisplayNotification.Checked;
            Properties.Settings.Default.Save();
        }
        
        #endregion
    }
}
