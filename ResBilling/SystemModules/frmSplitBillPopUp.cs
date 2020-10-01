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
    public partial class frmProduct : MetroFramework.Forms.MetroForm
    {
        public frmProduct(int ticketId, int proId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            this.proId = proId;
            setData(getTempBillProducts());
        }

        TempBillClass tbc;

        public string price { get; set; }
        public string proCode { get; set; }
        public string name { get; set; }
        public string qty { get; set; }
        public string discount { get; set; }
        public double sellingPrice { get; set; }

        public int ticketId { get; set; }
        public int proId { get; set; }


        private BillingProDataVM getTempBillProducts()
        {
            tbc = new TempBillClass();
            BillingProDataVM bvm;
            bvm = tbc.getItemByTempTicket(this.proId, this.ticketId);
            return bvm;
        }

        private void setData(BillingProDataVM bvm)
        {
            txt_discount.Value = decimal.Parse(bvm.discount.ToString());
            txt_qty.Value = int.Parse(bvm.qty.ToString());
            txt_qty.Maximum = int.Parse(bvm.qty.ToString());
            txtProCode.Text = bvm.proCode;
            txtProPrice.Text = (calculateTotal(bvm.qty, double.Parse(bvm.sellingPrice.ToString()), double.Parse(bvm.discount.ToString()))).ToString();
            this.sellingPrice = bvm.sellingPrice;
            lbl_heading.Text = bvm.proName; 

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

        private void updatePrice(double qty, double sellingPrice, double discount)
        {

            txtProPrice.Text = (calculateTotal(int.Parse(qty.ToString()), double.Parse(sellingPrice.ToString()), double.Parse(discount.ToString()))).ToString();
        }

        private void frmSplitBillPopUp_Load(object sender, EventArgs e)
        {

        }

        private void txt_qty_ValueChanged(object sender, EventArgs e)
        {
            double discount = double.Parse(txt_discount.Value.ToString());
            double qty = double.Parse(txt_qty.Value.ToString());
            updatePrice(qty, this.sellingPrice, discount);
        }

        private void txt_discount_ValueChanged(object sender, EventArgs e)
        {
            double discount = double.Parse(txt_discount.Value.ToString());
            double qty = double.Parse(txt_qty.Value.ToString());
            updatePrice(qty, this.sellingPrice, discount);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.qty = txt_qty.Value.ToString();
            this.discount = txt_discount.Value.ToString();
            this.price = txtProPrice.Text.ToString();
            this.name = lbl_heading.Text;
        }
    }
}
