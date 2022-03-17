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
            dtp_BeginRentalDate.Value = item.BeginRentalDate;
            dtp_EndRentalDate.Value = item.EndRentalDate;
            //item.Price = decimal.Parse(txt_Price.Text);

            pbx_Picture.Image = PictureService.FromByteToImage(item.Picture);
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            var item = dgvRentedOffices.SelectedRows[0].DataBoundItem as Model.RentedOffice;
            var dateDiff = (dtp_BeginRentalDate.Value - DateTime.UtcNow).TotalDays;

            if (dateDiff > 6)
            {
                Model.Requests.RentedOfficeUpdateRequest request = new Model.Requests.RentedOfficeUpdateRequest
                {
                    OfficeId = item.OfficeId,
                    UserId = item.UserId,
                    BeginRentalDate = item.BeginRentalDate,
                    EndRentalDate = item.EndRentalDate,
                    Rented = false
                };

                await _serviceRentedOffices.Update<Model.RentedOffice>(item.RentedOfficeId, request);
                MessageBox.Show("Office successfully canceled!");
                this.Close();
            }
            else
                MessageBox.Show("You can't cancel the reservation of the office since it is left less than 6 days");
        }
    }
}
