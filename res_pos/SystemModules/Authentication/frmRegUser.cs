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
using res_pos.Classes.AuthClasess;
using System.Security.Cryptography;
using res_pos.Classes;
using res_pos.SystemModules.Dashboard;

namespace res_pos.SystemModules.Authentication
{
    public partial class frmRegUser : MetroFramework.Forms.MetroForm
    {
        public frmRegUser(int empId, string empName)
        {
            InitializeComponent();
            this.empId = empId;
            this.empName = empName;
        }

        auth_users au;
        RoleClass rc;
        common_moduls cm;
        MessageClass msg;
        UserClass uc;

        public int empId { get; set; }
        public string empName { get; set; }

        private void fillRolesCombo()
        {
            rc = new RoleClass();
            comboRoles.DataSource = rc.getAllRecodes();
            comboRoles.DisplayMember = "role_name";
            comboRoles.ValueMember = "id";
        }


        private auth_users getUserInput()
        {
            au = new auth_users();
           
            au.role_id = int.Parse(comboRoles.SelectedValue.ToString());
            au.user_name = txtUserName.Text.ToString();
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text.ToString());
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            au.user_password = sb.ToString();
            au.emp_id = empId;
            return au;
        }

        public List<KeyValuePair<string, string>> nullValidateData()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("User Name", txtUserName.Text));
            list.Add(new KeyValuePair<string, string>("Password", txtPassword.Text));
            if (comboRoles.SelectedIndex != -1)
            {
                list.Add(new KeyValuePair<string, string>("Role", comboRoles.SelectedValue.ToString()));
            }
            else
            {
                list.Add(new KeyValuePair<string, string>("Role", ""));
            }
            return list;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            cm = new common_moduls();
            msg = new MessageClass();
            au = new auth_users();
            au = getUserInput();

            if (cm.check_null_data(nullValidateData()))
            {
                msg.requiredDataErr();
            }
            else
            {
                uc = new UserClass();
                string respond = uc.saveProcess(au);
                if (respond.Equals("done"))
                {
                    msg.recodeInsertSuccess();
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

        private void frmRegUser_Load(object sender, EventArgs e)
        {
            fillRolesCombo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAuthDashboard ad = new frmAuthDashboard(this.empId);
            ad.Show();
            this.Hide();
        }
    }
}
