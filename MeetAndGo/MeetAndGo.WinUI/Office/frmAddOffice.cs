using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Office
{
    public partial class frmAddOffice : Form
    {
        ApiService _serviceCities = new ApiService("City");
        ApiService _serviceTypeOfOffices = new ApiService("TypeOfOffice");
        ApiService _serviceOffices = new ApiService("Office");

        public frmAddOffice()
        {
            InitializeComponent();
        }
        private async void frmAddOffice_Load(object sender, System.EventArgs e)
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

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren() && txtPicture_Validating())
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

                office.Picture = PictureService.FromImageToByte(txt_Picture);

                await _serviceOffices.Insert<Model.Office>(office);
                MessageBox.Show("Office successfully added!");
                this.Close();
            }
        }
        private void btn_LoadImage_Click(object sender, System.EventArgs e)
        {
            var result = ofdPicture.ShowDialog();

            if (result == DialogResult.OK)
                OpenFileDialogHelper.LoadPicture(ofdPicture, pbx_Picture, txt_Picture);
        }
        private bool txtPicture_Validating()
        {
            return Validator.RequiredFieldPicture(txt_Picture, errorProv, Properties.Resources.RequiredField);
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

        private void txt_Floors_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Price_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }
    }
}
