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


namespace res_pos.SystemModules.Product
{
    public partial class frmPrice : MetroFramework.Forms.MetroForm , ICustomUI
    {
        public frmPrice(int userId, string action)
        {
            InitializeComponent();

            _action(action);
            this.userId = userId;
        }

        db_price price;
        PriceClass pc;
        MessageClass msg;

        public string action { get; set; }
        public int userId { get; set; }

        public void _action(string action)
        {
            if (action == "update")
            {
                lbl_heading.Text = "Update Product Price";
                btn_save.Enabled = true;
                this.action = "update";
                enableAllInputs();
            }

            if (action == "view")
            {
                lbl_heading.Text = "View Product Price";
                btn_save.Enabled = false;
                this.action = "view";
                disableAllInputs();
            }
        }

        
        public void clearAllInputs()
        {
            numBuyingPrice.Value = decimal.Parse("0.00");
            numSellingPrice.Value = decimal.Parse("0.00");
            comboProName.SelectedIndex = -1;

        }

        public void disableAllInputs()
        {
            comboProName.Enabled = false;
            numSellingPrice.Enabled = false;
            numBuyingPrice.Enabled = false;
            panelStockCat.Enabled = false;
        }

        public void enableAllInputs()
        {
            comboProName.Enabled = false;
            numSellingPrice.Enabled = true;
            numBuyingPrice.Enabled = true;
            panelStockCat.Enabled = false;
        }

        public void fillGridView()
        {
            pc = new PriceClass();

            List<db_price> list = pc.getAllRecodes();
            this.gridPrice.Rows.Clear();
            foreach (var item in list)
            {
                this.gridPrice.Rows.Add(item.Id, item.db_product.pro_name, item.buying_price, item.selling_price);
            }
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            throw new NotImplementedException();
        }

        public void search()
        {
            throw new NotImplementedException();
        }

        public db_price getUserInput()
        {
            price = new db_price();
            price.pro_id = int.Parse(comboProName.SelectedValue.ToString());
            price.buying_price = double.Parse(numBuyingPrice.Value.ToString());
            price.selling_price = double.Parse(numSellingPrice.Value.ToString());
            return price;
            
        }

        public void fillProductNameCombo(int stockCat)
        {
            ProductClass pro = new ProductClass();
            comboProName.DataSource = pro.getProductByStockCat(stockCat);
            comboProName.DisplayMember = "pro_name";
            comboProName.ValueMember = "id";
        }

        public void setProCode()
        {
            ProductClass pro = new ProductClass();
            if (comboProName.SelectedIndex != -1)
            {
                int id = int.Parse(comboProName.SelectedValue.ToString());
                string proCode = pro.getProCodeById(id);
                lblProCode.Text = proCode;
            }
            
        }

        public void setDataToFields(int id)
        {
            pc = new PriceClass();
            List<db_price> list = pc.getRecodeById(id);

            foreach (var item in list)
            {
                comboProName.SelectedValue = item.db_product.Id;
                lblProCode.Text = item.db_product.pro_code;
                numBuyingPrice.Value = decimal.Parse(item.buying_price.ToString());
                numSellingPrice.Value = decimal.Parse(item.selling_price.ToString());

                if (item.db_product.stock_cat_id.Equals(2))
                {
                    radioRawProducts.Checked = true;
                }

                if (item.db_product.stock_cat_id.Equals(1))
                {
                    radioDirectSellProducts.Checked = true;
                }
            }
        }

        private void frmPrice_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void comboProName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioDirectSellProducts.Checked == true || radioRawProducts.Checked == true)
            {
                setProCode();
            }
            else
            {
                msg = new MessageClass();
                msg.selectCatErr();
            }
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            msg = new MessageClass();
            pc = new PriceClass();
            price = new db_price();
            price = getUserInput();
            if (pc.saveProcess(price).Equals("done"))
            {
                msg.recodeUpdateSuccess();
                fillGridView();
                clearAllInputs();
            }
            else
            {
                msg.recodeNotExistErr();
            }
        }

        private void gridPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridPrice.Rows[index];
                string id = selected_row.Cells[0].Value.ToString();
                msg = new MessageClass();

                if (e.ColumnIndex.Equals(4))
                {
                    if (msg.requestToUpdate())
                    {
                        _action("update");
                        setDataToFields(Convert.ToInt32(id));
                    }

                }
                else
                {
                    // view the recode
                    _action("view");
                    setDataToFields(Convert.ToInt32(id));
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAllInputs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBasicDataDashboard bd = new frmBasicDataDashboard(this.userId);
            bd.Show();
            this.Hide();
        }
    }
}
