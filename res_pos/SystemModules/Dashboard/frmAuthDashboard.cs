using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.SystemModules;
using res_pos.SystemModules.Authentication;
using res_pos.SystemModules.Employee;

namespace res_pos.SystemModules.Dashboard
{
    public partial class frmAuthDashboard : MetroFramework.Forms.MetroForm
    {
        public frmAuthDashboard(int userId)
        {
            InitializeComponent();
            setUserName(userId);
            this.userId = userId;
        }

        common_moduls cm;

        public int userId { get; set; }
        public string userName { get; set; }

        private void setUserName(int userId)
        {
            cm = new common_moduls();
            lblUserName.Text = cm.returnUserName(userId);
        }

        private void frmAuthDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainDashboard md = new frmMainDashboard(this.userId);
            md.Show();
            this.Hide();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee(userId, "add");
            emp.Show();
            this.Hide();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ucChangePassword cp = new ucChangePassword(this.userId);
            cp.Show();
            this.Hide();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRoles role = new frmRoles(this.userId, "add");
            role.Show();
            this.Hide();
        }

        private void btnRolesFunctions_Click(object sender, EventArgs e)
        {
            frmRoleFunction rf = new frmRoleFunction(this.userId);
            rf.Show();
            this.Hide();
        }
    }
}
