using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBilling.Classes;


namespace ResBilling.SystemModules
{
    public partial class frmBillingHome : MetroFramework.Forms.MetroForm
    {
        public frmBillingHome(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        public int userId { get; set; }

        MessageClass msg;
        MyTableClass mtc;
        TicketClass tc;

        private void setTables()
        {
            mtc = new MyTableClass();
            var data = mtc.getAllRecodes();
            int i = 0;
            foreach (var tab in data)
            {
                MetroFramework.Controls.MetroTile t = _table(i, tab.table_name);
                panelTableView.Controls.Add(t);
                t.Click += new System.EventHandler(this.table_click);
                i++;
            }
        }

        private void table_click(object sender, EventArgs e)
        {

            MetroFramework.Controls.MetroTile text = (MetroFramework.Controls.MetroTile)sender;
            tc = new TicketClass();
            mtc = new MyTableClass();
            int tableId = Convert.ToInt32(mtc.tableIdByTableName(text.Text.ToString()));

            if (isHoldTicket(text.Text.ToString()).Equals(true))
            {
                int ticketId = tc.getTicketIdByTable(text.Text.ToString());

                userCrtlBillingPanel uc = new userCrtlBillingPanel(this.userId, tableId, "1", ticketId);
                uc.Show();
                this.Hide();
            }
            else
            {
                userCrtlBillingPanel uc = new userCrtlBillingPanel(tableId, "1", this.userId);
                uc.Show();
                this.Hide();
            }

        }


        public MetroFramework.Controls.MetroTile _table(int id, string name)
        {
            MetroFramework.Controls.MetroTile t = new MetroFramework.Controls.MetroTile();
            t.Width = 194;
            t.Height = 90;
            t.Text = name;
            t.TextAlign = ContentAlignment.MiddleCenter;
            t.Name = "btn_" + id;
            t.UseSelectable = true;
            t.Margin = new Padding(5);

            if (isHoldTicket(name).Equals(true))
            {
                t.Style = MetroFramework.MetroColorStyle.Green;
            }
            else
            {
                t.Style = MetroFramework.MetroColorStyle.Default;
            }
            return t;
        }

       
        private Boolean isHoldTicket(string name)
        {
            tc = new TicketClass();
            Boolean r_val = tc.isTicketHold(name);
            if (r_val.Equals(true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            msg = new MessageClass();
            if (msg.requestToAddNewTable())
            {
                using (frmAddNewTable fh = new frmAddNewTable(this.userId))
                {
                    if (fh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        panelTableView.Controls.Clear();
                        setTables();

                    }
                }
            }
        }

        private void frmBillingHome_Load(object sender, EventArgs e)
        {
            setTables();
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            userCrtlBillingPanel uc = new userCrtlBillingPanel(null, "2", this.userId);
            uc.Show();
            this.Hide();
        }
    }
}
