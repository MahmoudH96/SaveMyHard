using System;
using System.Threading;
using System.Windows.Forms;

namespace SaveMyHard
{
    internal class Program
    {
        #region Fields

        static string AppGUID = "bd6660b1-5dde-42c4-8711-f1d95b2352d0";

        #endregion

        #region Methods
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            /*
             * Used Mutex To run single instance application 
             * http://stackoverflow.com/questions/93989/prevent-multiple-instances-of-a-given-app-in-net
            */
            using (Mutex mutex = new Mutex(false, "Global\\" + AppGUID))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Save my hard is already running.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Application.EnableVisualStyles();
                Application.ThreadException += Application_ThreadException;
                Tools.LoadFontsFromResources();
                Application.Run(new TaskTrayApplicationContext());
            }

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Ops, something went wrong , please contact software provider for more information", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
    }
}
