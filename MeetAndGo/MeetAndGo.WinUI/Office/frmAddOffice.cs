using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Office
{
    public partial class frmAddOffice : Form
    {
        ApiService _serviceCities = new ApiService("City");
        ApiService _serviceCountries = new ApiService("Country");
        ApiService _serviceTypeOfBuildings = new ApiService("TypeOfBuilding");


        public frmAddOffice()
        {
            InitializeComponent();
        }
        private async void frmAddOffice_Load(object sender, System.EventArgs e)
        {
            await LoadCities();
            await LoadCountries();
            await LoadTypeOfBuildings();
        }

        private async Task LoadCities()
        {
            var cities = await _serviceCities.GetAll<List<Model.City>>();
            LoadDataHelper.LoadDataInComboBox(cmb_Cities, cities, "CityId");
        }
        private async Task LoadCountries()
        {
            var countries = await _serviceCountries.GetAll<List<Model.Country>>();
            LoadDataHelper.LoadDataInComboBox(cmb_Countries, countries, "CountryId");
        }
        private async Task LoadTypeOfBuildings()
        {
            var typeOfBuildings = await _serviceTypeOfBuildings.GetAll<List<Model.TypeOfBuilding>>();
            LoadDataHelper.LoadDataInComboBox(cmb_TypeOfBuilding, typeOfBuildings, "TypeOfBuildingId");
        }

    }
}
