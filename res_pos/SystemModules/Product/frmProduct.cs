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
using res_pos.Interfaces;
using res_pos.Model;
using res_pos.SystemModules.Dashboard;

namespace res_pos
{
    public partial class frmProduct : MetroFramework.Forms.MetroForm , ICustomUI
    {
        public frmProduct(int userId ,string action)
        {
            InitializeComponent();
            _action(action);
            this.userId = userId;
        }

        common_moduls cm;
        MessageClass msg;
        ProductClass pro;
        db_product p;
        db_price price;

        public int userId { get; set; }
        public int productId { get; set; }
        public string action { get; set ; }

        private void frm_item_category_Load(object sender, EventArgs e)
        {
            fillStockCatCombo();
            fillGridView();
            fillProCodeCombo();
            fillProductCatCombo();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cm = new common_moduls();
            msg = new MessageClass();

            if (cm.check_null_data(nullValidateData()))
            {
                msg.requiredDataErr();
            }
            else
            {
                if (this.action.Equals("add"))
                {
                    pro = new ProductClass();
                    p = new db_product();
                    price = new db_price();
                    price = getUserPriceInput();
                    p = getUserInput();

                    

                    string respond = pro.saveProcess(p, price);
                    if (respond.Equals("exist"))
                    {
                        msg.recodeExistErr();
                    }
                    else if (respond.Equals("not_exist"))
                    {
                        msg.recodeNotExistErr();
                    }
                    else
                    {
                        //msg.recodeInsertSuccess();
                        fillGridView();
                        fillProCodeCombo(); // search combo
                        clearAllInputs();
                    }
                }


                if (this.action.Equals("update"))
                {
                    pro = new ProductClass();
                    p = new db_product();
                    p = getUserInput();
                    p.Id = productId;

                    

                    string respond = pro.updateProduct(p);
                    if (respond.Equals("not_exist"))
                    {
                        msg.recodeNotExistErr();
                    }
                    else
                    {
                        //msg.recodeUpdateSuccess();
                        fillGridView();
                        clearAllInputs();
                        _action("add");
                    }
                }
            }
        }

        

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            _action("add");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (this.action.Equals("add"))
            {
                clearAllInputs();
            }
        }


        private void view_all_Click(object sender, EventArgs e)
        {
            fillGridView();
        }

        public void fillProCodeCombo()
        {
            pro = new ProductClass();
            comboSearchProductCode.DataSource = pro.getAllRecodes();
            comboSearchProductCode.DisplayMember = "pro_code";
            comboSearchProductCode.ValueMember = "Id";
        }

        public void fillStockCatCombo()
        {
            StockCategoryClass scc = new StockCategoryClass();
            comboStockCat.DataSource = scc.getAllRecodes();
            comboStockCat.DisplayMember = "cat_name";
            comboStockCat.ValueMember = "Id";
            
        }

        public void fillProductCatCombo()
        {
            ProductCategoryClass pcc = new ProductCategoryClass();

            comboProCat.DataSource = pcc.getAllRecodes();
            comboProCat.DisplayMember = "cat_name";
            comboProCat.ValueMember = "Id";

        }

        public void enableAllInputs()
        {
            txtBarcode.ReadOnly = false;
            txtProCode.ReadOnly = false;
            txtName.ReadOnly = false;
            comboProCat.Enabled = true;
            comboStockCat.Enabled = true;
            numDiscount.Enabled = true;
            numSellingPrice.Enabled = true;
            numBuyingPrice.Enabled = true;
        }

        public void disableAllInputs()
        {
            txtBarcode.ReadOnly = true;
            txtProCode.ReadOnly = true;
            txtName.ReadOnly = true;
            comboProCat.Enabled = false;
            comboStockCat.Enabled = false;
            numDiscount.Enabled = false;
            numSellingPrice.Enabled = false;
            numBuyingPrice.Enabled = false;
        }

        public db_product getUserInput()
        {
            p = new db_product();
            p.pro_name = txtName.Text.ToString();
            p.pro_code = txtProCode.Text.ToString();
            p.pro_barcode = txtBarcode.Text.ToString();
            p.pro_cat_id = int.Parse(comboProCat.SelectedValue.ToString());
            p.stock_cat_id = int.Parse(comboStockCat.SelectedValue.ToString());
            p.created_date = DateTime.Now.ToString();
            p.created_by = this.userId;
            return p;
        }

