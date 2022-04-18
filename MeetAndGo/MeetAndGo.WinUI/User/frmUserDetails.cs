using MeetAndGo.Model;
using MeetAndGo.WinUI.Rented;
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
        ApiService _serviceUserRolesAccounts = new ApiService("UserAccountRole");
        ApiService _serviceRentedOffices = new ApiService("RentedOffice");
        ApiService _serviceRentedBuildings = new ApiService("RentedBuilding");

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
            var role = await _serviceUserRolesAccounts.GetRoleByUserAccountId<Model.UserAccountRole>(user.UserAccountId);

            if (role != null)
            {
                clbRole.SetItemChecked(role.RoleId - 1, true);
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

        private async void btnDisplayReservations_Click(object sender, EventArgs e)
        {
            var building = await _serviceRentedBuildings.GetAllRentedByUserId<List<Model.RentedBuilding>>(_user.UserId);
            var office = await _serviceRentedOffices.GetAllRentedByUserId<List<Model.RentedOffice>>(_user.UserId);

            if (building.Count != 0 || office.Count != 0)
            {
                frmRentedByUser frm = new frmRentedByUser(_user);
                frm.Show();
            }
            else
            {
                MessageBox.Show("User doesn't have any reservations!");
            }
        }
    }
}
