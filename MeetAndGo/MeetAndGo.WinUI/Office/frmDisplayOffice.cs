using MeetAndGo.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Office
{
    public partial class frmDisplayOffice : Form
    {
        ApiService _serviceOffice = new ApiService("Office");

        public frmDisplayOffice()
        {
            InitializeComponent();
        }
        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            OfficeSearchObject request = new OfficeSearchObject
            {
                Name = txt_Name.Text
            };

            dgvOffices.DataSource = await _serviceOffice.GetAll<List<Model.Office>>(request);
        }

        private async void frmDisplayForm_Load(object sender, EventArgs e)
        {
            dgvOffices.DataSource = await _serviceOffice.GetAll<List<Model.Office>>();
        }

        private void dgvOffices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var office = dgvOffices.SelectedRows[0].DataBoundItem as Model.Office;

            frmOfficeDetails frm = new frmOfficeDetails(office as Model.Office);
            frm.ShowDialog();
        }
    }
}