        private db_price getUserPriceInput()
        {
            price = new db_price();
            price.buying_price = double.Parse(numBuyingPrice.Value.ToString());
            price.selling_price = double.Parse(numSellingPrice.Value.ToString());
            price.discount = double.Parse(numDiscount.Value.ToString());
            return price;
        }


        public void clearAllInputs()
        {
            txtBarcode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtProCode.Text = string.Empty;
            comboProCat.SelectedIndex = -1;
            comboStockCat.SelectedIndex = -1;

            numBuyingPrice.Value = decimal.Parse("0.00");
            numSellingPrice.Value = decimal.Parse("0.00");
            numDiscount.Value = decimal.Parse("0.00");
            
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("pro_name", txtName.Text));

            list.Add(new KeyValuePair<string, string>("pro_code", txtProCode.Text));
            list.Add(new KeyValuePair<string, string>("pro_barcode", txtBarcode.Text));

            return list;
        }

        public void fillGridView()
        {
            pro = new ProductClass();

            List<db_product> list = pro.getAllRecodes();
            this.gridPro.Rows.Clear();
            foreach (var item in list)
            {
                this.gridPro.Rows.Add(item.Id, item.pro_code, item.pro_name, item.db_pro_category.cat_name, item.db_stock_cat.cat_name);
            }
        }

        public void setDataToFields(int id)
        {
            pro = new ProductClass();
            List<db_product> list = pro.getRecodeById(id);
            foreach (var item in list)
            {
                txtProCode.Text = item.pro_code;
                txtBarcode.Text = item.pro_barcode;
                txtName.Text = item.pro_name;
                comboProCat.SelectedValue = item.pro_cat_id;
                comboStockCat.SelectedValue = item.stock_cat_id;

            }
        }

        public void search()
        {
            pro = new ProductClass();
            string code = comboSearchProductCode.SelectedText.ToString();
            List<db_product> list = pro.searchRecodeByProCode(code);
            this.gridPro.Rows.Clear();
            foreach (var item in list)
            {
                this.gridPro.Rows.Add(item.Id, item.pro_code, item.pro_name, item.db_pro_category.cat_name, item.db_stock_cat.cat_name);
            }
        }

        public void _action(string action)
        {
            if (action == "add")
            {
                lbl_heading.Text = "Add New Product";
                btn_save.Enabled = true;
                this.action = "add";
                clearAllInputs();
                enableAllInputs();
                btn_add_item.Visible = false;

                numBuyingPrice.Visible = true;
                numSellingPrice.Visible = true;
                numDiscount.Visible = true;
                lblPrice.Visible = true;
            }
            if (action == "update")
            {
                lbl_heading.Text = "Update New Product";
                btn_save.Enabled = true;
                this.action = "update";
                enableAllInputs();
                btn_add_item.Visible = true;

                // remove price
                numBuyingPrice.Visible = false;
                numSellingPrice.Visible = false;
                numDiscount.Visible = false;
                lblPrice.Visible = false;
            }
            if (action == "view")
            {
                lbl_heading.Text = "View Product";
                btn_save.Enabled = false;
                this.action = "view";
                disableAllInputs();
                btn_add_item.Visible = true;
            }
        }

        private void gridPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridPro.Rows[index];
                string id = selected_row.Cells[0].Value.ToString();
                msg = new MessageClass();

                if (e.ColumnIndex.Equals(5))
                {
                    if (msg.requestToUpdate())
                    {
                        _action("update");
                        setDataToFields(Convert.ToInt32(id));
                        this.productId = Convert.ToInt32(id);
                        txtProCode.ReadOnly = true;
                        txtBarcode.ReadOnly = true;
                    }

                }
                
                else
                {
                    // view the recode
                    _action("view");
                    setDataToFields(Convert.ToInt32(id));
                    this.productId = Convert.ToInt32(id);
                }
            }
        }

        private void comboSearchProductCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            search();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBasicDataDashboard bd = new frmBasicDataDashboard(this.userId);
            bd.Show();
            this.Hide();
        }
    }
}
