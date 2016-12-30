using IWshRuntimeLibrary;
using Microsoft.Win32;
using Shell32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMyHard
{
    static class Program
    {
        #region Fields
        #endregion

        #region Methods
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.ThreadException += Application_ThreadException;
            Application.Run(new TaskTrayApplicationContext());
        }

        
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Ops, something went wrong , please contact software provider for more information","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

    

        

        #endregion
    }
}
