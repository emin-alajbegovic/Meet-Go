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
            //item.Price = decimal.Parse(txt_Price.Text);

            pbx_Picture.Image = PictureService.FromByteToImage(item.Picture);
        }
    }
}
