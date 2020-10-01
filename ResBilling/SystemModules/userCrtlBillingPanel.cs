using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBilling.Classes;
using ResBilling.VM;
using System.Windows.Forms.VisualStyles;
using ResBilling.Model;

namespace ResBilling.SystemModules
{
    public partial class userCrtlBillingPanel : MetroFramework.Forms.MetroForm
    {
        public userCrtlBillingPanel(int? tableId, string billingCat, int userId)
        {
            InitializeComponent();

            this.userId = userId;
            this.tableId = tableId;
            this.billingCat = billingCat;
            timer_1.Start();

            fillCusCombo();
            fillStewardCombo();
            setProductCategories();
            holdTablesPanel();
            beforeOpenTicketState();
        }

        public userCrtlBillingPanel(int userId, int tableId, string billingCat, int ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            this.userId = userId;
            this.tableId = tableId;
            this.billingCat = billingCat;
            timer_1.Start();
            this.holded = true;

            fillCusCombo();
            fillStewardCombo();
            setProductCategories();
            holdTablesPanel();
            afterOpenTicketState();
           
            continueHoldTicket(this.ticketId);
            setLblTicketDetails();


        }

        public int? tableId { get; set; }
        public int userId { get; set; }
        public string billingCat { get; set; }
        public int ticketId { get; set; }
        public int currentCatId { get; set; }
        public Boolean holded { get; set; }
        public int billingRowId { get; set; }

        ProductCategoryClass pcc;
        ProductClass proc;
        PriceClass pric;
        TempBillClass tbc;
        TicketClass tc;
        MessageClass msg;
        bill_temp_bill temp;


        // before open a ticket
        private void beforeOpenTicketState()
        {
            panelPro.Enabled = false;
            panelCat.Enabled = false;
            gridPurchased.Enabled = false;
            btnOpenTicket.Text = "Open Ticket";
            comboCustomers.Enabled = false;
            comboStewards.Enabled = false;
            btnSplitBill.Enabled = false;
            btnEdit.Enabled = false;
            btnViewItem.Enabled = false;
            btnRemove.Enabled = false;
            btnPrint.Enabled = false;
            btnKOT.Enabled = false;
            
        }

        // before open a ticket
        private void afterOpenTicketState()
        {
            panelPro.Enabled = true;
            panelCat.Enabled = true;
            gridPurchased.Enabled = true;
            btnOpenTicket.Text = "Hold Ticket";
            comboCustomers.Enabled = true;
            comboStewards.Enabled = true;
            btnSplitBill.Enabled = true;
            btnEdit.Enabled = true;
            btnViewItem.Enabled = true;
            btnRemove.Enabled = true;
            btnPrint.Enabled = true;
            btnKOT.Enabled = true;
        }

        private void takeAway()
        {
            this.billingCat = "2";
            this.tableId = null;
        }


        private void setLblTicketDetails()
        {
            lbl_ticket_details.Text = "Table ID #" + this.tableId.ToString() + " | Ticket ID #" + this.ticketId.ToString();
        }


        private void setProductCategories()
        {
            pcc = new ProductCategoryClass();
            proc = new ProductClass();

            var data = pcc.getAllRecodes();

            int i = 0;
            foreach (var item in data)
            {
                MetroFramework.Controls.MetroTile t = catTile(i, item.cat_name);
                panelCat.Controls.Add(t);
                t.Click += new System.EventHandler(this.categoryClick);
                if (i.Equals(0))
                {
                    this.currentCatId = item.Id;
                    var p_items = proc.getProductByCatId(this.currentCatId);
                    int k = 0;
                    foreach (var m in p_items)
                    {
                        MetroFramework.Controls.MetroTile j = productTile(k, m.pro_name);
                        panelPro.Controls.Add(j);
                        j.Click += new System.EventHandler(this.itemClick);
                        k++;
                    }
                }
                i = i + 1;
            }
        }


        //load category buttons
        public MetroFramework.Controls.MetroTile catTile(int id, string name)
        {
            MetroFramework.Controls.MetroTile t = new MetroFramework.Controls.MetroTile();
            t.Style = MetroFramework.MetroColorStyle.Blue;
            t.Width = 160;
            t.Height = 50;
            t.Text = name;
            t.Name = "btn_" + id;
            t.UseSelectable = true;
            t.Margin = new Padding(2);
            return t;

        }


        //load product buttons
        public MetroFramework.Controls.MetroTile productTile(int id, string name)
        {
            MetroFramework.Controls.MetroTile t = new MetroFramework.Controls.MetroTile();
            t.Style = MetroFramework.MetroColorStyle.Blue;
            t.Width = 150;
            t.Height = 50;
            t.Text = name;
            t.Name = "btn_" + id;
            t.UseSelectable = true;
            t.Margin = new Padding(2);
            return t;
        }


