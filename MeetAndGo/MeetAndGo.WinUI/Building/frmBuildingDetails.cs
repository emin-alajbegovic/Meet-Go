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
            if (ValidateChildren())
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

                if (txt_Picture.Text != "")
                    building.Picture = PictureService.FromImageToByte(txt_Picture);
                else
                    building.Picture = _building.Picture;

                await _serviceBuildings.Update<Model.Building>(_building.BuildingId, building);
                MessageBox.Show("Building successfully upated!");
                this.Close();
            }
        }
        private void cmb_Cities_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredCombo(cmb_Cities, e, errorProv, Properties.Resources.RequiredField);
        }
        private void cmb_TypeOfBuilding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredCombo(cmb_TypeOfBuilding, e, errorProv, Properties.Resources.RequiredField);
        }

        private void btn_LoadImage_Click(object sender, System.EventArgs e)
        {
            var result = ofdPicture.ShowDialog();

            if (result == DialogResult.OK)
                OpenFileDialogHelper.LoadPicture(ofdPicture, pbx_Picture, txt_Picture);
        }
    }
}
