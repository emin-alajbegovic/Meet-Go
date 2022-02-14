using MeetAndGo.WinUI.User;
using System.Windows.Forms;

namespace MeetAndGo.WinUI
{
    public partial class MDIHomeSuperAdmin : Form
    {
        public MDIHomeSuperAdmin()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUser frm = new frmAddUser();

            frm.ShowDialog();
        }
    }
}
