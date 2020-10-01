using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.Classes;
using res_pos.Model;

namespace res_pos.SystemModules.Stock
{
    public partial class frmViewStock : MetroFramework.Forms.MetroForm
    {
        public frmViewStock(int userId, int invId)
        {
            InitializeComponent();
            this.InvId = invId;
            this.userId = userId;
        }

        StockInvoiceClass sic;
        db_stk_invoice si;

        public int userId { get; set; }
        public int InvId { get; set; }

        private void fillGridView(int invId)
        {
            sic = new StockInvoiceClass();
            si = new db_stk_invoice();
            var list = sic.getStockGridFillDataByInvId(invId);
            foreach (var item in list)
            {
                gridInvoice.Rows.Add(item.invId, item.stkId, item.productName, item.qty, item.buyingPrice, item.sellingPrice, item.discount);
            }

        }

        private void frmViewStock_Load(object sender, EventArgs e)
        {
            fillGridView(this.InvId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSetSupplierAndDate su = new frmSetSupplierAndDate(this.userId);
            su.Show();
            this.Hide();
        }
    }
}
