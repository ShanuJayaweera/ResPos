using res_pos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using res_pos.Model;
using res_pos.Classes;
using System.Data.Entity.Migrations.Sql;
using res_pos.SystemModules.Authentication;
using System.Text.RegularExpressions;
using res_pos.SystemModules.Dashboard;

namespace res_pos.SystemModules.Employee
{
    public partial class frmEmployee : MetroFramework.Forms.MetroForm, ICustomUI
    {
        public frmEmployee(int userId, string action)
        {
            InitializeComponent();
            this.userId = userId;
            _action(action);
        }

        db_employee emp;
        common_moduls cm;
        EmployeeClass ec;
        MessageClass msg;
        
        public string action { get; set; }
        public int empId { get; set; }
        public int userId { get; set; }

        public void _action(string action)
        {
            if (action == "add")
            {
                lbl_heading.Text = "Add New Employee";
                btnSave.Enabled = true;
                btn_add_employee.Visible = false;
                btnSave.Text = "Add Employee";
                this.action = "add";
                clearAllInputs();
                enableAllInputs();
            }
            if (action == "update")
            {
                lbl_heading.Text = "Update Employee";
                btnSave.Enabled = true;
                btnSave.Text = "Update Employee";
                btn_add_employee.Visible = true;
                this.action = "update";
                enableAllInputs();
                txtNic.Enabled = false;
            }
            if (action == "view")
            {
                lbl_heading.Text = "View Employee";
                btnSave.Enabled = false;
                btn_add_employee.Visible = true;
                this.action = "view";
                disableAllInputs();
            }
        }


        private db_employee getUserInput()
        {
            emp = new db_employee();
            emp.name = txtName.Text.ToString();
            emp.address = txtAddress.Text.ToString();
            emp.telephone = txtTelephone.Text.ToString();
            emp.nic = txtNic.Text.ToString();
            emp.mobile = txtMobile.Text.ToString();
            emp.email = txtEmail.Text.ToString();
            emp.emp_type = int.Parse(comboEmpType.SelectedValue.ToString());
            emp.created_date = DateTime.Now.ToString();
            emp.created_by = this.userId;
            return emp;
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("Name", txtName.Text));

            list.Add(new KeyValuePair<string, string>("Address", txtAddress.Text));
            list.Add(new KeyValuePair<string, string>("Telephone", txtTelephone.Text));
            list.Add(new KeyValuePair<string, string>("Nic", txtNic.Text));
            list.Add(new KeyValuePair<string, string>("Mobile", txtMobile.Text));
            list.Add(new KeyValuePair<string, string>("Email", txtEmail.Text));
            if (comboEmpType.SelectedIndex == -1)
            {
                list.Add(new KeyValuePair<string, string>("Emp Type", ""));
            }
            else
            {
                list.Add(new KeyValuePair<string, string>("Emp Type", comboEmpType.SelectedValue.ToString()));
            }
            return list;
        }


