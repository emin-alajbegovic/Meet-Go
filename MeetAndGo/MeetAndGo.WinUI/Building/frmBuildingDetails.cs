using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Building
{

    public partial class frmBuildingDetails : Form
    {
        ApiService _serviceCities = new ApiService("City");
        ApiService _serviceTypeOfBuildings = new ApiService("TypeOfBuilding");
        ApiService _serviceBuildings = new ApiService("Building");
        private Model.Building _building;

        public frmBuildingDetails(Model.Building building = null)
        {
            InitializeComponent();
            _building = building;
        }

        private async Task LoadData()
        {
            await LoadCities();
            await LoadTypeOfBuildings();
        }

        private async Task LoadCities()
        {
            var cities = await _serviceCities.GetAll<List<Model.City>>();
            LoadDataHelper.LoadDataInComboBox(cmb_Cities, cities, "CityId");
        }
        private async Task LoadTypeOfBuildings()
        {
            var typeOfBuildings = await _serviceTypeOfBuildings.GetAll<List<Model.TypeOfBuilding>>();
            LoadDataHelper.LoadDataInComboBox(cmb_TypeOfBuilding, typeOfBuildings, "TypeOfBuildingId");
        }

        private async void frmBuildingDetails_Load(object sender, System.EventArgs e)
        {
            await LoadData();
            if (_building != null)
            {
                txt_OfficeNumbers.Text = _building.NumberOfOffices.ToString();
                txt_Floors.Text = _building.NumberOfFloors.ToString();
                txt_Price.Text = _building.Price.ToString();
                txt_Area.Text = _building.Area;
                txt_Name.Text = _building.Name;
                txt_Adress.Text = _building.Adress;
                txt_Description.Text = _building.Description;
                cmb_Cities.SelectedIndex = _building.CityId - 1;
                cmb_TypeOfBuilding.SelectedIndex = _building.TypeOfBuildingId - 1;
                check_Cameras.Checked = _building.Cameras;
                check_Security.Checked = _building.Security;
                check_Parking.Checked = _building.Parking;
                pbx_Picture.Image = PictureService.FromByteToImage(_building.Picture);
            }
        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            await LoadData();
        }
    }
}
