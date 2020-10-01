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
using res_pos.Classes;
using res_pos.Interfaces;
using System.Runtime.ExceptionServices;

namespace res_pos.stock
{
    public partial class frmStock : MetroFramework.Forms.MetroForm
    {
        public frmStock(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        public int userId { get; set; }
        public int stockId { get; set; }
        public int invId { get; set; }
        public string action { get; set; }
        public int supplierId { get; set; }


        ProductClass pro;
        PriceClass pc;
        SupplierClass sup;
        StockClass sc;
        common_moduls cm;
        MessageClass msg;
        db_stock stk;
        db_price pri;
        db_real_time_direct_sell_stock dss;
        db_real_time_raw_stock rs;
        StockInvoiceClass sic;
        db_inv_direct_sell_stock idss;
        db_inv_raw_stock irs;
        

        // set product names filterd by stock category
        public void fillProductNameCombo(int stockCat)
        {
            pro = new ProductClass();
            dbproductBindingSource.DataSource = pro.getProductByStockCat(stockCat);
            
        }

        // set supplier names
        public void fillSupNameCombo()
        {
            sup = new SupplierClass();
            dbsupplierBindingSource.DataSource = sup.getAllRecodes();
        }

        // set product details to field
        public void setProDetails(int proId)
        {
            // set product details
            pro = new ProductClass();
            List<db_product> list = pro.getRecodeById(proId);
            foreach (var item in list)
            {
                lblProCode.Text = item.pro_code;
                
            }

            // set price details
            pc = new PriceClass();
            List<db_price> priceList = pc.getPriceByProId(proId);
            int count = 0;
            foreach (var item in priceList)
            {
                numBuyingPrice.Value = decimal.Parse(item.buying_price.ToString());
                numSellingPrice.Value = decimal.Parse(item.selling_price.ToString());
                numProDiscount.Value = decimal.Parse(item.discount.ToString());
                count++;
            }
            if (count == 0)
            {
                numBuyingPrice.Value = decimal.Parse("0.00");
                numSellingPrice.Value = decimal.Parse("0.00");
                numProDiscount.Value = decimal.Parse("0.00");
            }
        }
        
        // set supplier details to labels
        public void setSupDetails(int supId)
        {
            sup = new SupplierClass();
            List<db_supplier> list = sup.getRecodeById(supId);
            foreach (var item in list)
            {
                lblSupAddress.Text = item.sup_address;
                lblSupMobile.Text = item.sup_mobile;
            }
        }


        // check is data already in grid
        private Boolean isDataExistInGrid(int? proId)
        {
            Boolean x = false;
            for (int i = 0; i < gridBill.RowCount; i++)
            {
                if (gridBill.Rows[i].Cells[0].Value.ToString() == proId.ToString())
                {
                    x = true;
                    break;
                }
            }

            return x;
        }

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

        // check null values
        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();

            if (radioRawProducts.Checked == true)
            {
                if (comboUnit.SelectedIndex == -1)
                {
                    list.Add(new KeyValuePair<string, string>("Unit", ""));
                }
                else
                {
                    list.Add(new KeyValuePair<string, string>("Unit", comboUnit.Text.ToString()));
                }

            }

            if (comboSuppliers.SelectedIndex == -1)
            {
                list.Add(new KeyValuePair<string, string>("Suppliers", ""));
            }
            else
            {
                list.Add(new KeyValuePair<string, string>("Suppliers", comboSuppliers.SelectedValue.ToString()));
            }

            if (comboProName.SelectedIndex == -1)
            {
                list.Add(new KeyValuePair<string, string>("Product Name", ""));
            }
            else
            {
                list.Add(new KeyValuePair<string, string>("Product Name", comboProName.SelectedValue.ToString()));
            }

            return list;

        }

