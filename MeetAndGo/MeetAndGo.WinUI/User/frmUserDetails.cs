using MeetAndGo.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.User
{
    public partial class frmUserDetails : Form
    {
        ApiService _serviceUsers = new ApiService("User");
        ApiService _serviceRoles = new ApiService("Role");

        private Model.User _user;
        public frmUserDetails(Model.User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            await LoadRoles();
            if (_user != null)
            {
                txt_FirstName.Text = _user.FirstName;
                txt_LastName.Text = _user.LastName;
                txt_Phone.Text = _user.PhoneNumber;
                txt_Email.Text = _user.Email;
            }
        }

        private async Task LoadRoles()
        {
            var roles = await _serviceRoles.GetAll<List<Role>>();
            clbRole.DataSource=roles;
            clbRole.DisplayMember = "Name";
        }
    }
}
