using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Building
{
    public partial class frmAddBuilding : Form
    {
        ApiService _serviceCities = new ApiService("City");
        ApiService _serviceCountries = new ApiService("Country");
        ApiService _serviceTypeOfBuildings = new ApiService("TypeOfBuilding");

        public frmAddBuilding()
        {
            InitializeComponent();
        }

        private async void frmAddBuilding_Load(object sender, System.EventArgs e)
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

        private void txt_Name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Adress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Description_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Area_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void cmb_Countries_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldComboBox(sender as ComboBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void cmb_Cities_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldComboBox(sender as ComboBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void cmb_TypeOfBuilding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldComboBox(sender as ComboBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Floors_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Price_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_OfficeNumbers_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void check_Security_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldCheckListBox(sender as CheckedListBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void check_Cameras_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldCheckListBox(sender as CheckedListBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void check_Parking_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldCheckListBox(sender as CheckedListBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void pbx_Picture_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren() /*&& pbx_Picture_Validating()*/)
            {

            }
        }
    }
}
