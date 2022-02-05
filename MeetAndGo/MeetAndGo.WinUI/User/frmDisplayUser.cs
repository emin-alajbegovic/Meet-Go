using MeetAndGo.Model.SearchObject;
using System;
using System.Collections.Generic;
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

        private async void cmbRented_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvUsers.SelectedRows[0].DataBoundItem as Model.User;

            frmUserDetails frm = new frmUserDetails(item as Model.User);
            frm.ShowDialog();
        }
    }
}