        //get stock input
        private db_stock getStockInput()
        {
            stk = new db_stock();
            stk.sup_id = int.Parse(comboSuppliers.SelectedValue.ToString());
            stk.created_by = userId;
            stk.created_date = DateTime.Now.ToString();
            return stk;
        }

        // get direct sell stock from grid
        private List<db_real_time_direct_sell_stock> getDirectSellStock()
        {
            // this data should get form grid view
            dss = new db_real_time_direct_sell_stock();
            List<db_real_time_direct_sell_stock> list = new List<db_real_time_direct_sell_stock>() ;
            for (int i = 0; i < gridBill.Rows.Count; i++)
            {
                if (gridBill.Rows[i].Cells[2].Value.ToString() == "1")
                {
                    dss.pro_id = int.Parse(gridBill.Rows[i].Cells[2].Value.ToString());
                    dss.qty = double.Parse(gridBill.Rows[i].Cells[4].Value.ToString());
                    list.Add(dss);
                }
                
            }
            return list;
        }

        // get raw stock from grid
        private List<db_real_time_raw_stock> getRawSellStock()
        {
            // this data should get form grid view
            rs = new db_real_time_raw_stock();
            List<db_real_time_raw_stock> list = new List<db_real_time_raw_stock>();
            for (int i = 0; i < gridBill.Rows.Count; i++)
            {
                if (gridBill.Rows[i].Cells[2].Value.ToString() == "2")
                {
                    rs.pro_id = int.Parse(gridBill.Rows[i].Cells[2].Value.ToString());
                    rs.qty = double.Parse(gridBill.Rows[i].Cells[4].Value.ToString());
                    rs.unit = gridBill.Rows[i].Cells[7].Value.ToString();
                    list.Add(rs);
                }
            }
            return list;
        }

        //get price input
        private db_price getPriceInput()
        {
            pri = new db_price();
            pri.pro_id = int.Parse(comboProName.SelectedValue.ToString());
            pri.selling_price = float.Parse(numSellingPrice.Value.ToString());
            pri.buying_price = float.Parse(numBuyingPrice.Value.ToString());
            pri.discount = float.Parse(numProDiscount.Value.ToString());

            return pri;

        }

        private void raw_sale_products_Load(object sender, EventArgs e)
        {
            // check default as direct sell products
            radioDirectSellProducts.Checked = true;
            fillProductNameCombo(1);

            // set enabled unit combo
            comboUnit.Enabled = false;

            // fill supplier combo
            fillSupNameCombo();

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            cm = new common_moduls();
            msg = new MessageClass();
            if (cm.check_null_data(nullValidateData()))
            {
                msg.requiredDataErr();
            }
            else
            {
                pri = new db_price();
                stk = new db_stock();
                msg = new MessageClass();
                pri = getPriceInput();
                stk = getStockInput();

                string proName = comboProName.Text.ToString();
                string unit = comboUnit.Text.ToString();

                if (string.IsNullOrEmpty(unit))
                {
                    unit = "Direct";
                }

                // check is data already exist in grid
                if (isDataExistInGrid(pri.pro_id))
                {
                    // add qty
                    for (int i = 0; i < gridBill.RowCount; i++)
                    {
                        if (gridBill.Rows[i].Cells[0].Value.ToString() == pri.pro_id.ToString())
                        {
                            decimal old_qty = decimal.Parse(gridBill.Rows[i].Cells[4].Value.ToString());
                            decimal new_qty = decimal.Parse(numQty.Value.ToString()) + old_qty;

                            gridBill.Rows[i].Cells[4].Value = new_qty.ToString(); // qty
                            gridBill.Rows[i].Cells[5].Value = pri.buying_price;  // buying price
                            gridBill.Rows[i].Cells[6].Value = numProDiscount.Value.ToString();
                            gridBill.Rows[i].Cells[7].Value = unit;
                            break;
                        }
                    }

                }
                else
                {
                    // set data to grid
                    string qty = numQty.Value.ToString();
                    string discount = numProDiscount.Value.ToString();
                    gridBill.Rows.Add(pri.pro_id, stk.sup_id, getSelectedStockCat(), proName, qty, pri.buying_price, discount, unit);
                }
            }
        }

