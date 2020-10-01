using res_pos.SystemModules.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace res_pos.SystemModules.Dashboard
{
    public partial class frmMainDashboard : MetroFramework.Forms.MetroForm
    {
        public frmMainDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        common_moduls cm;
        public int userId { get; set; }

        private void setUserName(int userId)
        {
            cm = new common_moduls();
            lblUserName.Text = cm.returnUserName(userId);
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            setUserName(userId);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockDashboard f = new frmStockDashboard(this.userId);
            f.Show();
            this.Hide();
        }

        private void btnBasicData_Click(object sender, EventArgs e)
        {
            frmBasicDataDashboard bd = new frmBasicDataDashboard(this.userId);
            bd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAuthDashboard gg = new frmAuthDashboard(userId);
            gg.Show();
            this.Hide();

        }
    }
}
