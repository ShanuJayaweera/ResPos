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
using res_pos.Classes.AuthClasess;
using res_pos.SystemModules.Dashboard;

namespace res_pos.SystemModules.Authentication
{
    public partial class frmRoleFunction : MetroFramework.Forms.MetroForm
    {
        public frmRoleFunction(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        RoleClass rc;
        FunctionClass fc;
        RoleFuncClass rfc;

        public int userId { get; set; }
        public string action { get; set; }

        public void fillRolesCombo()
        {
            rc = new RoleClass();
            comboRoles.DataSource = rc.getAllRecodes();
            comboRoles.DisplayMember = "role_name";
            comboRoles.ValueMember = "id";
            comboRoles.SelectedIndex = -1;
        }

        public void fillGridSourceFunc()
        {
            fc = new FunctionClass();
            authfunctionsBindingSource.DataSource = fc.getAllRecodes();
        }

        public void fillGridAddedFunc(int roleId)
        {
            rfc = new RoleFuncClass();
            var list = rfc.getFuncByRoleId(roleId);
            gridAddedFunc.Rows.Clear();
            foreach (var item in list)
            {
                gridAddedFunc.Rows.Add(item.func_id, item.auth_functions.func_name);
            }
        }

        private void frmRoleFunction_Load(object sender, EventArgs e)
        {
            fillRolesCombo();
            fillGridSourceFunc();
        }

        private void comboRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboRoles.SelectedIndex != -1)
            {
                fillGridAddedFunc(int.Parse(comboRoles.SelectedValue.ToString()));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridAddedFunc.SelectedRows.Count != 0 && comboRoles.SelectedIndex != -1)
            {
                rfc = new RoleFuncClass();
                DataGridViewRow row = this.gridAddedFunc.SelectedRows[0];
                string Id = this.gridAddedFunc.Rows[row.Index].Cells[0].Value.ToString();
                string respond = rfc.removeRoleFunc(int.Parse(comboRoles.SelectedValue.ToString()), int.Parse(Id));
                if (respond.Equals("done"))
                {
                    gridAddedFunc.Rows.Remove(row);
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gridSourceFunc.SelectedRows.Count != 0 && comboRoles.SelectedIndex != -1)
            {
                rfc = new RoleFuncClass();
                DataGridViewRow row = this.gridSourceFunc.SelectedRows[0];
                string Id = this.gridSourceFunc.Rows[row.Index].Cells[0].Value.ToString();
                string funcName = this.gridSourceFunc.Rows[row.Index].Cells[1].Value.ToString();
                string respond = rfc.addRoleFunc(int.Parse(comboRoles.SelectedValue.ToString()), int.Parse(Id), userId);
                if (respond.Equals("done"))
                {
                    gridAddedFunc.Rows.Add(Id, funcName);
                }
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAuthDashboard ad = new frmAuthDashboard(this.userId);
            ad.Show();
            this.Hide();
        }
    }
}
