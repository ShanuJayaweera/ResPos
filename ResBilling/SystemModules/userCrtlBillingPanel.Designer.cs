namespace ResBilling.SystemModules
{
    partial class userCrtlBillingPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.lbl_total_no = new System.Windows.Forms.Label();
            this.boundry = new System.Windows.Forms.Panel();
            this.btnViewItem = new MetroFramework.Controls.MetroTile();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ticket_details = new System.Windows.Forms.Label();
            this.metroTile14 = new MetroFramework.Controls.MetroTile();
            this.panel_items = new System.Windows.Forms.FlowLayoutPanel();
            this.gridPurchased = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panelHoldTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPro = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_clear_all = new MetroFramework.Controls.MetroTile();
            this.btnTakeAway = new MetroFramework.Controls.MetroTile();
            this.btn_hold_ticket = new MetroFramework.Controls.MetroTile();
            this.panelCat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKOT = new MetroFramework.Controls.MetroTile();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnOpenTicket = new MetroFramework.Controls.MetroTile();
            this.comboStewards = new MetroFramework.Controls.MetroComboBox();
            this.dbemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboCustomers = new MetroFramework.Controls.MetroComboBox();
            this.dbcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.btn_customers = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtViewTotal = new MetroFramework.Controls.MetroTextBox();
            this.btn_items = new System.Windows.Forms.Panel();
            this.btnEdit = new MetroFramework.Controls.MetroTile();
            this.btnSplitBill = new MetroFramework.Controls.MetroTile();
            this.lbl_time = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel2.SuspendLayout();
            this.panel_items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcustomerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.btn_items.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_name
            // 
            this.product_name.FillWeight = 180F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "Hold Tickets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(25, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 25);
            this.label8.TabIndex = 66;
            this.label8.Text = " Remain : -";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(25, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = " Payment : -";
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveControl = null;
            this.btnRemove.Location = new System.Drawing.Point(396, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 38);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRemove.TabIndex = 46;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.UseSelectable = true;
            // 
            // lbl_total_no
            // 
            this.lbl_total_no.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_total_no.Location = new System.Drawing.Point(19, 5);
            this.lbl_total_no.Name = "lbl_total_no";
            this.lbl_total_no.Size = new System.Drawing.Size(68, 34);
            this.lbl_total_no.TabIndex = 62;
            this.lbl_total_no.Text = "Total : -";
            // 
            // boundry
            // 
            this.boundry.BackColor = System.Drawing.Color.DimGray;
            this.boundry.Location = new System.Drawing.Point(0, 0);
            this.boundry.Name = "boundry";
            this.boundry.Size = new System.Drawing.Size(518, 2);
            this.boundry.TabIndex = 61;
            // 
            // btnViewItem
            // 
            this.btnViewItem.ActiveControl = null;
            this.btnViewItem.Location = new System.Drawing.Point(265, 3);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(125, 38);
            this.btnViewItem.TabIndex = 64;
            this.btnViewItem.Text = "View";
            this.btnViewItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewItem.UseSelectable = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(526, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Steward Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(526, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Customer Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_ticket_details);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 27);
            this.panel2.TabIndex = 61;
            // 
            // lbl_ticket_details
            // 
            this.lbl_ticket_details.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticket_details.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ticket_details.Location = new System.Drawing.Point(3, 5);
            this.lbl_ticket_details.Name = "lbl_ticket_details";
            this.lbl_ticket_details.Size = new System.Drawing.Size(512, 23);
            this.lbl_ticket_details.TabIndex = 0;
            this.lbl_ticket_details.Text = "Please start a ticket or get hold ticket";
            this.lbl_ticket_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile14
            // 
            this.metroTile14.ActiveControl = null;
            this.metroTile14.Location = new System.Drawing.Point(12, 652);
            this.metroTile14.Name = "metroTile14";
            this.metroTile14.Size = new System.Drawing.Size(87, 61);
            this.metroTile14.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTile14.TabIndex = 70;
            this.metroTile14.Text = "Key Board";
            this.metroTile14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile14.UseSelectable = true;
            // 
            // panel_items
            // 
            this.panel_items.AutoScroll = true;
            this.panel_items.BackColor = System.Drawing.Color.White;
            this.panel_items.Controls.Add(this.gridPurchased);
            this.panel_items.Location = new System.Drawing.Point(2, 72);
            this.panel_items.Name = "panel_items";
            this.panel_items.Size = new System.Drawing.Size(519, 404);
            this.panel_items.TabIndex = 60;
            // 
            // gridPurchased
            // 
            this.gridPurchased.AllowUserToAddRows = false;
            this.gridPurchased.AllowUserToDeleteRows = false;
            this.gridPurchased.AllowUserToResizeRows = false;
            this.gridPurchased.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPurchased.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPurchased.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPurchased.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPurchased.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchased.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPurchased.ColumnHeadersHeight = 35;
            this.gridPurchased.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.product_name,
            this.price,
            this.qty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPurchased.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPurchased.EnableHeadersVisualStyles = false;
            this.gridPurchased.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPurchased.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPurchased.Location = new System.Drawing.Point(3, 3);
            this.gridPurchased.MultiSelect = false;
            this.gridPurchased.Name = "gridPurchased";
            this.gridPurchased.ReadOnly = true;
            this.gridPurchased.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchased.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPurchased.RowHeadersVisible = false;
            this.gridPurchased.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPurchased.RowTemplate.Height = 40;
            this.gridPurchased.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchased.Size = new System.Drawing.Size(512, 396);
            this.gridPurchased.TabIndex = 3;
            this.gridPurchased.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPurchased_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Visible = false;
            // 
            // timer_1
            // 
            this.timer_1.Interval = 1000;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(20, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = " Grand Total : -";
            // 
            // panelHoldTickets
            // 
            this.panelHoldTickets.AutoScroll = true;
            this.panelHoldTickets.Location = new System.Drawing.Point(12, 80);
            this.panelHoldTickets.Name = "panelHoldTickets";
            this.panelHoldTickets.Size = new System.Drawing.Size(87, 566);
            this.panelHoldTickets.TabIndex = 72;
            // 
            // panelPro
            // 
            this.panelPro.AutoScroll = true;
            this.panelPro.BackColor = System.Drawing.Color.White;
            this.panelPro.Enabled = false;
            this.panelPro.Location = new System.Drawing.Point(702, 131);
            this.panelPro.Name = "panelPro";
            this.panelPro.Size = new System.Drawing.Size(471, 528);
            this.panelPro.TabIndex = 36;
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.ActiveControl = null;
            this.btn_clear_all.BackColor = System.Drawing.Color.White;
            this.btn_clear_all.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear_all.Location = new System.Drawing.Point(915, 7);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(108, 38);
            this.btn_clear_all.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_clear_all.TabIndex = 67;
            this.btn_clear_all.Text = "Clear All";
            this.btn_clear_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear_all.UseSelectable = true;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.ActiveControl = null;
            this.btnTakeAway.Location = new System.Drawing.Point(801, 7);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(108, 38);
            this.btnTakeAway.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnTakeAway.TabIndex = 66;
            this.btnTakeAway.Text = "Take Away";
            this.btnTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTakeAway.UseSelectable = true;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btn_hold_ticket
            // 
            this.btn_hold_ticket.ActiveControl = null;
            this.btn_hold_ticket.Location = new System.Drawing.Point(687, 7);
            this.btn_hold_ticket.Name = "btn_hold_ticket";
            this.btn_hold_ticket.Size = new System.Drawing.Size(108, 38);
            this.btn_hold_ticket.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_hold_ticket.TabIndex = 65;
            this.btn_hold_ticket.Text = "Table View";
            this.btn_hold_ticket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_hold_ticket.UseSelectable = true;
            // 
            // panelCat
            // 
            this.panelCat.AutoScroll = true;
            this.panelCat.Enabled = false;
            this.panelCat.Location = new System.Drawing.Point(523, 131);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(178, 528);
            this.panelCat.TabIndex = 59;
            // 
            // btnKOT
            // 
            this.btnKOT.ActiveControl = null;
            this.btnKOT.Location = new System.Drawing.Point(997, 63);
            this.btnKOT.Name = "btnKOT";
            this.btnKOT.Size = new System.Drawing.Size(174, 46);
            this.btnKOT.TabIndex = 58;
            this.btnKOT.Text = "KOT";
            this.btnKOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKOT.UseSelectable = true;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(997, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(174, 46);
            this.btnPrint.TabIndex = 57;
            this.btnPrint.Text = "Print Bill";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.UseSelectable = true;
            // 
            // btnOpenTicket
            // 
            this.btnOpenTicket.ActiveControl = null;
            this.btnOpenTicket.Location = new System.Drawing.Point(852, 11);
            this.btnOpenTicket.Name = "btnOpenTicket";
            this.btnOpenTicket.Size = new System.Drawing.Size(139, 99);
            this.btnOpenTicket.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnOpenTicket.TabIndex = 56;
            this.btnOpenTicket.Text = "Open Ticket";
            this.btnOpenTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpenTicket.UseSelectable = true;
            this.btnOpenTicket.Click += new System.EventHandler(this.btnOpenTicket_Click);
            // 
            // comboStewards
            // 
            this.comboStewards.DataSource = this.dbemployeeBindingSource;
            this.comboStewards.DisplayMember = "name";
            this.comboStewards.Enabled = false;
            this.comboStewards.FormattingEnabled = true;
            this.comboStewards.ItemHeight = 23;
            this.comboStewards.Location = new System.Drawing.Point(524, 81);
            this.comboStewards.Name = "comboStewards";
            this.comboStewards.Size = new System.Drawing.Size(322, 29);
            this.comboStewards.TabIndex = 55;
            this.comboStewards.UseSelectable = true;
            this.comboStewards.ValueMember = "Id";
            this.comboStewards.SelectionChangeCommitted += new System.EventHandler(this.comboStewards_SelectionChangeCommitted);
            // 
            // dbemployeeBindingSource
            // 
            this.dbemployeeBindingSource.DataSource = typeof(ResBilling.Model.db_employee);
            // 
            // comboCustomers
            // 
            this.comboCustomers.DataSource = this.dbcustomerBindingSource;
            this.comboCustomers.DisplayMember = "nic";
            this.comboCustomers.Enabled = false;
            this.comboCustomers.FormattingEnabled = true;
            this.comboCustomers.ItemHeight = 23;
            this.comboCustomers.Location = new System.Drawing.Point(523, 24);
            this.comboCustomers.Name = "comboCustomers";
            this.comboCustomers.Size = new System.Drawing.Size(323, 29);
            this.comboCustomers.TabIndex = 54;
            this.comboCustomers.UseSelectable = true;
            this.comboCustomers.ValueMember = "Id";
            this.comboCustomers.SelectionChangeCommitted += new System.EventHandler(this.comboCustomers_SelectionChangeCommitted);
            // 
            // dbcustomerBindingSource
            // 
            this.dbcustomerBindingSource.DataSource = typeof(ResBilling.Model.db_customer);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(349, 546);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(168, 50);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile8.TabIndex = 51;
            this.metroTile8.Text = "Cash Payment";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseSelectable = true;
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Location = new System.Drawing.Point(349, 485);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(168, 50);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile9.TabIndex = 50;
            this.metroTile9.Text = "Card Payment";
            this.metroTile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(573, 7);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(108, 38);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 64;
            this.metroTile4.Text = "Categories";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(459, 7);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(108, 38);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 63;
            this.metroTile3.Text = "Items";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            // 
            // btn_customers
            // 
            this.btn_customers.ActiveControl = null;
            this.btn_customers.Location = new System.Drawing.Point(345, 7);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(108, 38);
            this.btn_customers.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_customers.TabIndex = 62;
            this.btn_customers.Text = "Customers";
            this.btn_customers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_customers.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtViewTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_total_no);
            this.panel1.Controls.Add(this.boundry);
            this.panel1.Location = new System.Drawing.Point(3, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 185);
            this.panel1.TabIndex = 48;
            // 
            // txtViewTotal
            // 
            // 
            // 
            // 
            this.txtViewTotal.CustomButton.Image = null;
            this.txtViewTotal.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtViewTotal.CustomButton.Name = "";
            this.txtViewTotal.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtViewTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtViewTotal.CustomButton.TabIndex = 1;
            this.txtViewTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtViewTotal.CustomButton.UseSelectable = true;
            this.txtViewTotal.CustomButton.Visible = false;
            this.txtViewTotal.Lines = new string[0];
            this.txtViewTotal.Location = new System.Drawing.Point(131, 14);
            this.txtViewTotal.MaxLength = 32767;
            this.txtViewTotal.Name = "txtViewTotal";
            this.txtViewTotal.PasswordChar = '\0';
            this.txtViewTotal.ReadOnly = true;
            this.txtViewTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewTotal.SelectedText = "";
            this.txtViewTotal.SelectionLength = 0;
            this.txtViewTotal.SelectionStart = 0;
            this.txtViewTotal.ShortcutsEnabled = true;
            this.txtViewTotal.Size = new System.Drawing.Size(195, 25);
            this.txtViewTotal.TabIndex = 67;
            this.txtViewTotal.UseSelectable = true;
            this.txtViewTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtViewTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_items
            // 
            this.btn_items.Controls.Add(this.btnRemove);
            this.btn_items.Controls.Add(this.btnViewItem);
            this.btn_items.Controls.Add(this.label3);
            this.btn_items.Controls.Add(this.label2);
            this.btn_items.Controls.Add(this.panel2);
            this.btn_items.Controls.Add(this.panel_items);
            this.btn_items.Controls.Add(this.panelPro);
            this.btn_items.Controls.Add(this.panelCat);
            this.btn_items.Controls.Add(this.btnKOT);
            this.btn_items.Controls.Add(this.btnPrint);
            this.btn_items.Controls.Add(this.btnOpenTicket);
            this.btn_items.Controls.Add(this.comboStewards);
            this.btn_items.Controls.Add(this.comboCustomers);
            this.btn_items.Controls.Add(this.metroTile8);
            this.btn_items.Controls.Add(this.metroTile9);
            this.btn_items.Controls.Add(this.panel1);
            this.btn_items.Controls.Add(this.btnEdit);
            this.btn_items.Controls.Add(this.btnSplitBill);
            this.btn_items.Location = new System.Drawing.Point(99, 51);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(1174, 662);
            this.btn_items.TabIndex = 69;
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveControl = null;
            this.btnEdit.Location = new System.Drawing.Point(134, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 38);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSplitBill
            // 
            this.btnSplitBill.ActiveControl = null;
            this.btnSplitBill.Location = new System.Drawing.Point(3, 3);
            this.btnSplitBill.Name = "btnSplitBill";
            this.btnSplitBill.Size = new System.Drawing.Size(125, 38);
            this.btnSplitBill.TabIndex = 40;
            this.btnSplitBill.Text = "Split";
            this.btnSplitBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSplitBill.UseSelectable = true;
            this.btnSplitBill.Click += new System.EventHandler(this.btnSplitBill_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.BackColor = System.Drawing.Color.Gray;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time.Location = new System.Drawing.Point(8, 7);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(217, 38);
            this.lbl_time.TabIndex = 68;
            this.lbl_time.Text = "label1";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(231, 7);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(108, 38);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 61;
            this.metroTile1.Text = "Log out";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // userCrtlBillingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTile14);
            this.Controls.Add(this.panelHoldTickets);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.btnTakeAway);
            this.Controls.Add(this.btn_hold_ticket);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_items);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.metroTile1);
            this.Name = "userCrtlBillingPanel";
            this.Load += new System.EventHandler(this.userCrtlBillingPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel_items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcustomerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.btn_items.ResumeLayout(false);
            this.btn_items.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTile btnRemove;
        private System.Windows.Forms.Label lbl_total_no;
        private System.Windows.Forms.Panel boundry;
        private MetroFramework.Controls.MetroTile btnViewItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ticket_details;
        private MetroFramework.Controls.MetroTile metroTile14;
        private System.Windows.Forms.FlowLayoutPanel panel_items;
        private MetroFramework.Controls.MetroGrid gridPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.Timer timer_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel panelHoldTickets;
        private System.Windows.Forms.FlowLayoutPanel panelPro;
        private MetroFramework.Controls.MetroTile btn_clear_all;
        private MetroFramework.Controls.MetroTile btnTakeAway;
        private MetroFramework.Controls.MetroTile btn_hold_ticket;
        private System.Windows.Forms.FlowLayoutPanel panelCat;
        private MetroFramework.Controls.MetroTile btnKOT;
        private MetroFramework.Controls.MetroTile btnPrint;
        private MetroFramework.Controls.MetroTile btnOpenTicket;
        private MetroFramework.Controls.MetroComboBox comboStewards;
        private MetroFramework.Controls.MetroComboBox comboCustomers;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile btn_customers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btn_items;
        private MetroFramework.Controls.MetroTile btnEdit;
        private MetroFramework.Controls.MetroTile btnSplitBill;
        private System.Windows.Forms.Label lbl_time;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txtViewTotal;
        private System.Windows.Forms.BindingSource dbcustomerBindingSource;
        private System.Windows.Forms.BindingSource dbemployeeBindingSource;
    }
}
