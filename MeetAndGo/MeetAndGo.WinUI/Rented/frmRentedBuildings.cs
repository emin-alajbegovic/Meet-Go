using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Rented
{
    public partial class frmRentedBuildings : Form
    {
        ApiService _serviceRentedBuilding = new ApiService("RentedBuilding");

        //private Model.RentedOffice

        public frmRentedBuildings()
        {
            InitializeComponent();
        }

        private async void frmRentedBuildings_Load(object sender, EventArgs e)
        {
            dgvRentedBuildings.DataSource = await _serviceRentedBuilding.GetAllRentedBuildings<List<Model.RentedBuilding>>();
        }

        private void dgvRentedBuildings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvRentedBuildings.SelectedRows[0].DataBoundItem as Model.RentedBuilding;

            txt_FirstName.Text = item.Firstname;
            txt_LastName.Text = item.LastName;
            txt_BuildingName.Text = item.Building;
            txt_Adress.Text = item.Adress;
            dtp_BeginRentalDate.Value = item.BeginRentalDate;
            dtp_EndRentalDate.Value = item.EndRentalDate;
            //item.Price = decimal.Parse(txt_Price.Text);

            pbx_Picture.Image = PictureService.FromByteToImage(item.Picture);
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            var item = dgvRentedBuildings.SelectedRows[0].DataBoundItem as Model.RentedBuilding;
            var dateDiff = (dtp_BeginRentalDate.Value - DateTime.UtcNow).TotalDays;

            if (dateDiff > 6)
            {
                Model.Requests.RentedBuildingUpdateRequest request = new Model.Requests.RentedBuildingUpdateRequest
                {
                    UserId = item.UserId,
                    BuildingId = item.BuildingId,
                    BeginRentalDate = item.BeginRentalDate,
                    EndRentalDate = item.EndRentalDate,
                    Rented = false
                };

                await _serviceRentedBuilding.Update<Model.RentedBuilding>(item.RentedBuildingId, request);
                MessageBox.Show("Building successfully canceled!");
                this.Close();
            }
            else
                MessageBox.Show("You can't cancel the reservation of the building since it is left less than 6 days");
        }
    }
}
