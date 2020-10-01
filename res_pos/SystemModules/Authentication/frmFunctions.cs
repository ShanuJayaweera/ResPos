using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.Interfaces;
using res_pos.Classes;
using res_pos.Model;
using res_pos.Classes.AuthClasess;
using res_pos.SystemModules.Dashboard;

namespace res_pos.SystemModules.Authentication
{
    public partial class frmFunctions : MetroFramework.Forms.MetroForm, ICustomUI
    {
        public frmFunctions(int userId, string action)
        {
            InitializeComponent();
            this.userId = userId;
            _action(action);
        }

        FunctionClass fc;
        auth_functions af;
        MessageClass msg;
        common_moduls cm;
        FormClass forms;

        public string action { get; set; }
        public int userId { get; set; }
        public int funcId { get; set; }

        public void _action(string action)
        {
            if (action == "add")
            {
                lbl_heading.Text = "Add New Function";
                btnSave.Enabled = true;
                this.action = "add";
                clearAllInputs();
                enableAllInputs();
                btnAdd.Visible = false;
            }
            if (action == "update")
            {
                lbl_heading.Text = "Update Function";
                btnSave.Enabled = true;
                this.action = "update";
                enableAllInputs();
                btnAdd.Visible = true;
            }
        }

        private void fillFormCombo()
        {
            forms = new FormClass();
            sysformsBindingSource.DataSource = forms.getAllRecodes();
        }

        public void clearAllInputs()
        {
            txtFuncName.Text = string.Empty;
            comboFormName.SelectedIndex = -1;
        }

        public void enableAllInputs()
        {
            txtFuncName.Enabled = true;
            comboFormName.Enabled = true;
        }

        public void disableAllInputs()
        {
            txtFuncName.Enabled = false;
            comboFormName.Enabled = false;
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("Function Name", txtFuncName.Text));
            if (comboFormName.SelectedIndex != -1)
            {
                list.Add(new KeyValuePair<string, string>("Form Name", comboFormName.SelectedValue.ToString()));
            }
            else
            {
                list.Add(new KeyValuePair<string, string>("Form Name",""));
            }
            return list;
        }

        public void setDataToFields(int id)
        {
            fc = new FunctionClass();
            var data = fc.getRecodeById(id);
            foreach (var item in data)
            {
                txtFuncName.Text = item.func_name;
                comboFormName.SelectedValue = item.form_id;
            }
        }

        public void search()
        {
            throw new NotImplementedException();
        }

        public void fillGridView()
        {
            fc = new FunctionClass();
            gridFunc.DataSource = fc.getAllRecodes();
        }

        private auth_functions getDataFromFields()
        {
            af = new auth_functions();
            af.func_name = txtFuncName.Text.ToString();
            af.form_id = int.Parse(comboFormName.SelectedValue.ToString());
            return af;
        }

        private void frmFunctions_Load(object sender, EventArgs e)
        {
            fillGridView();
            fillFormCombo();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            msg = new MessageClass();
            cm = new common_moduls();
            if (cm.check_null_data(nullValidateData()))
            {
                msg.requiredDataErr();
            }
            else
            {
                if (this.action == "add")
                {
                    fc = new FunctionClass();
                    af = new auth_functions();
                    af = getDataFromFields();
                    string respond = fc.saveProcess(af);

                    if (respond.Equals("done"))
                    {
                        msg.recodeInsertSuccess();
                        fillGridView();
                        clearAllInputs();
                    }
                    else if (respond.Equals("exist"))
                    {
                        msg.recodeExistErr();
                    }
                    else
                    {
                        msg.ExceptionErr(respond);
                    }
                }

                if (this.action == "update")
                {
                    fc = new FunctionClass();
                    af = new auth_functions();
                    af = getDataFromFields();
                    af.Id = funcId;
                    string respond = fc.updateFunc(af);
                    if (respond.Equals("done"))
                    {
                        msg.recodeUpdateSuccess();
                        fillGridView();
                        clearAllInputs();
                        _action("add");
                    }
                    else if (respond.Equals("exist"))
                    {
                        msg.recodeExistErr();
                    }
                    else
                    {
                        msg.ExceptionErr(respond);
                    }
                }
            }
        }

        private void gridFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridFunc.Rows[index];
                string id = selected_row.Cells[0].Value.ToString();
                msg = new MessageClass();

                if (e.ColumnIndex.Equals(2))
                {
                    if (msg.requestToUpdate())
                    {
                        _action("update");
                        setDataToFields(Convert.ToInt32(id));
                        this.funcId = Convert.ToInt32(id);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _action("add");
        }

        private void retToDash_Click(object sender, EventArgs e)
        {
            frmAuthDashboard ad = new frmAuthDashboard(this.userId);
            ad.Show();
            this.Hide();
        }
    }
}
