namespace res_pos.SystemModules.Employee
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.comboSearchEmpType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_employee = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.lbl_search_emp_type = new System.Windows.Forms.Label();
            this.comboSearchNic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmpType = new System.Windows.Forms.ComboBox();
            this.lbl_emp_type = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lbl_nic = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.gridEmployee = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dbemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnViewAll = new MetroFramework.Controls.MetroTile();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSearchEmpType
            // 
            this.comboSearchEmpType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboSearchEmpType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSearchEmpType.DisplayMember = "id";
            this.comboSearchEmpType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchEmpType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboSearchEmpType.FormattingEnabled = true;
            this.comboSearchEmpType.Items.AddRange(new object[] {
            "All"});
            this.comboSearchEmpType.Location = new System.Drawing.Point(487, 125);
            this.comboSearchEmpType.Name = "comboSearchEmpType";
            this.comboSearchEmpType.Size = new System.Drawing.Size(258, 29);
            this.comboSearchEmpType.TabIndex = 71;
            this.comboSearchEmpType.ValueMember = "id";
            this.comboSearchEmpType.SelectedIndexChanged += new System.EventHandler(this.comboSearchEmpType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(458, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 592);
            this.panel1.TabIndex = 70;
            // 
            // btn_add_employee
            // 
            this.btn_add_employee.ActiveControl = null;
            this.btn_add_employee.Location = new System.Drawing.Point(169, 564);
            this.btn_add_employee.Name = "btn_add_employee";
            this.btn_add_employee.Size = new System.Drawing.Size(132, 47);
            this.btn_add_employee.TabIndex = 62;
            this.btn_add_employee.Text = "Add Employee";
            this.btn_add_employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_employee.UseSelectable = true;
            this.btn_add_employee.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(307, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 47);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_search_emp_type
            // 
            this.lbl_search_emp_type.AutoSize = true;
            this.lbl_search_emp_type.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_emp_type.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_search_emp_type.Location = new System.Drawing.Point(490, 101);
            this.lbl_search_emp_type.Name = "lbl_search_emp_type";
            this.lbl_search_emp_type.Size = new System.Drawing.Size(132, 16);
            this.lbl_search_emp_type.TabIndex = 60;
            this.lbl_search_emp_type.Text = "Search By Emp Type";
            // 
            // comboSearchNic
            // 
            this.comboSearchNic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboSearchNic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSearchNic.DisplayMember = "id";
            this.comboSearchNic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchNic.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboSearchNic.FormattingEnabled = true;
            this.comboSearchNic.Location = new System.Drawing.Point(776, 125);
            this.comboSearchNic.Name = "comboSearchNic";
            this.comboSearchNic.Size = new System.Drawing.Size(266, 29);
            this.comboSearchNic.TabIndex = 59;
            this.comboSearchNic.ValueMember = "id";
            this.comboSearchNic.SelectedIndexChanged += new System.EventHandler(this.comboSearchNic_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(777, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Search By NIC";
            // 
            // comboEmpType
            // 
            this.comboEmpType.DisplayMember = "id";
            this.comboEmpType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmpType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboEmpType.FormattingEnabled = true;
            this.comboEmpType.Items.AddRange(new object[] {
            "All"});
            this.comboEmpType.Location = new System.Drawing.Point(36, 504);
            this.comboEmpType.Name = "comboEmpType";
            this.comboEmpType.Size = new System.Drawing.Size(400, 29);
            this.comboEmpType.TabIndex = 57;
            this.comboEmpType.ValueMember = "id";
            // 
            // lbl_emp_type
            // 
            this.lbl_emp_type.AutoSize = true;
            this.lbl_emp_type.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_type.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_emp_type.Location = new System.Drawing.Point(39, 484);
            this.lbl_emp_type.Name = "lbl_emp_type";
            this.lbl_emp_type.Size = new System.Drawing.Size(99, 16);
            this.lbl_emp_type.TabIndex = 56;
            this.lbl_emp_type.Text = "Employee type";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_email.Location = new System.Drawing.Point(40, 423);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 16);
            this.lbl_email.TabIndex = 55;
            this.lbl_email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(36, 443);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 29);
            this.txtEmail.TabIndex = 54;
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_mobile.Location = new System.Drawing.Point(38, 361);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(51, 16);
            this.lbl_mobile.TabIndex = 53;
            this.lbl_mobile.Text = "Mobile";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMobile.Location = new System.Drawing.Point(36, 381);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(400, 29);
            this.txtMobile.TabIndex = 52;
            // 
            // lbl_nic
            // 
            this.lbl_nic.AutoSize = true;
            this.lbl_nic.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nic.Location = new System.Drawing.Point(39, 246);
            this.lbl_nic.Name = "lbl_nic";
            this.lbl_nic.Size = new System.Drawing.Size(30, 16);
            this.lbl_nic.TabIndex = 51;
            this.lbl_nic.Text = "NIC";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_address.Location = new System.Drawing.Point(38, 186);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(57, 16);
            this.lbl_address.TabIndex = 47;
            this.lbl_address.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAddress.Location = new System.Drawing.Point(36, 206);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 29);
            this.txtAddress.TabIndex = 46;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_name.Location = new System.Drawing.Point(38, 125);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 45;
            this.lbl_name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(36, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 29);
            this.txtName.TabIndex = 44;
            // 
            // txtNic
            // 
            this.txtNic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNic.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNic.Location = new System.Drawing.Point(36, 266);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(400, 29);
            this.txtNic.TabIndex = 50;
            // 
            // gridEmployee
            // 
            this.gridEmployee.AllowUserToAddRows = false;
            this.gridEmployee.AllowUserToDeleteRows = false;
            this.gridEmployee.AllowUserToResizeRows = false;
            this.gridEmployee.AutoGenerateColumns = false;
            this.gridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmployee.ColumnHeadersHeight = 40;
            this.gridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.edit});
            this.gridEmployee.DataSource = this.dbemployeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmployee.EnableHeadersVisualStyles = false;
            this.gridEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEmployee.Location = new System.Drawing.Point(487, 172);
            this.gridEmployee.MultiSelect = false;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.ReadOnly = true;
            this.gridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEmployee.RowTemplate.Height = 40;
            this.gridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployee.Size = new System.Drawing.Size(770, 528);
            this.gridEmployee.TabIndex = 43;
            this.gridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployee_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            this.nicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Update";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "Update";
            // 
            // dbemployeeBindingSource
            // 
            this.dbemployeeBindingSource.DataSource = typeof(res_pos.Model.db_employee);
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(24, 41);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(96, 23);
            this.lbl_heading.TabIndex = 42;
            this.lbl_heading.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(39, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Telephone";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTelephone.Location = new System.Drawing.Point(36, 329);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(400, 29);
            this.txtTelephone.TabIndex = 73;
            // 
            // btnViewAll
            // 
            this.btnViewAll.ActiveControl = null;
            this.btnViewAll.Location = new System.Drawing.Point(1085, 116);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(108, 38);
            this.btnViewAll.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnViewAll.TabIndex = 75;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewAll.UseSelectable = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(1186, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 62);
            this.btnBack.TabIndex = 97;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.comboSearchEmpType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add_employee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl_search_emp_type);
            this.Controls.Add(this.comboSearchNic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEmpType);
            this.Controls.Add(this.lbl_emp_type);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lbl_nic);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.lbl_heading);
            this.Name = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboSearchEmpType;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btn_add_employee;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.Label lbl_search_emp_type;
        private System.Windows.Forms.ComboBox comboSearchNic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmpType;
        private System.Windows.Forms.Label lbl_emp_type;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lbl_nic;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNic;
        private MetroFramework.Controls.MetroGrid gridEmployee;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.BindingSource dbemployeeBindingSource;
        private MetroFramework.Controls.MetroTile btnViewAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.Button btnBack;
    }
}