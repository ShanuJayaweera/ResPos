using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBilling.VM;
using ResBilling.Classes;
using ResBilling.Model;

namespace ResBilling.SystemModules
{
    public partial class frmUpdateViewItem : MetroFramework.Forms.MetroForm
    {
        public frmUpdateViewItem(int ticket_id, int product_id, string action)
        {
            InitializeComponent();

            this.ticketId = ticket_id;
            this.proId = product_id;

            setData(getTempBillProducts());
            if (action.Equals("view"))
            {
                viewState();
            }

        }

        public int ticketId { get; set; }
        public int proId { get; set; }

        TempBillClass tbc;

        private void viewState()
        {
            numDis.Enabled = false;
            numQty.Enabled = false;
            numPrice.Enabled = false;
            btn_update.Visible = false;
            lbl_heading.Text = "View Item";
        }


        private BillingProDataVM getTempBillProducts()
        {
            tbc = new TempBillClass();
            BillingProDataVM bvm;
            bvm = tbc.getItemByTempTicket(this.proId, this.ticketId);
            return bvm;
        }

        private void setData(BillingProDataVM bvm)
        {
            numDis.Value = decimal.Parse(bvm.discount.ToString());
            numQty.Value = int.Parse(bvm.qty.ToString());
            txtProCode.Text = bvm.proCode;
            numPrice.Text = (calculateTotal(bvm.qty, double.Parse(bvm.sellingPrice.ToString()), double.Parse(bvm.discount.ToString()))).ToString();
            txtProName.Text = bvm.proName;

        }

        private double calculateTotal(double qty, double sellingPrice, double discount)
        {
            double amount = (qty * sellingPrice) - discountedAmount(qty, sellingPrice, discount);
            return amount;
        }

        private double discountedAmount(double qty, double sellingPrice, double discount)
        {
            double amount = ((qty * sellingPrice) * discount) / 100;
            return amount;
        }


        private void frmUpdateViewItem_Load(object sender, EventArgs e)
        {

        }
    }
}
