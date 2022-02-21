using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Office
{
    public partial class frmAddOffice : Form
    {
        ApiService _serviceCities = new ApiService("City");
        ApiService _serviceCountries = new ApiService("Country");
        ApiService _serviceTypeOfOffices = new ApiService("TypeOfOffice");


        public frmAddOffice()
        {
            InitializeComponent();
        }
        private async void frmAddOffice_Load(object sender, System.EventArgs e)
        {
            await LoadCities();
            await LoadCountries();
            await LoadTypeOfOffice();
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
        private async Task LoadTypeOfOffice()
        {
            var typeOfOffice = await _serviceTypeOfOffices.GetAll<List<Model.TypeOfOffice>>();
            LoadDataHelper.LoadDataInComboBox(cmb_TypeOfOffice, typeOfOffice, "TypeOfOfficeId");
        }

    }
}
