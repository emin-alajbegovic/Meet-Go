using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Rented
{
    public partial class frmRentedByUser : Form
    {
        ApiService _serviceRentedBuildings = new ApiService("RentedBuilding");
        ApiService _serviceRentedOffices = new ApiService("RentedOffice");

        private Model.User _user;
        public frmRentedByUser(Model.User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmRentedByUser_Load(object sender, EventArgs e)
        {
            dgvOffices.DataSource = await _serviceRentedOffices.GetAllRentedByUserId<List<Model.RentedOffice>>(_user.UserId);
            dgv_Buildings.DataSource = await _serviceRentedBuildings.GetAllRentedByUserId<List<Model.RentedBuilding>>(_user.UserId);
        }
    }
}
