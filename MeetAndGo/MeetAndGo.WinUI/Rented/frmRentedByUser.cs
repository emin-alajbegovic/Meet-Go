using System;
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

        private void frmRentedByUser_Load(object sender, EventArgs e)
        {
            //dgvOffices.DataSource = await _serviceRentedOffices.GetAll<List<Model.RentedOffice>>();
            //dgvBuildings.DataSource = await _serviceRentedBuildings.GetAll<List<Model.RentedBuilding>>();
        }
    }
}