        public void clearAllInputs()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtNic.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            comboEmpType.SelectedItem = -1;
            comboSearchNic.Text = "Please choose an item";
        }


        public void disableAllInputs()
        {
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtMobile.Enabled = false;
            txtNic.Enabled = false;
            txtTelephone.Enabled = false;
            comboEmpType.Enabled = false;
        }

        public void enableAllInputs()
        {
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtMobile.Enabled = true;
            txtNic.Enabled = true;
            txtTelephone.Enabled = true;
            comboEmpType.Enabled = true;
        }

        private void fillEmpTypeCombos()
        {
            ec = new EmployeeClass();
            comboEmpType.DataSource = ec.getAllEmployeeTypeRecodes();
            comboEmpType.DisplayMember = "type_name";
            comboEmpType.ValueMember = "id";

            comboSearchEmpType.DataSource = ec.getAllEmployeeTypeRecodes();
            comboSearchEmpType.DisplayMember = "type_name";
            comboSearchEmpType.ValueMember = "id";
            comboSearchEmpType.Text = "Please choose an item";
        }

        private void fillNicCombo()
        {
            ec = new EmployeeClass();
            comboSearchNic.DataSource = ec.getAllEmployeeRecodes();
            comboSearchNic.DisplayMember = "nic";
            comboSearchNic.ValueMember = "nic";
            comboSearchNic.Text = "Please choose an item";
        }


        public void fillGridView()
        {
            ec = new EmployeeClass();
            gridEmployee.DataSource = ec.getAllEmployeeRecodes();
        }

        public void setDataToFields(int id)
        {
            ec = new EmployeeClass();
            var list = ec.getEmployeeRecodeById(id);
            foreach (var emp in list)
            {
                txtName.Text = emp.name;
                txtAddress.Text = emp.address;
                txtEmail.Text = emp.email;
                txtMobile.Text = emp.mobile;
                txtNic.Text = emp.nic;
                txtTelephone.Text = emp.telephone;
                comboEmpType.SelectedValue = emp.emp_type;
            }
        }

        public void search()
        {
            if (comboSearchEmpType.Text == "Please choose an item" && comboSearchNic.Text == "Please choose an item")
            {
                // clear state
                fillGridView();
            }
            else if (comboSearchEmpType.Text != "Please choose an item")
            {
                ec = new EmployeeClass();
                gridEmployee.DataSource = ec.searchByEmpType(int.Parse(comboSearchEmpType.SelectedValue.ToString()));
            }
            else if (comboSearchNic.Text != "Please choose an item")
            {
                // only nic state
                ec = new EmployeeClass();
                gridEmployee.DataSource = ec.searchByNic(comboSearchNic.SelectedValue.ToString());
            }
            else
            {
                // both nic and emp type
                ec = new EmployeeClass();
                gridEmployee.DataSource = ec.searchByNicAndEmpType(int.Parse(comboSearchEmpType.SelectedValue.ToString()), comboSearchNic.SelectedValue.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cm = new common_moduls();
            msg = new MessageClass();
            
            if (cm.check_null_data(nullValidateData()).Equals(false))
            {
                if (this.action == "add")
                {
                    ec = new EmployeeClass();
                    emp = new db_employee();
                    emp = getUserInput();

                    string respond = ec.empSaveProcess(emp);
                    string regEx = @"\d";
                    Regex re = new Regex(regEx);

                    if (respond.Equals("exist"))
                    {
                        msg.recodeExistErr();

                    }
                    else if (re.IsMatch(respond))
                    {
                        msg.recodeInsertSuccess();
                        frmRegUser ru = new frmRegUser(int.Parse(respond), emp.name);
                        ru.Show();
                        this.Hide();
                    }
                    else
                    {
                        msg.ExceptionErr(respond);
                    }

                }
                if (this.action.Equals("update"))
                {

                    ec = new EmployeeClass();
                    emp = new db_employee();
                    emp = getUserInput();
                    emp.Id = empId; // set employee id

                    string respond = ec.empUpdateProcess(emp);
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

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // fill emp type combos
            fillEmpTypeCombos();

            // fill nic combo
            fillNicCombo();

            // fill grid view
            fillGridView();
        }

        private void gridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridEmployee.Rows[index];
                string id = selected_row.Cells[0].Value.ToString(); // this is emp id

                msg = new MessageClass();
                if (e.ColumnIndex.Equals(5))
                {
                    if (msg.requestToUpdate())
                    {
                        setDataToFields(Convert.ToInt32(id));
                        this.empId = Convert.ToInt32(id);
                        _action("update");
                    }
                }
                else
                {
                    if (msg.requestToView())
                    {
                        setDataToFields(Convert.ToInt32(id));
                        this.empId = Convert.ToInt32(id);
                        _action("view");
                    }
                   
                }

            }
        }

        private void comboSearchEmpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void comboSearchNic_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            comboSearchNic.Text = "Please choose an item";
            comboSearchEmpType.Text = "Please choose an item";
            fillGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBasicDataDashboard bd = new frmBasicDataDashboard(this.userId);
            bd.Show();
            this.Hide();
        }
    }
}