        private void grid_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridBill.Rows[index];

                if (e.ColumnIndex.Equals(8))
                {
                    msg = new MessageClass();
                    if (msg.requestToDelete())
                    {
                        gridBill.Rows.RemoveAt(index);
                        index = 0;
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!comboSuppliers.SelectedValue.Equals(null) && !string.IsNullOrEmpty(txtInvNo.Text.ToString()))
            {

                sc = new StockClass();
                stk = new db_stock();
                rs = new db_real_time_raw_stock();
                dss = new db_real_time_direct_sell_stock();
                sic = new StockInvoiceClass();
                idss = new db_inv_direct_sell_stock();
                irs = new db_inv_raw_stock();
                db_stk_invoice inv = new db_stk_invoice();

                stk = getStockInput();

                // create stock id
                this.stockId = sc.saveStock(stk);

                // create invoice no
                
                inv.stk_id = this.stockId;
                inv.invoice_no = txtInvNo.Text.ToString();
                this.invId = sic.saveStockInv(inv);


                // check null data (Direct sell items and raw items)
                if (getDirectSellStock().Count > 0)
                {
                    // save direct sell product
                    List<db_real_time_direct_sell_stock> list = getDirectSellStock();
                    foreach (var item in list)
                    {
                        dss.pro_id = item.pro_id;
                        dss.qty = item.qty;
                        sc.saveDirectSellStock(dss);

                        idss.pro_id = item.pro_id;
                        idss.qty = item.qty;
                        idss.inv_id = this.invId;
                        sic.saveDirectSellStock(idss);

                    }
                    // save direct sell invoice product
                }

                if (getRawSellStock().Count > 0)
                {
                    // save raw product
                    List<db_real_time_raw_stock> list = getRawSellStock();
                    foreach (var item in list)
                    {
                        rs.pro_id = item.pro_id;
                        rs.qty = item.qty;
                        rs.unit = item.unit;
                        sc.saveRawStock(rs);

                        irs.pro_id = item.pro_id;
                        irs.qty = item.qty;
                        irs.inv_id = this.invId;
                        irs.unit = item.unit;
                        sic.saveRawStock(irs);
                    }
                }
            }
            else
            {
                msg = new MessageClass();
                msg.selectSupplierAndInvErr();
            }
            
        }

        private void radioRawProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRawProducts.Checked == true)
            {
                fillProductNameCombo(2);
            }
            // set enabled unit combo
            comboUnit.Enabled = true;
        }

        private void radioDirectSellProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDirectSellProducts.Checked == true)
            {
                fillProductNameCombo(1);
            }
            // set enabled unit combo
            comboUnit.Enabled = false;
        }


        public void clearAllInputs()
        {
            radioDirectSellProducts.Checked = true;
            fillProductNameCombo(1);
            lblProCode.Text = "Product Code";
            fillSupNameCombo();
            lblSupAddress.Text = "Supplier Address";
            lblSupMobile.Text = "Supplier Mobile";
            comboUnit.SelectedIndex = -1;
            numBuyingPrice.Value = decimal.Parse("0.00");
            numSellingPrice.Value = decimal.Parse("0.00");
            numProDiscount.Value = decimal.Parse("0.00");
            numQty.Value = decimal.Parse("0.00");
        }

        private void comboProName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!comboProName.Text.Equals(null))
            {
                int id = int.Parse(comboProName.SelectedValue.ToString());
                setProDetails(id);
                numQty.Value = decimal.Parse("0.00");
                
            }
        }

        private void comboSuppliers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.supplierId = int.Parse(comboSuppliers.SelectedValue.ToString());
            setSupDetails(supplierId);
        }

      
    }
}
