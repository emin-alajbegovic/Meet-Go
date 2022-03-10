using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Building
{
    public partial class frmAddBuilding : Form
    {
        ApiService _serviceCities = new ApiService("City");
        ApiService _serviceTypeOfBuildings = new ApiService("TypeOfBuilding");
        ApiService _serviceBuildings = new ApiService("Building");

        public frmAddBuilding()
        {
            InitializeComponent();
        }

        private async void frmAddBuilding_Load(object sender, System.EventArgs e)
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
        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren() && txtPicture_Validating())
            {
                var cmbCity = cmb_Cities.SelectedValue;
                var cmbTypeOfBuilding = cmb_TypeOfBuilding.SelectedValue;
                var clbParking = check_Parking.Checked;
                var clbCameras = check_Cameras.Checked;
                var clbSecurity = check_Security.Checked;

                Model.Requests.BuildingUpsertRequest building = new Model.Requests.BuildingUpsertRequest
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
                    NumberOfOffices = int.Parse(txt_OfficeNumbers.Text),
                    Security = clbSecurity,
                    Price = decimal.Parse(txt_Price.Text),
                };

                if (int.TryParse(cmbTypeOfBuilding.ToString(), out int Id))
                    building.TypeOfBuildingId = Id;

                if (int.TryParse(cmbCity.ToString(), out int id))
                    building.CityId = id;

                building.Picture = PictureService.FromImageToByte(txt_Picture);

                await _serviceBuildings.Insert<Model.Building>(building);
                MessageBox.Show("Building successfully added!");
                this.Close();
            }
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

        private void txt_OfficeNumbers_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void btn_LoadImage_Click(object sender, System.EventArgs e)
        {
            var result = ofdPicture.ShowDialog();

            if (result == DialogResult.OK)
                OpenFileDialogHelper.LoadPicture(ofdPicture, pbx_Picture, txt_Picture);
        }
    }
}
