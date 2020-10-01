using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.SystemModules.Customer;
using res_pos.SystemModules.Employee;
using res_pos.SystemModules.Product;

namespace res_pos.SystemModules.Dashboard
{
    public partial class frmBasicDataDashboard : MetroFramework.Forms.MetroForm
    {
        public frmBasicDataDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        public int userId { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainDashboard md = new frmMainDashboard(userId);
            md.Show();
            this.Hide();
        }

        private void btnProCat_Click(object sender, EventArgs e)
        {
            frmProCat p = new frmProCat(this.userId, "add");
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProduct p = new frmProduct(this.userId, "add");
            p.Show();
            this.Hide();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            frmPrice p = new frmPrice(this.userId, "add");
            p.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomers c = new frmCustomers(this.userId, "add");
            c.Show();
            this.Hide();
        }

        private void frmBasicDataDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee em = new frmEmployee(this.userId, "add");
            em.Show();
            this.Hide();
        }
    }
}
