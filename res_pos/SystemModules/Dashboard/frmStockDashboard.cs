using res_pos.stock;
using res_pos.SystemModules.Stock;
using res_pos.SystemModules.Supplier;
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
    public partial class frmStockDashboard : MetroFramework.Forms.MetroForm
    {
        public frmStockDashboard(int userId)
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

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmStock stk = new frmStock(this.userId);
            stk.Show();
            this.Hide();

        }

        private void btnViewRealTimeStock_Click(object sender, EventArgs e)
        {
            frmRealTimeStock rts = new frmRealTimeStock();
            rts.Show();
            this.Hide();

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier s = new frmSupplier(userId, "add");
            s.Show();
            this.Hide();
        }

        private void btnViewStockByInvoiceId_Click(object sender, EventArgs e)
        {
            frmSetSupplierAndDate fd = new frmSetSupplierAndDate(this.userId);
            fd.Show();
            this.Hide();
        }
    }
}
