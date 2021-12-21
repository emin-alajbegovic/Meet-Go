using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.User
{
    public partial class frmUserAddEdit : Form
    {
        public frmUserAddEdit()
        {
            InitializeComponent();
        }

        private void txt_Name_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txt_Name, Properties.Resources.RequiredField);
        }
    }
}
