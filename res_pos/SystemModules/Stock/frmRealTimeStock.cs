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

namespace res_pos.SystemModules.Stock
{
    public partial class frmRealTimeStock : MetroFramework.Forms.MetroForm
    {
        public frmRealTimeStock()
        {
            InitializeComponent();
        }

        ProductClass pro;

        // get selected stock category
        private int getSelectedStockCat()
        {
            int returnVal = 1;
            if (radioDirectSellProducts.Checked == true)
            {
                returnVal = 1;
            }
            if (radioRawProducts.Checked == true)
            {
                returnVal = 2;
            }
            return returnVal;
        }

        public void fillProductNameCombo(int stockCat)
        {
            pro = new ProductClass();
            dbproductBindingSource.DataSource = pro.getProductByStockCat(stockCat);

        }

        private void frmRealTimeStock_Load(object sender, EventArgs e)
        {
            fillProductNameCombo(1);
        }

        private void radioRawProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRawProducts.Checked == true)
            {
                fillProductNameCombo(2);
            }
        }

        private void radioDirectSellProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDirectSellProducts.Checked == true)
            {
                fillProductNameCombo(1);
            }
        }
    }
}
