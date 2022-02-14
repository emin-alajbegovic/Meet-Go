using System.Windows.Forms;

namespace MeetAndGo.WinUI.Building
{

    public partial class frmBuildingDetails : Form
    {
        ApiService _serviceBuildings = new ApiService("Building");
        private Model.Building _building;

        public frmBuildingDetails(Model.Building building = null)
        {
            InitializeComponent();
            _building = building;
        }

        private void frmBuildingDetails_Load(object sender, System.EventArgs e)
        {
            if (_building != null)
            {
                txt_FirstName.Text = _building.Name;
                txt_LastName.Text = _building.Description;
                txt_Phone.Text = _building.Adress;
                txt_Email.Text = _building.Adress;
            }
        }
    }
}
