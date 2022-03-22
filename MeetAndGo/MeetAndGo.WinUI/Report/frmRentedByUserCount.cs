using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Report
{
    public partial class frmRentedByUserCount : Form
    {
        ApiService _serviceReport = new ApiService("Report");

        public frmRentedByUserCount()
        {
            InitializeComponent();
        }

        private async void frmRentedByUserCount_Load(object sender, EventArgs e)
        {
            dgv_Report.DataSource = await _serviceReport.GetAll<List<Model.Report.Report>>();
        }
    }
}