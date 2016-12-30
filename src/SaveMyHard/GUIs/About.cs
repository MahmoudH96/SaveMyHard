using System.Windows.Forms;

namespace SaveMyHard.GUIs
{
    public partial class About : Form
    {
        #region Fields

        #endregion

        #region Constructors
        public About()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods
        private void link_Dev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.linkedin.com/in/mahmoud-heretani-693a2b117");
        }

        private void link_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/MahmoudH96/SaveMyHard");
        }

        private void link_MIT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/MahmoudH96/SaveMyHard/blob/master/LICENSE");
        }
        #endregion


    }
}
