using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.Classes;
using res_pos.Model;
using res_pos.SystemModules.Dashboard;


namespace res_pos
{
    public partial class frmProCat : MetroFramework.Forms.MetroForm 
    {
        public frmProCat(int userId, string action)
        {
            InitializeComponent();
            set_branch_id();
            this.action = action;
            this.userId = userId;
        }


        MessageClass msg; // this class for show messages
        ProductCategoryClass pcc; // product category class
        db_pro_category pe; // product category entity
        common_moduls cm; // common modules

        public string branch_id { get; set; }
        public string action { get; set; }
        public int userId { get; set; }
        public int catId { get; set; } // current category id

        private void _action(string action)
        {
            if (action == "add")
            {
                lbl_heading.Text = "Add New Product Category";
                btn_save.Enabled = true;
                btn_save.Text = "Add Category";
                this.action = "add";
                clearAllFields();
                enableAllFields();
                btn_add_cat.Visible = false;
            }
            if (action == "update")
            {
                lbl_heading.Text = "Update New Product Category";
                btn_save.Enabled = true;
                btn_save.Text = "Update Category";
                this.action = "update";
                enableAllFields();
                btn_add_cat.Visible = true;
            }
            if (action == "view")
            {
                lbl_heading.Text = "View Product Category";
                btn_save.Enabled = false;
                this.action = "view";
                disableAllFields();
                btn_add_cat.Visible = true;
            }
        }

        private void set_branch_id()
        {
            common_moduls c = new common_moduls();
            this.branch_id = c.return_branch_id().ToString();
        }

        private List<KeyValuePair<string, string>> requiredData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("Category Name", txtCatName.Text));
            return list;
        }

        private db_pro_category getUserInput()
        {
            pe = new db_pro_category();
            pe.cat_name = txtCatName.Text;
            pe.created_date = DateTime.Now.ToString();
            pe.created_by = userId; // Current user
            return pe;

        }

        private void clearAllFields()
        {
            txtCatName.Text = string.Empty;
        }

        private void enableAllFields()
        {
            txtCatName.ReadOnly = false;
        }

        private void disableAllFields()
        {
            txtCatName.ReadOnly = true;
        }

        private void fillGridView()
        {
            pcc = new ProductCategoryClass();
            List<db_pro_category> list = pcc.getAllRecodes();
            this.gridProCat.Rows.Clear();
            foreach (var item in list)
            {
                this.gridProCat.Rows.Add(item.Id, item.cat_name);
            }
        }

        private void product_category_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void setDataToFields(int id)
        {
            pcc = new ProductCategoryClass();
            List<db_pro_category> list = pcc.getRecodeById(id);

            foreach (var cat in list)
            {
                txtCatName.Text = cat.cat_name;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            cm = new common_moduls();
            msg = new MessageClass();

            if (cm.validateRequiredData(requiredData()))
            {
                msg.requiredDataErr(); // Message from MessageClass
            }
            else
            {
                
                if (this.action.Equals("add"))
                {
                    pe = getUserInput(); // Get user input
                    string respond = pcc.insertProductCategory(pe); // insert product category
                    if (respond.Equals("exist"))
                    {
                        msg.recodeExistErr(); // Message from MessageClass
                    }
                    else if (respond.Equals("done"))
                    {
                        //msg.recodeInsertSuccess();
                        fillGridView();
                        clearAllFields();
                    }
                }

                if (this.action.Equals("update"))
                {
                    pe = getUserInput(); // Get user input
                    pe.Id = catId;
                    string respond = pcc.updateProductCategory(pe); // insert product category
                    if (respond.Equals("not_exist"))
                    {
                        msg.recodeNotExistErr(); // Message from MessageClass
                    }
                    else if (respond.Equals("exist"))
                    {
                        msg.recodeExistErr(); // Message from MessageClass
                    }
                    else if (respond.Equals("done"))
                    {
                        fillGridView();
                        _action("add");
                    }
                }

            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (!action.Equals("view"))
            {
                clearAllFields();
            }
        }

        private void grid_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridProCat.Rows[index];
                string id = selected_row.Cells[0].Value.ToString();
                msg = new MessageClass();

                if (e.ColumnIndex.Equals(2))
                {
                    if (msg.requestToUpdate())
                    {
                        _action("update");
                        setDataToFields(Convert.ToInt32(id));
                        this.catId = Convert.ToInt32(id);
                    }
                    
                }
                else if (e.ColumnIndex.Equals(3))
                {
                    if (msg.requestToDelete())
                    {
                        pcc = new ProductCategoryClass();
                        pcc.deleteRecode(Convert.ToInt32(id));
                        fillGridView();
                    }

                }
                else
                {
                    // view the recode
                    _action("view");
                    setDataToFields(Convert.ToInt32(id));
                    this.catId = Convert.ToInt32(id);
                }
            }
        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            _action("add");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBasicDataDashboard bd = new frmBasicDataDashboard(this.userId);
            bd.Show();
            this.Hide();
        }
    }
}
