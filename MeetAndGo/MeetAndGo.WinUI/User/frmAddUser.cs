using System;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.User
{
    public partial class frmAddUser : Form
    {
        ApiService _serviceRoles = new ApiService("Role");
        ApiService _serviceUsers = new ApiService("User");
        ApiService _serviceUserAccounts = new ApiService("UserAccount");


        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Model.Requests.UserAccountUpsertRequest userAccount = new Model.Requests.UserAccountUpsertRequest
                {
                    Email = txt_Email.Text,
                    Username = txt_Username.Text,
                    Password = txt_Password.Text
                };

                await _serviceUserAccounts.Insert<Model.UserAccount>(userAccount);

                Model.UserAccount createdUserAccount = await _serviceUserAccounts.GetUserAccountByUsername<Model.UserAccount>(userAccount.Username);

                if (createdUserAccount != null)
                {
                    Model.User user = new Model.User
                    {
                        FirstName = txt_FirstName.Text,
                        LastName = txt_LastName.Text,
                        PhoneNumber = txt_PhoneNumber.Text,
                        UserAccountId = createdUserAccount.UserAccountId
                    };

                    await _serviceUsers.Insert<Model.User>(user);
                    MessageBox.Show("Uspjesno dodan user");
                }
            }
        }

        private void txt_FirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_LastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_PhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void txt_Username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProv, Properties.Resources.RequiredField);
        }

        private void frmAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
