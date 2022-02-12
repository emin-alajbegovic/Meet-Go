using System.Windows.Forms;

namespace MeetAndGo.WinUI.Office
{
    public partial class frmOfficeDetails : Form
    {
        ApiService _serviceOffices = new ApiService("Office");

        private Model.Office _office;

        public frmOfficeDetails(Model.Office office = null)
        {
            InitializeComponent();
            _office = office;
        }

        private void frmOfficeDetails_Load(object sender, System.EventArgs e)
        {
            if (_office != null)
            {
                txt_FirstName.Text = _office.Name;
                txt_LastName.Text = _office.Description;
                txt_Phone.Text = _office.Adress;
                txt_Email.Text = _office.Picture;
            }
        }
    }
}
