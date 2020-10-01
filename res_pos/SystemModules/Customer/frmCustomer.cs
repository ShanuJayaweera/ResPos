using res_pos.Classes;
using res_pos.Interfaces;
using res_pos.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using res_pos.SystemModules.Dashboard;

namespace res_pos.SystemModules.Customer
{
    public partial class frmCustomers : MetroFramework.Forms.MetroForm, ICustomUI
    {
        public frmCustomers(int userId, string action)
        {
            InitializeComponent();
            _action(action);
            this.userId = userId;
        }

        public string action { get; set; }
        public int userId { get; set; }
        public int cusIdProp { get; set; }

        CustomerClass cc;
        common_moduls cm;
        db_customer cus;
        MessageClass msg;

        public void fillCustomerTypeCombos()
        {
            cc = new CustomerClass();
            List<db_cus_type> list = cc.getAllCustomerTypeRecodes();
            comboCusType.DataSource = list;
            comboCusType.DisplayMember = "type_name";
            comboCusType.ValueMember = "id";

            comboSearchCusType.DataSource = list;
            comboSearchCusType.DisplayMember = "type_name";
            comboSearchCusType.ValueMember = "id";

        }

        public void fillSearchNicCombos()
        {
            cc = new CustomerClass();
            List<db_customer> list = cc.getAllCustomerRecodes();
            comboSearchNic.DataSource = list;
            comboSearchNic.DisplayMember = "nic";
            comboSearchNic.ValueMember = "nic";
        }


        public void clearAllInputs()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtNic.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            comboCusType.SelectedItem = -1;
        }

        public void disableAllInputs()
        {
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtMobile.Enabled = false;
            txtNic.Enabled = false;
            txtTelephone.Enabled = false;
            //txt_barcode.Enabled = true;
            comboCusType.Enabled = false;
        }

        public void enableAllInputs()
        {
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtMobile.Enabled = true;
            txtNic.Enabled = true;
            txtTelephone.Enabled = true;
            //txt_barcode.Enabled = true;
            comboCusType.Enabled = true;
        }

        public void fillGridView()
        {
            cc = new CustomerClass();
            List<db_customer> list = cc.getAllCustomerRecodes();
            foreach (var item in list)
            {
                this.gridCustomer.Rows.Add(item.Id, item.name, item.nic, item.mobile, item.db_cus_type.type_name);
            }
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("name", txtName.Text));
            list.Add(new KeyValuePair<string, string>("address", txtAddress.Text));
            list.Add(new KeyValuePair<string, string>("nic", txtNic.Text));
            list.Add(new KeyValuePair<string, string>("mobile", txtMobile.Text));
            if (comboCusType.SelectedIndex == -1)
            {
                list.Add(new KeyValuePair<string, string>("cus_type", ""));
            }
            else
            {
                list.Add(new KeyValuePair<string, string>("cus_type", comboCusType.SelectedValue.ToString()));
            }
            return list;
        }

        public void search()
        {
            throw new NotImplementedException();
        }

        public void setDataToFields(int id)
        {
            cc = new CustomerClass();
            var data = cc.getCustomerRecodeById(id);
            foreach (var item in data)
            {
                txtName.Text = item.name;
                txtAddress.Text = item.address;
                txtNic.Text = item.nic;
                txtEmail.Text = item.email;
                txtMobile.Text = item.mobile;
                txtTelephone.Text = item.telephone;
                comboCusType.SelectedItem = item.cusType;
            }
        }

        public void _action(string action)
        {
            if (action == "add")
            {
                lbl_heading.Text = "Add New Customer";
                btnSave.Enabled = true;
                btn_add_customer.Visible = false;
                this.action = "add";
                clearAllInputs();
                enableAllInputs();
            }
            if (action == "update")
            {
                lbl_heading.Text = "Update Customer";
                btnSave.Enabled = true;
                btn_add_customer.Visible = true;
                this.action = "update";
                enableAllInputs();
                txtNic.Enabled = false;
            }
            if (action == "view")
            {
                lbl_heading.Text = "View Customer";
                btnSave.Enabled = false;
                btn_add_customer.Visible = true;
                this.action = "view";
                disableAllInputs();
            }
        }

        private db_customer getUserInput()
        {
            cus = new db_customer();
            cus.name = txtName.Text.ToString();
            cus.address = txtAddress.Text.ToString();
            cus.telephone = txtTelephone.Text.ToString();
            cus.nic = txtNic.Text.ToString();
            cus.mobile = txtMobile.Text.ToString();
            cus.email = txtEmail.Text.ToString();
            cus.cusType = int.Parse(comboCusType.SelectedValue.ToString());
            cus.createdDate = DateTime.Now.ToString();
            cus.createdBy = this.userId;
            return cus;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // fill customer type combos
            fillCustomerTypeCombos();

            //fill grid view
            fillGridView();

            // fill search combos
            fillSearchNicCombos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cm = new common_moduls();
            msg = new MessageClass();

            if (cm.check_null_data(nullValidateData()).Equals(false))
            {
                if (this.action == "add")
                {
                    cc = new CustomerClass();
                    cus = new db_customer();
                    cus = getUserInput();
                    string respond = cc.cusSaveProcess(cus);

                    if (respond.Equals("exist"))
                    {
                        msg.recodeExistErr();

                    }
                    else if (respond.Equals("done"))
                    {
                        msg.recodeInsertSuccess();
                        fillGridView();
                        fillSearchNicCombos();
                        clearAllInputs();

                    }
                    else
                    {
                        msg.ExceptionErr(respond);
                    }

                }
                if (this.action.Equals("update"))
                {

                    cc = new CustomerClass();
                    cus = new db_customer();
                    cus = getUserInput();
                    cus.Id = this.cusIdProp; // set customer id

                    string respond = cc.cusUpdateProcess(cus);
                    if (respond.Equals("done"))
                    {
                        msg.recodeUpdateSuccess();
                        clearAllInputs();
                        fillGridView();
                        enableAllInputs();
                    }
                    else if (respond.Equals("not_exist"))
                    {
                        msg.recodeNotExistErr();
                    }
                    else
                    {
                        msg.ExceptionErr(respond);
                    }
                }
            }
            else
            {
                msg.requiredDataErr();
            }
        }

        private void gridCustomer_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridCustomer.Rows[index];
                string id = selected_row.Cells[0].Value.ToString(); // this is cus id

                msg = new MessageClass();
                if (e.ColumnIndex.Equals(5))
                {
                    if (msg.requestToUpdate())
                    {
                        setDataToFields(Convert.ToInt32(id));
                        this.cusIdProp = Convert.ToInt32(id);
                        _action("update");
                    }
                }
                else
                {
                    if (msg.requestToView())
                    {
                        setDataToFields(Convert.ToInt32(id));
                        this.cusIdProp = Convert.ToInt32(id);
                        _action("view");
                    }

                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBasicDataDashboard bd = new frmBasicDataDashboard(this.userId);
            bd.Show();
            this.Hide();
        }
    }
}
