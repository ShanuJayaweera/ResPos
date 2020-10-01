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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        LoggedUser lu;
        auth_users au;
        UserClass uc;
        MessageClass msg;

        private auth_users getUserInput()
        {
            au = new auth_users();
            au.user_name = txtUserName.Text.ToString();
            au.user_password = txtPassword.Text.ToString();
            return au;
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            msg = new MessageClass();
            if (string.IsNullOrEmpty(txtUserName.Text.ToString()) || string.IsNullOrEmpty(txtPassword.Text.ToString()))
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
                    frmMainDashboard md = new frmMainDashboard(int.Parse(lu.userId.ToString()));
                    md.Show();
                    this.Hide();
                }
            }
        }
    }
}
