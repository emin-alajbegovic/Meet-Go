using MeetAndGo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.User
{
    public partial class frmUserDetails : Form
    {
        ApiService _serviceUsers = new ApiService("User");
        ApiService _serviceRoles = new ApiService("Role");
        ApiService _serviceUserAccounts = new ApiService("UserAccount");

        private Model.User _user;
        public frmUserDetails(Model.User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            await LoadRoles();

            var result = await _serviceUserAccounts.GetAll<List<Model.UserAccount>>();
            Model.UserAccount user = result?.FirstOrDefault(x => x.UserAccountId == _user.UserAccountId);
            var role = user.UserAccountRole.Where(x => x.UserAccountId == _user.UserAccountId).FirstOrDefault();

            if (role != null)
            {
                clbRole.SetItemChecked(role.Role.RoleId, true);
            }

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
            LoadDataHelper.LoadDataInCheckedListBox(clbRole, roles, "RoleId");
        }
    }
}
