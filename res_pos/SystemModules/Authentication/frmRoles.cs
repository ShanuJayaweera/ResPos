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
using res_pos.Classes;
using res_pos.Classes.AuthClasess;
using res_pos.Interfaces;
using res_pos.Model;
using res_pos.SystemModules.Dashboard;

namespace res_pos.SystemModules.Authentication
{
    public partial class frmRoles : MetroFramework.Forms.MetroForm , ICustomUI
    {
        public frmRoles(int userID, string action)
        {
            InitializeComponent();
            this.userId = userId;
            _action(action);
        }

        RoleClass rc;
        auth_roles ar;
        MessageClass msg;
        common_moduls cm;

        public string action { get; set; }
        public int userId { get; set; }
        public int roleId { get; set; }

        public void _action(string action)
        {
            if (action == "add")
            {
                lbl_heading.Text = "Add New Roles";
                btnSave.Enabled = true;
                this.action = "add";
                clearAllInputs();
                enableAllInputs();
                btnAdd.Visible = false;
            }
            if (action == "update")
            {
                lbl_heading.Text = "Update Roles";
                btnSave.Enabled = true;
                this.action = "update";
                enableAllInputs();
                btnAdd.Visible = true;
            }
        }

        public void clearAllInputs()
        {
            txtRoleName.Text = string.Empty;
        }

        public void enableAllInputs()
        {
            txtRoleName.Enabled = true;
        }

        public void disableAllInputs()
        {
            txtRoleName.Enabled = false;
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("Role Name", txtRoleName.Text));
            return list;
        }

        public void setDataToFields(int id)
        {
            rc = new RoleClass();
            var data = rc.getRecodeById(id);
            foreach (var item in data)
            {
                txtRoleName.Text = item.role_name;
            } 
        }

        public void search()
        {
            throw new NotImplementedException();
        }

        public void fillGridView()
        {
            rc = new RoleClass();
            gridRoles.DataSource = rc.getAllRecodes();
        }

        private auth_roles getDataFromFields()
        {
            ar = new auth_roles();
            ar.role_name = txtRoleName.Text.ToString();
            return ar;
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    rc = new RoleClass();
                    ar = new auth_roles();
                    ar = getDataFromFields();
                    string respond = rc.saveProcess(ar);

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
                    rc = new RoleClass();
                    ar = new auth_roles();
                    ar = getDataFromFields();
                    ar.Id = roleId;
                    string respond = rc.updateRole(ar);
                    if (respond.Equals("done"))
                    {
                        msg.recodeUpdateSuccess();
                        fillGridView();
                        clearAllInputs();
                        _action("add");
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
        }

        private void gridRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridRoles.Rows[index];
                string id = selected_row.Cells[0].Value.ToString();
                msg = new MessageClass();

                if (e.ColumnIndex.Equals(2))
                {
                    if (msg.requestToUpdate())
                    {
                        _action("update");
                        setDataToFields(Convert.ToInt32(id));
                        roleId = Convert.ToInt32(id);
                    }

                }
            }
        }

        private void retToDash_Click(object sender, EventArgs e)
        {
            frmAuthDashboard ad = new frmAuthDashboard(this.userId);
            ad.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _action("add");
        }
    }
}
