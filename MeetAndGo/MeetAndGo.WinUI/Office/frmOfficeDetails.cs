using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Office
{
    public partial class frmOfficeDetails : Form
    {
        ApiService _serviceCities = new ApiService("City");
        ApiService _serviceTypeOfOffices = new ApiService("TypeOfOffice");
        ApiService _serviceOffices = new ApiService("Office");

        private Model.Office _office;

        public frmOfficeDetails(Model.Office office = null)
        {
            InitializeComponent();
            _office = office;
        }

        private async Task LoadData()
        {
            await LoadCities();
            await LoadTypeOfOffice();
        }

        private async Task LoadCities()
        {
            var cities = await _serviceCities.GetAll<List<Model.City>>();
            LoadDataHelper.LoadDataInComboBox(cmb_Cities, cities, "CityId");
        }
        private async Task LoadTypeOfOffice()
        {
            var typeOfOffice = await _serviceTypeOfOffices.GetAll<List<Model.TypeOfOffice>>();
            LoadDataHelper.LoadDataInComboBox(cmb_TypeOfOffice, typeOfOffice, "TypeOfOfficeId");
        }

        private async void frmOfficeDetails_Load(object sender, System.EventArgs e)
        {
            await LoadData();
            if (_office != null)
            {
                txt_Floors.Text = _office.NumberOfFloors.ToString();
                txt_Price.Text = _office.Price.ToString();
                txt_Area.Text = _office.Area;
                txt_Name.Text = _office.Name;
                txt_Adress.Text = _office.Adress;
                txt_Description.Text = _office.Description;
                cmb_Cities.SelectedIndex = _office.CityId - 1;
                cmb_TypeOfOffice.SelectedIndex = _office.TypeOfOfficeId - 1;
                check_Cameras.Checked = _office.Cameras;
                check_Parking.Checked = _office.Parking;
                pbx_Picture.Image = PictureService.FromByteToImage(_office.Picture);
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

        }
    }
}
