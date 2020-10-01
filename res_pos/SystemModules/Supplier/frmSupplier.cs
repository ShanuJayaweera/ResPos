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

namespace res_pos.SystemModules.Supplier
{
    public partial class frmSupplier : MetroFramework.Forms.MetroForm, ICustomUI
    {
        public frmSupplier(int userId, string action)
        {
            InitializeComponent();
            _action(action);
            this.userId = userId;
        }

        public string action { get; set; }
        public int userId { get; set; }
        public int supId { get; set; }

        db_supplier sup;
        common_moduls cm;
        MessageClass msg;
        SupplierClass sc;


        public void clearAllInputs()
        {
            txt_supplier_name.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_mobile.Text = string.Empty;
            txtTP.Text = string.Empty;
        }

        public void disableAllInputs()
        {
            txt_supplier_name.ReadOnly = true;
            txt_address.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_mobile.ReadOnly = true;
            txtTP.ReadOnly = true;
        }

        public void enableAllInputs()
        {
            txt_supplier_name.ReadOnly = false;
            txt_address.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_mobile.ReadOnly = false;
            txtTP.ReadOnly = false;
        }

        private db_supplier get_user_input()
        {
            sup = new db_supplier();
            sup.sup_name = txt_supplier_name.Text.ToString();
            sup.sup_address = txt_address.Text.ToString();
            sup.sup_mobile = txt_mobile.Text.ToString();
            sup.sup_email = txt_email.Text.ToString();
            sup.sup_telephone = txtTP.Text.ToString();
            sup.created_date = DateTime.Now.ToString();
            sup.created_date = this.userId.ToString();
            return sup;

        }

        public void fillGridView()
        {
            sc = new SupplierClass();

            List<db_supplier> list = sc.getAllRecodes();
            this.gridSupplier.Rows.Clear();
            foreach (var item in list)
            {
                this.gridSupplier.Rows.Add(item.Id, item.sup_name, item.sup_address, item.sup_mobile);
            }
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("name", txt_supplier_name.Text));
            list.Add(new KeyValuePair<string, string>("address", txt_address.Text));
            list.Add(new KeyValuePair<string, string>("mobile", txt_mobile.Text));

            return list;
        }

        public void search()
        {
            throw new NotImplementedException();
        }

        public void setDataToFields(int id)
        {
            sc = new SupplierClass();
            List<db_supplier> list = sc.getRecodeById(id);
            foreach (var item in list)
            {
                txt_supplier_name.Text = item.sup_name;
                txt_mobile.Text = item.sup_mobile;
                txt_email.Text = item.sup_email;
                txt_address.Text = item.sup_address;
                txtTP.Text = item.sup_telephone;

            }
        }

        public void _action(string action)
        {
            if (action == "add")
            {
                lbl_heading.Text = "Add New Supplier";
                btn_save.Enabled = true;
                btnAddSupplier.Visible = false;
                btn_save.Text = "Add Supplier";
                this.action = "add";
                clearAllInputs();
                enableAllInputs();
            }
            if (action == "update")
            {
                lbl_heading.Text = "Update Supplier";
                btn_save.Enabled = true;
                btn_save.Text = "Update Supplier";
                btnAddSupplier.Visible = true;
                this.action = "update";
                enableAllInputs();
            }
            if (action == "view")
            {
                lbl_heading.Text = "View Supplier";
                btn_save.Enabled = false;
                btnAddSupplier.Visible = true;
                this.action = "view";
                disableAllInputs();
            }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            fillGridView();
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
                if (action == "add")
                {
                    sc = new SupplierClass();
                    sup = get_user_input();
                    if (sc.insertSupplier(sup).Equals("done"))
                    {
                        msg.recodeInsertSuccess();
                        fillGridView();
                        clearAllInputs();
                    }


                }
                if (action == "update")
                {
                    sc = new SupplierClass();
                    sup = get_user_input();
                    sup.Id = supId;
                    if (sc.updateSupplier(sup).Equals("done"))
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
                

            }

        }

        private void gridSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridSupplier.Rows[index];
                string id = selected_row.Cells[0].Value.ToString();
                msg = new MessageClass();

                if (e.ColumnIndex.Equals(4))
                {
                    if (msg.requestToUpdate())
                    {
                        _action("update");
                        setDataToFields(Convert.ToInt32(id));
                        this.supId = Convert.ToInt32(id);
                    }
                }
                else
                {
                    // view the recode
                    _action("view");
                    setDataToFields(Convert.ToInt32(id));
                    this.supId = Convert.ToInt32(id);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (action.Equals("add"))
            {
                clearAllInputs();
                enableAllInputs();
            }
            
        }


        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            _action("add");
        }
    }
}
