namespace res_pos
{
    partial class frmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.lbl_heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_item_code = new System.Windows.Forms.Label();
            this.txtProCode = new System.Windows.Forms.TextBox();
            this.lbl_item_barcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_pro_cat = new System.Windows.Forms.Label();
            this.comboProCat = new System.Windows.Forms.ComboBox();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.btn_employee = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.lbl_p_code = new System.Windows.Forms.Label();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_add_item = new MetroFramework.Controls.MetroTile();
            this.view_all = new MetroFramework.Controls.MetroTile();
            this.comboStockCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPro = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboSearchProductCode = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.numBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblBuyingPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(25, 35);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(135, 23);
            this.lbl_heading.TabIndex = 3;
            this.lbl_heading.Text = "Product Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(463, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 592);
            this.panel1.TabIndex = 4;
            // 
            // lbl_item_code
            // 
            this.lbl_item_code.AutoSize = true;
            this.lbl_item_code.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_code.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_item_code.Location = new System.Drawing.Point(25, 227);
            this.lbl_item_code.Name = "lbl_item_code";
            this.lbl_item_code.Size = new System.Drawing.Size(91, 16);
            this.lbl_item_code.TabIndex = 36;
            this.lbl_item_code.Text = "Product Code";
            // 
            // txtProCode
            // 
            this.txtProCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProCode.Location = new System.Drawing.Point(149, 221);
            this.txtProCode.Name = "txtProCode";
            this.txtProCode.Size = new System.Drawing.Size(300, 29);
            this.txtProCode.TabIndex = 35;
            // 
            // lbl_item_barcode
            // 
            this.lbl_item_barcode.AutoSize = true;
            this.lbl_item_barcode.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_barcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_item_barcode.Location = new System.Drawing.Point(25, 278);
            this.lbl_item_barcode.Name = "lbl_item_barcode";
            this.lbl_item_barcode.Size = new System.Drawing.Size(109, 16);
            this.lbl_item_barcode.TabIndex = 38;
            this.lbl_item_barcode.Text = "Product Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBarcode.Location = new System.Drawing.Point(149, 272);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(300, 29);
            this.txtBarcode.TabIndex = 37;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_name.Location = new System.Drawing.Point(25, 332);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(96, 16);
            this.lbl_name.TabIndex = 40;
            this.lbl_name.Text = "Product Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Location = new System.Drawing.Point(147, 326);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 29);
            this.txtName.TabIndex = 39;
            // 
            // lbl_pro_cat
            // 
            this.lbl_pro_cat.AutoSize = true;
            this.lbl_pro_cat.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pro_cat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_pro_cat.Location = new System.Drawing.Point(27, 134);
            this.lbl_pro_cat.Name = "lbl_pro_cat";
            this.lbl_pro_cat.Size = new System.Drawing.Size(115, 16);
            this.lbl_pro_cat.TabIndex = 48;
            this.lbl_pro_cat.Text = "Product Category";
            // 
            // comboProCat
            // 
            this.comboProCat.DisplayMember = "emp_type";
            this.comboProCat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProCat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboProCat.FormattingEnabled = true;
            this.comboProCat.Location = new System.Drawing.Point(149, 128);
            this.comboProCat.Name = "comboProCat";
            this.comboProCat.Size = new System.Drawing.Size(300, 29);
            this.comboProCat.TabIndex = 51;
            this.comboProCat.ValueMember = "id";
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(726, 16);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(121, 38);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile5.TabIndex = 57;
            this.metroTile5.Text = "Table View";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(599, 16);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(121, 38);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 56;
            this.metroTile4.Text = "Categories";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            // 
            // btn_employee
            // 
            this.btn_employee.ActiveControl = null;
            this.btn_employee.Location = new System.Drawing.Point(472, 16);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(121, 38);
            this.btn_employee.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_employee.TabIndex = 55;
            this.btn_employee.Text = "Employee";
            this.btn_employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_employee.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(345, 16);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(121, 38);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 54;
            this.metroTile2.Text = "Customers";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(218, 16);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(121, 38);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 53;
            this.metroTile1.Text = "Log out";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(310, 602);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 47);
            this.btn_save.TabIndex = 60;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_p_code
            // 
            this.lbl_p_code.AutoSize = true;
            this.lbl_p_code.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_code.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_p_code.Location = new System.Drawing.Point(864, 106);
            this.lbl_p_code.Name = "lbl_p_code";
            this.lbl_p_code.Size = new System.Drawing.Size(91, 16);
            this.lbl_p_code.TabIndex = 62;
            this.lbl_p_code.Text = "Product Code";
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(167, 602);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(137, 47);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_clear.TabIndex = 65;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add_item
            // 
            this.btn_add_item.ActiveControl = null;
            this.btn_add_item.Location = new System.Drawing.Point(24, 602);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(137, 47);
            this.btn_add_item.TabIndex = 66;
            this.btn_add_item.Text = "Add Product";
            this.btn_add_item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_item.UseSelectable = true;
            this.btn_add_item.Visible = false;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // view_all
            // 
            this.view_all.ActiveControl = null;
            this.view_all.Location = new System.Drawing.Point(853, 16);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(108, 38);
            this.view_all.Style = MetroFramework.MetroColorStyle.Orange;
            this.view_all.TabIndex = 67;
            this.view_all.Text = "View All";
            this.view_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_all.UseSelectable = true;
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
            // 
            // comboStockCat
            // 
            this.comboStockCat.DisplayMember = "emp_type";
            this.comboStockCat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStockCat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboStockCat.FormattingEnabled = true;
            this.comboStockCat.Location = new System.Drawing.Point(147, 174);
            this.comboStockCat.Name = "comboStockCat";
            this.comboStockCat.Size = new System.Drawing.Size(300, 29);
            this.comboStockCat.TabIndex = 69;
            this.comboStockCat.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Stock Category";
            // 
            // gridPro
            // 
            this.gridPro.AllowUserToAddRows = false;
            this.gridPro.AllowUserToDeleteRows = false;
            this.gridPro.AllowUserToResizeRows = false;
            this.gridPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPro.ColumnHeadersHeight = 40;
            this.gridPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.proCode,
            this.proName,
            this.proCat,
            this.stockCat,
            this.update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPro.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPro.EnableHeadersVisualStyles = false;
            this.gridPro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPro.Location = new System.Drawing.Point(492, 134);
            this.gridPro.Name = "gridPro";
            this.gridPro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPro.RowTemplate.Height = 40;
            this.gridPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPro.Size = new System.Drawing.Size(765, 496);
            this.gridPro.TabIndex = 70;
            this.gridPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPro_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // proCode
            // 
            this.proCode.HeaderText = "Product Code";
            this.proCode.Name = "proCode";
            // 
            // proName
            // 
            this.proName.HeaderText = "Product Name";
            this.proName.Name = "proName";
            // 
            // proCat
            // 
            this.proCat.HeaderText = "Product Category";
            this.proCat.Name = "proCat";
            // 
            // stockCat
            // 
            this.stockCat.HeaderText = "Stock Category";
            this.stockCat.Name = "stockCat";
            // 
            // update
            // 
            this.update.FillWeight = 60F;
            this.update.HeaderText = "Update";
            this.update.Name = "update";
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // comboSearchProductCode
            // 
            this.comboSearchProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboSearchProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSearchProductCode.DisplayMember = "emp_type";
            this.comboSearchProductCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchProductCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboSearchProductCode.FormattingEnabled = true;
            this.comboSearchProductCode.Location = new System.Drawing.Point(961, 99);
            this.comboSearchProductCode.Name = "comboSearchProductCode";
            this.comboSearchProductCode.Size = new System.Drawing.Size(296, 29);
            this.comboSearchProductCode.TabIndex = 61;
            this.comboSearchProductCode.ValueMember = "id";
            this.comboSearchProductCode.SelectionChangeCommitted += new System.EventHandler(this.comboSearchProductCode_SelectionChangeCommitted);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(1131, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 51);
            this.btnBack.TabIndex = 71;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Location = new System.Drawing.Point(149, 506);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(146, 20);
            this.numDiscount.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Discount %";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblPrice.Location = new System.Drawing.Point(21, 387);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(162, 16);
            this.lblPrice.TabIndex = 86;
            this.lblPrice.Text = "Please use one unit price";
            // 
            // numSellingPrice
            // 
            this.numSellingPrice.DecimalPlaces = 2;
            this.numSellingPrice.Location = new System.Drawing.Point(149, 461);
            this.numSellingPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSellingPrice.Name = "numSellingPrice";
            this.numSellingPrice.Size = new System.Drawing.Size(146, 20);
            this.numSellingPrice.TabIndex = 85;
            // 
            // numBuyingPrice
            // 
            this.numBuyingPrice.DecimalPlaces = 2;
            this.numBuyingPrice.Location = new System.Drawing.Point(149, 416);
            this.numBuyingPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBuyingPrice.Name = "numBuyingPrice";
            this.numBuyingPrice.Size = new System.Drawing.Size(146, 20);
            this.numBuyingPrice.TabIndex = 84;
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSellingPrice.Location = new System.Drawing.Point(21, 465);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(84, 16);
            this.lblSellingPrice.TabIndex = 83;
            this.lblSellingPrice.Text = "Selling Price";
            // 
            // lblBuyingPrice
            // 
            this.lblBuyingPrice.AutoSize = true;
            this.lblBuyingPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyingPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBuyingPrice.Location = new System.Drawing.Point(21, 420);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(85, 16);
            this.lblBuyingPrice.TabIndex = 82;
            this.lblBuyingPrice.Text = "Buying Price";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numSellingPrice);
            this.Controls.Add(this.numBuyingPrice);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblBuyingPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridPro);
            this.Controls.Add(this.comboStockCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.btn_add_item);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_p_code);
            this.Controls.Add(this.comboSearchProductCode);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.comboProCat);
            this.Controls.Add(this.lbl_pro_cat);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl_item_barcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lbl_item_code);
            this.Controls.Add(this.txtProCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_heading);
            this.Name = "frmProduct";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frm_item_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_item_code;
        private System.Windows.Forms.TextBox txtProCode;
        private System.Windows.Forms.Label lbl_item_barcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_pro_cat;
        private System.Windows.Forms.ComboBox comboProCat;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile btn_employee;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile btn_save;
        private System.Windows.Forms.Label lbl_p_code;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_add_item;
        private MetroFramework.Controls.MetroTile view_all;
        private System.Windows.Forms.ComboBox comboStockCat;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid gridPro;
        private System.Windows.Forms.ComboBox comboSearchProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCat;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numSellingPrice;
        private System.Windows.Forms.NumericUpDown numBuyingPrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label lblBuyingPrice;
    }
}