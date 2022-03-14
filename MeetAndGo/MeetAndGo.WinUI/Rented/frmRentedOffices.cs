using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Rented
{
    public partial class frmRentedOffices : Form
    {
        ApiService _serviceRentedOffices = new ApiService("RentedOffice");

        public frmRentedOffices()
        {
            InitializeComponent();
        }

        private async void frmRentedOffices_Load(object sender, EventArgs e)
        {
            dgvRentedOffices.DataSource = await _serviceRentedOffices.GetAllRentedOffices<List<Model.RentedOffice>>();
        }

        private void dgvRentedOffices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvRentedOffices.SelectedRows[0].DataBoundItem as Model.RentedOffice;

            txt_FirstName.Text = item.Firstname;
            txt_LastName.Text = item.LastName;
            txt_OfficeName.Text = item.Office;
            txt_Adress.Text = item.Adress;
            //item.Price = decimal.Parse(txt_Price.Text);

            pbx_Picture.Image = PictureService.FromByteToImage(item.Picture);
        }
    }
}
