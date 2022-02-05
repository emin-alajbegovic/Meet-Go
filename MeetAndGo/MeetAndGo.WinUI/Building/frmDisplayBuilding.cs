using MeetAndGo.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Building
{
    public partial class frmDisplayBuilding : Form
    {
        ApiService _serviceBuildings = new ApiService("Building");

        public frmDisplayBuilding()
        {
            InitializeComponent();
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            BuildingSearchObject request = new BuildingSearchObject
            {
                Name = txt_Name.Text
            };

            dgvBuildings.DataSource = await _serviceBuildings.GetAll<List<Model.Building>>(request);
        }

        private async void frmDisplayBuilding_Load(object sender, EventArgs e)
        {
            dgvBuildings.DataSource = await _serviceBuildings.GetAll<List<Model.Building>>();
        }

        private void dgvBuildings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
