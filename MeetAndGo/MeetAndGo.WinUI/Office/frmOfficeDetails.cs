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

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren())
            {
                var cmbCity = cmb_Cities.SelectedValue;
                var cmbTypeOfOffice = cmb_TypeOfOffice.SelectedValue;
                var clbParking = check_Parking.Checked;
                var clbCameras = check_Cameras.Checked;

                Model.Requests.OfficeUpsertRequest office = new Model.Requests.OfficeUpsertRequest
                {
                    Name = txt_Name.Text,
                    Adress = txt_Adress.Text,
                    Description = txt_Description.Text,
                    Area = txt_Area.Text,
                    Parking = clbParking,
                    Cameras = clbCameras,
                    Rented = false,
                    IsDeleted = false,
                    NumberOfFloors = int.Parse(txt_Floors.Text),
                    Price = decimal.Parse(txt_Price.Text),
                };

                if (int.TryParse(cmbTypeOfOffice.ToString(), out int Id))
                    office.TypeOfOfficeId = Id;

                if (int.TryParse(cmbCity.ToString(), out int id))
                    office.CityId = id;

                if (txt_Picture.Text != "")
                    office.Picture = PictureService.FromImageToByte(txt_Picture);
                else
                    office.Picture = _office.Picture;

                await _serviceOffices.Update<Model.Office>(_office.OfficeId, office);
                MessageBox.Show("Office successfully updated!");
                this.Close();
            }
        }
        private void cmb_Cities_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredCombo(cmb_Cities, e, errorProv, Properties.Resources.RequiredField);
        }
        private void cmb_TypeOfOffice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredCombo(cmb_TypeOfOffice, e, errorProv, Properties.Resources.RequiredField);
        }

        private void btn_LoadImage_Click(object sender, System.EventArgs e)
        {
            var result = ofdPicture.ShowDialog();

            if (result == DialogResult.OK)
                OpenFileDialogHelper.LoadPicture(ofdPicture, pbx_Picture, txt_Picture);
        }
    }
}