        private void categoryClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile text = (MetroFramework.Controls.MetroTile)sender;
            pcc = new ProductCategoryClass();
            proc = new ProductClass();

            int catId = pcc.getCatIdByName(text.Text);
            var pItems = proc.getProductByCatId(catId);
            panelPro.Controls.Clear();
            this.currentCatId = catId;
            int k = 0;
            foreach (var m in pItems)
            {
                MetroFramework.Controls.MetroTile j = productTile(k, m.pro_name);
                panelPro.Controls.Add(j);
                j.Click += new System.EventHandler(this.itemClick);
                k++;

            }
        }


        private void itemClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile text = (MetroFramework.Controls.MetroTile)sender;
            populateProducts(text.Text.ToString(), this.currentCatId);
        }


        //populate items
        private void populateProducts(string itemName, int currentCatId)
        {
            proc = new ProductClass();
            tbc = new TempBillClass();
            tc = new TicketClass();
            temp = new bill_temp_bill();

            var itemData = proc.getProductByCatIdAndName(itemName, currentCatId);

            foreach (var item in itemData)
            {
                temp.proId = item.Id;
                temp.ticketId = this.ticketId;

                if (tbc.recodeExist(item.Id, this.ticketId))
                {
                    
                    double cQty = tbc.getCurrentQTY(item.Id, this.ticketId);

                    cQty++;
                    temp.qty = cQty;
                    tbc.saveTempBillProcess(temp);

                    gridPurchased.Rows.Clear(); // clear items grid view
                    List<BillingProDataVM> tempBill = tbc.getTempBillPro(this.ticketId);
                    setTempBillToGrid(tempBill);
                   

                    string newTotal = tc.updateTotalWhenAddProduct(item.Id, 1, this.ticketId); // update bill_ticket table total when add one item
                    viewDetails(double.Parse(newTotal));
                    

                }
                else
                {
                    BillingProDataVM bvm = new BillingProDataVM();
                    pric = new PriceClass();
                    bvm.proId = item.Id;
                    bvm.proCode = item.pro_code;
                    bvm.proName = item.pro_name;
                    bvm.qty = 1;
                    bvm.sellingPrice = pric.getSellingPriceByProId(item.Id);
                    

                    temp.qty = bvm.qty;
                    tbc.saveTempBillProcess(temp);
                    setOneProGrid(bvm);
                    string newTotal = tc.updateTotalWhenAddProduct(item.Id, 1, this.ticketId); // update bill_ticket table total when add one item
                    viewDetails(double.Parse(newTotal));

                }
            }
        }


        // add one product to purchesed grid
        private void setOneProGrid(BillingProDataVM bvm)
        {
            gridPurchased.Rows.Add(bvm.proId, bvm.proCode, bvm.proName, bvm.sellingPrice, bvm.qty);
        }


        private void setTempBillToGrid(List<BillingProDataVM> list)
        {
            foreach (var item in list)
            {
                gridPurchased.Rows.Add(item.proId, item.proCode, item.proName, item.sellingPrice, item.qty);
            }

        }


        private void viewDetails(double total)
        {
            txtViewTotal.Text = total.ToString();
        }


        // fill customer combo
        private void fillCusCombo()
        {
            CustomerClass cc = new CustomerClass();
            dbcustomerBindingSource.DataSource = cc.getAllRecodes();
        }


        // fill steward combo
        private void fillStewardCombo()
        {
            EmployeeClass ec = new EmployeeClass();
            dbemployeeBindingSource.DataSource = ec.getStewardsList();
        }


        private bill_ticket getTicketDetails()
        {
            bill_ticket tkt = new bill_ticket();

            tkt.billing_type = int.Parse(billingCat);
            tkt.tbl_id = this.tableId;
            tkt.is_hold = 1;
            tkt.created_by = this.userId;
            tkt.created_date = DateTime.Now.ToString();
            tkt.total = 0.00;
            tkt.total_discount = 0.00;
            return tkt;
        }


        // create new ticket
        private void createNewTicket(bill_ticket tkt)
        {
            tc = new TicketClass();
            msg = new MessageClass();
            int respond = tc.createNewTicket(tkt);
            if (respond.Equals(-1))
            {
                if (msg.requestToHoldTickt())
                {
                    frmBillingHome bh = new frmBillingHome(this.userId);
                    bh.Show();
                    this.Hide();
                }
            }
            else
            {
                this.ticketId = respond;
            }
        }


        //hold table tile
        public MetroFramework.Controls.MetroTile holdTableTile(int id, string name)
        {
            MetroFramework.Controls.MetroTile t = new MetroFramework.Controls.MetroTile();
            t.Style = MetroFramework.MetroColorStyle.Brown;
            t.Width = 65;
            t.Height = 40;
            t.Text = name;
            t.Name = "btn_" + id;
            t.UseSelectable = true;
            t.Margin = new Padding(2);
            return t;

        }

        
        private void holdTablesPanel()
        {
            tc = new TicketClass();
            panelHoldTickets.Controls.Clear();
            var data = tc.holdTickets();
            int i = 0;
            foreach (var item in data)
            {
                MetroFramework.Controls.MetroTile t = holdTableTile(i, item.Id.ToString());
                panelHoldTickets.Controls.Add(t);
                t.Click += new System.EventHandler(this.hold_table_click);
                i++;
            }

        }


        //hold table click
        private void hold_table_click(object sender, EventArgs e)
        {
            msg = new MessageClass();
            if (msg.requestToHoldTickt())
            {
                MetroFramework.Controls.MetroTile text = (MetroFramework.Controls.MetroTile)sender;
                this.ticketId = int.Parse(text.Text.ToString());
                gridPurchased.Rows.Clear();
                
                holdTablesPanel();
                continueHoldTicket(this.ticketId);
            }
        }


        //continue hold ticket
        private void continueHoldTicket(int ticketId)
        {
            gridPurchased.Rows.Clear();
            tc = new TicketClass();
            tbc = new TempBillClass();


            var ticketData = tc.holdTicketData(ticketId);
            foreach (var item in ticketData)
            {
                this.tableId = item.tbl_id;
                if (!item.cus_id.Equals(null))
                {
                    comboCustomers.SelectedValue = item.cus_id;
                }

                if (!item.stewardId.Equals(null))
                {
                    comboStewards.SelectedValue = item.stewardId;
                }
            }

            List<BillingProDataVM> tempBill = tbc.getTempBillPro(ticketId);
            setTempBillToGrid(tempBill);

            afterOpenTicketState();
            setLblTicketDetails();
        }


        private void userCrtlBillingPanel_Load(object sender, EventArgs e)
        {
         
        }


        private void btnOpenTicket_Click(object sender, EventArgs e)
        {
            msg = new MessageClass();
            if (btnOpenTicket.Text.Equals("Hold Ticket"))
            {
                frmBillingHome bh = new frmBillingHome(this.userId);
                bh.Show();
                this.Hide();
            }
            else
            {
                if (msg.requestToAddNewTicket())
                {
                    createNewTicket(getTicketDetails());
                    afterOpenTicketState();
                    setLblTicketDetails();
                }
            }
        }

        private void comboCustomers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // update customer details
            tc = new TicketClass();
            msg = new MessageClass();
            int cusId = int.Parse(comboCustomers.SelectedValue.ToString());
            string respond = tc.updateCustomer(cusId, this.ticketId);
            if (respond.Equals("done"))
            {
                // recode updated
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


        private void comboStewards_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // update steward details
            tc = new TicketClass();
            int stewardId = int.Parse(comboStewards.SelectedValue.ToString());
            string respond = tc.updateSteward(stewardId, this.ticketId);
            if (respond.Equals("done"))
            {
                // recode updated
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


        private void btnSplitBill_Click(object sender, EventArgs e)
        {
            frmSplitBill s = new frmSplitBill(this.ticketId);
            s.Show();
            this.Hide();
        }


        private void timer_1_Tick(object sender, EventArgs e)
        {
            //get current time
            int yy = DateTime.Now.Year;
            int MM = DateTime.Now.Month;
            int dd = DateTime.Now.Day;
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero

            time += " ";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            lbl_time.Text = time.ToString();
        }

        private void gridPurchased_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                this.billingRowId = index;
            }
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.billingRowId.ToString()) && !this.ticketId.Equals(0))
            {
                DataGridViewRow selected_row = gridPurchased.Rows[this.billingRowId];
                string id = selected_row.Cells[0].Value.ToString();

                using (frmUpdateViewItem ed = new frmUpdateViewItem(this.ticketId, int.Parse(id), "view"))
                {
                   
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.billingRowId.ToString()))
            {
                DataGridViewRow selected_row = gridPurchased.Rows[this.billingRowId];
                string id = selected_row.Cells[0].Value.ToString();

                using (frmUpdateViewItem ed = new frmUpdateViewItem(this.ticketId, int.Parse(id), "update"))
                {
                    if (ed.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        gridPurchased.Rows.Clear();
                       // load_items_from_temp_table();
                       // change_total_with_bill_discount();
                    }
                }
            }
        }
    }
}
