using MeetAndGo.WinUI.Building;
using MeetAndGo.WinUI.Office;
using MeetAndGo.WinUI.User;
using System;
using System.Windows.Forms;

namespace MeetAndGo.WinUI
{
    public partial class MDIHome : Form
    {
        private int childFormNumber = 0;

        public MDIHome()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayUser frm = new frmDisplayUser();

            frm.MdiParent = this;
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayBuildingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayBuilding frm = new frmDisplayBuilding();

            frm.MdiParent = this;
            frm.Show();
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDisplayOffice frm = new frmDisplayOffice();

            frm.MdiParent = this;
            frm.Show();
        }

        private void addOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOffice frm = new frmAddOffice();

            frm.MdiParent = this;
            frm.Show();
        }

        private void addBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBuilding frm = new frmAddBuilding();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
