namespace res_pos.SystemModules.Customer
{
    partial class frmCustomers
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

        #region Windows Form Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.comboSearchCusType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_search_cus_type = new System.Windows.Forms.Label();
            this.comboSearchNic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCustomer = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_add_customer = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.comboCusType = new System.Windows.Forms.ComboBox();
            this.lbl_cus_type = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lbl_nic = new System.Windows.Forms.Label();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSearchCusType
            // 
            this.comboSearchCusType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSearchCusType.DisplayMember = "cus_type";
            this.comboSearchCusType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchCusType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboSearchCusType.FormattingEnabled = true;
            this.comboSearchCusType.Location = new System.Drawing.Point(521, 126);
            this.comboSearchCusType.Name = "comboSearchCusType";
            this.comboSearchCusType.Size = new System.Drawing.Size(250, 28);
            this.comboSearchCusType.TabIndex = 93;
            this.comboSearchCusType.ValueMember = "id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(450, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 600);
            this.panel1.TabIndex = 92;
            // 
            // lbl_search_cus_type
            // 
            this.lbl_search_cus_type.AutoSize = true;
            this.lbl_search_cus_type.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_cus_type.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_search_cus_type.Location = new System.Drawing.Point(523, 100);
            this.lbl_search_cus_type.Name = "lbl_search_cus_type";
            this.lbl_search_cus_type.Size = new System.Drawing.Size(164, 16);
            this.lbl_search_cus_type.TabIndex = 91;
            this.lbl_search_cus_type.Text = "Search By Customer Type";
            // 
            // comboSearchNic
            // 
            this.comboSearchNic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSearchNic.DisplayMember = "id";
            this.comboSearchNic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchNic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboSearchNic.FormattingEnabled = true;
            this.comboSearchNic.Location = new System.Drawing.Point(937, 125);
            this.comboSearchNic.Name = "comboSearchNic";
            this.comboSearchNic.Size = new System.Drawing.Size(250, 29);
            this.comboSearchNic.TabIndex = 90;
            this.comboSearchNic.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(940, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Search By NIC";
            // 
            // gridCustomer
            // 
            this.gridCustomer.AllowUserToAddRows = false;
            this.gridCustomer.AllowUserToDeleteRows = false;
            this.gridCustomer.AllowUserToResizeRows = false;
            this.gridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCustomer.ColumnHeadersHeight = 40;
            this.gridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.cusName,
            this.Nic,
            this.mobile,
            this.CustomerType,
            this.edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCustomer.EnableHeadersVisualStyles = false;
            this.gridCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCustomer.Location = new System.Drawing.Point(479, 172);
            this.gridCustomer.MultiSelect = false;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.ReadOnly = true;
            this.gridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCustomer.RowTemplate.Height = 35;
            this.gridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomer.Size = new System.Drawing.Size(770, 499);
            this.gridCustomer.TabIndex = 88;
            this.gridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomer_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "cusId";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // cusName
            // 
            this.cusName.HeaderText = "Name";
            this.cusName.Name = "cusName";
            this.cusName.ReadOnly = true;
            // 
            // Nic
            // 
            this.Nic.HeaderText = "NIC";
            this.Nic.Name = "Nic";
            this.Nic.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Mobile";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // CustomerType
            // 
            this.CustomerType.HeaderText = "Customer Type";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Update";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.ActiveControl = null;
            this.btn_add_customer.Location = new System.Drawing.Point(154, 565);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(132, 47);
            this.btn_add_customer.TabIndex = 85;
            this.btn_add_customer.Text = "Add Customer";
            this.btn_add_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_customer.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(292, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 47);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboCusType
            // 
            this.comboCusType.DisplayMember = "cus_type";
            this.comboCusType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCusType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboCusType.FormattingEnabled = true;
            this.comboCusType.Location = new System.Drawing.Point(28, 443);
            this.comboCusType.Name = "comboCusType";
            this.comboCusType.Size = new System.Drawing.Size(400, 28);
            this.comboCusType.TabIndex = 83;
            this.comboCusType.ValueMember = "id";
            // 
            // lbl_cus_type
            // 
            this.lbl_cus_type.AutoSize = true;
            this.lbl_cus_type.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus_type.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_cus_type.Location = new System.Drawing.Point(31, 423);
            this.lbl_cus_type.Name = "lbl_cus_type";
            this.lbl_cus_type.Size = new System.Drawing.Size(98, 16);
            this.lbl_cus_type.TabIndex = 82;
            this.lbl_cus_type.Text = "Customer type";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_email.Location = new System.Drawing.Point(30, 217);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 16);
            this.lbl_email.TabIndex = 81;
            this.lbl_email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Location = new System.Drawing.Point(28, 237);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 27);
            this.txtEmail.TabIndex = 80;
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_mobile.Location = new System.Drawing.Point(250, 353);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(51, 16);
            this.lbl_mobile.TabIndex = 79;
            this.lbl_mobile.Text = "Mobile";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMobile.Location = new System.Drawing.Point(248, 373);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(180, 27);
            this.txtMobile.TabIndex = 78;
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telephone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_telephone.Location = new System.Drawing.Point(30, 353);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(73, 16);
            this.lbl_telephone.TabIndex = 77;
            this.lbl_telephone.Text = "Telephone";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTelephone.Location = new System.Drawing.Point(28, 373);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(180, 27);
            this.txtTelephone.TabIndex = 76;
            // 
            // lbl_nic
            // 
            this.lbl_nic.AutoSize = true;
            this.lbl_nic.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nic.Location = new System.Drawing.Point(-28, 293);
            this.lbl_nic.Name = "lbl_nic";
            this.lbl_nic.Size = new System.Drawing.Size(30, 16);
            this.lbl_nic.TabIndex = 75;
            this.lbl_nic.Text = "NIC";
            // 
            // txtNic
            // 
            this.txtNic.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNic.Location = new System.Drawing.Point(28, 301);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(400, 27);
            this.txtNic.TabIndex = 74;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_address.Location = new System.Drawing.Point(30, 152);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(57, 16);
            this.lbl_address.TabIndex = 73;
            this.lbl_address.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress.Location = new System.Drawing.Point(28, 172);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 27);
            this.txtAddress.TabIndex = 72;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_name.Location = new System.Drawing.Point(30, 88);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 71;
            this.lbl_name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Location = new System.Drawing.Point(28, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 27);
            this.txtName.TabIndex = 70;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(24, 28);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(96, 23);
            this.lbl_heading.TabIndex = 94;
            this.lbl_heading.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(30, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "NIC";
            // 
            // dbcustomerBindingSource
            // 
            this.dbcustomerBindingSource.DataSource = typeof(res_pos.Model.db_customer);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(1191, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 62);
            this.btnBack.TabIndex = 96;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 694);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.comboSearchCusType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_search_cus_type);
            this.Controls.Add(this.comboSearchNic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridCustomer);
            this.Controls.Add(this.btn_add_customer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboCusType);
            this.Controls.Add(this.lbl_cus_type);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lbl_telephone);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lbl_nic);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtName);
            this.Name = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSearchCusType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_search_cus_type;
        private System.Windows.Forms.ComboBox comboSearchNic;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid gridCustomer;
        private MetroFramework.Controls.MetroTile btn_add_customer;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.ComboBox comboCusType;
        private System.Windows.Forms.Label lbl_cus_type;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lbl_nic;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dbcustomerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.Button btnBack;
    }
}