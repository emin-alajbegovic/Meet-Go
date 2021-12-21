using MeetAndGo.Model;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
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
    public partial class frmDisplayUser : Form
    {
        ApiService _serviceUsers = new ApiService("User");
        public frmDisplayUser()
        {
            InitializeComponent();
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            UserSearchObject request = new UserSearchObject
            {
                FirstName = txt_Name.Text
            };

            dgvUsers.DataSource = await _serviceUsers.GetAll<List<Model.User>>(request);
        }

        private async void frmDisplayUser_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = await _serviceUsers.GetAll<List<Model.User>>();
        }
    }
}
