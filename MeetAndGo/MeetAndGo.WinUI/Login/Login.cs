using MeetAndGo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Login
{
    public partial class frmLogin : Form
    {
        ApiService _serviceUserAccounts = new ApiService("UserAccount");

        enum Role
        {
            Admin,
            SuperAdmin,
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            ApiService.UserName = txt_Username.Text;
            ApiService.Password = txt_Password.Text;
            try
            {
                var result = await _serviceUserAccounts.GetAll<List<Model.UserAccount>>();
                Model.UserAccount user = result?.FirstOrDefault(x => x.Username == txt_Username.Text);
                var role = user.UserAccountRole.Where(x => x.UserAccountId == user.UserAccountId).FirstOrDefault();
                if (user != null && role.Role.Name == Role.Admin.ToString())
                {
                    this.Hide();
                    MDIHome frm = new MDIHome();
                    frm.Owner = this;
                    frm.Show();
                }
                //if (user != null && role.Role.Name == Role.SuperAdmin.ToString())
                //{
                //    this.Hide();
                //    MDIHomeSuperAdmin frm = new MDIHomeSuperAdmin(user);
                //    frm.Owner = this;
                //    frm.Show();
                //}
            }
            catch
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

    }
}
