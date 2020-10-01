using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.Model;
using res_pos.VM;
using res_pos.Classes;
using res_pos.Classes.AuthClasess;
using res_pos.SystemModules.Dashboard;

namespace res_pos.SystemModules.Authentication
{
    public partial class ucChangePassword : UserControl
    {
        public ucChangePassword(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        LoggedUser lu;
        auth_users au;
        UserClass uc;
        MessageClass msg;

        public int userId { get; set; }

        private auth_users getUserInput()
        {
            au = new auth_users();
            au.user_name = txtUserName.Text.ToString();
            au.user_password = txtOldPassword.Text.ToString();
            return au;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            msg = new MessageClass();
            if (string.IsNullOrEmpty(txtUserName.Text.ToString()) || string.IsNullOrEmpty(txtOldPassword.Text.ToString()))
            {
                msg.requiredDataErr();
            }
            else
            {
                uc = new UserClass();
                au = new auth_users();
                au = getUserInput();
                lu = new LoggedUser();
                lu = uc.login(au.user_name, au.user_password);
                if (lu.roleId == null || lu.userId == null)
                {
                    MessageBox.Show("Wrong user details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // change password
                    string respond = uc.changePassword(au.user_name, au.user_password, txtNewPassword.Text.ToString());
                    if (respond.Equals("done"))
                    {
                        msg.recodeUpdateSuccess();
                        frmLogin log = new frmLogin();
                        this.Hide();
                        log.Show();
                    }
                    else
                    {
                        msg.recodeNotExistErr();
                    }
                }
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAuthDashboard ad = new frmAuthDashboard(this.userId);
            ad.Show();
            this.Hide();
        }
    }
}
