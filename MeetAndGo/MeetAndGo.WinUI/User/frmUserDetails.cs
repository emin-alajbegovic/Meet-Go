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
    public partial class frmUserDetails : Form
    {
        ApiService _serviceUsers = new ApiService("User");
        ApiService _serviceRoles = new ApiService("Role");

        private Model.User _user;
        public frmUserDetails(Model.User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
