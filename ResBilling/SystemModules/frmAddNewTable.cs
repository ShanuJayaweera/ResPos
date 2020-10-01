using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBilling.Model;
using ResBilling.Classes;

namespace ResBilling.SystemModules
{
    public partial class frmAddNewTable : MetroFramework.Forms.MetroForm
    {
        public frmAddNewTable(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        my_tables tab;
        MyTableClass mtc;
        MessageClass msg;

        public int userId { get; set; }

        private my_tables getUserInput(int userId)
        {
            tab = new my_tables();
            tab.table_name = txtTblName.Text.ToString();
            tab.created_by = this.userId;
            tab.created_date = DateTime.Now.ToString();
            return tab;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            mtc = new MyTableClass();
            tab = new my_tables();
            msg = new MessageClass();
            tab = getUserInput(this.userId);

            string respond = mtc.saveProcess(tab);
            if (respond.Equals("done"))
            {
                msg.recodeInsertSuccess();
            }
            else if(respond.Equals("exist"))
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
