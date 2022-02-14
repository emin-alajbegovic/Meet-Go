using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.User
{
    public partial class frmAddUser : Form
    {
        ApiService _serviceRoles = new ApiService("Role");
        ApiService _serviceUsers = new ApiService("User");
        ApiService _serviceUserAccounts = new ApiService("UserAccount");


        public frmAddUser()
        {
            InitializeComponent();
        }

        private async void frmAddUser_Load(object sender, EventArgs e)
        {
            await LoadRoles();
        }

        private async Task LoadRoles()
        {
            var roles = await _serviceRoles.GetAll<List<Model.Role>>();
            LoadDataHelper.LoadDataInComboBox(cmb_Role, roles, "RoleId");
        }
    }
}
