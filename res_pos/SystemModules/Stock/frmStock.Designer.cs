namespace res_pos.stock
{
    partial class frmStock
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
            this.btn_reset = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.gridBill = new MetroFramework.Controls.MetroGrid();
            this.proId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddToGrid = new MetroFramework.Controls.MetroTile();
            this.lbl_supliers = new System.Windows.Forms.Label();
            this.dbsupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboUnit = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numProDiscount = new System.Windows.Forms.NumericUpDown();
            this.panelStockCat = new System.Windows.Forms.GroupBox();
            this.radioDirectSellProducts = new MetroFramework.Controls.MetroRadioButton();
            this.radioRawProducts = new MetroFramework.Controls.MetroRadioButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lblProCode = new System.Windows.Forms.Label();
            this.lblSupAddress = new System.Windows.Forms.Label();
            this.lblSupMobile = new System.Windows.Forms.Label();
            this.numSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboProName = new MetroFramework.Controls.MetroComboBox();
            this.dbproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtInvNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboSuppliers = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProDiscount)).BeginInit();
            this.panelStockCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbproductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.ActiveControl = null;
            this.btn_reset.Location = new System.Drawing.Point(1019, 653);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(109, 38);
            this.btn_reset.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_reset.TabIndex = 104;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reset.UseSelectable = true;
            this.btn_reset.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(1134, 653);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 38);
            this.btn_save.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_save.TabIndex = 103;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gridBill
            // 
            this.gridBill.AllowUserToAddRows = false;
            this.gridBill.AllowUserToResizeRows = false;
            this.gridBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBill.ColumnHeadersHeight = 40;
            this.gridBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proId,
            this.supId,
            this.stockCat,
            this.Product,
            this.qty,
            this.price,
            this.discount,
            this.unit,
            this.remove});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridBill.EnableHeadersVisualStyles = false;
            this.gridBill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBill.Location = new System.Drawing.Point(446, 73);
            this.gridBill.Name = "gridBill";
            this.gridBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBill.RowTemplate.Height = 40;
            this.gridBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBill.Size = new System.Drawing.Size(811, 522);
            this.gridBill.TabIndex = 100;
            this.gridBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_bill_CellClick);
            // 
            // proId
            // 
            this.proId.HeaderText = "proId";
            this.proId.Name = "proId";
            this.proId.Visible = false;
            // 
            // supId
            // 
            this.supId.HeaderText = "supId";
            this.supId.Name = "supId";
            this.supId.Visible = false;
            // 
            // stockCat
            // 
            this.stockCat.HeaderText = "Stock Category";
            this.stockCat.Name = "stockCat";
            this.stockCat.Visible = false;
            // 
            // Product
            // 
            this.Product.FillWeight = 355F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // qty
            // 
            this.qty.FillWeight = 89.54314F;
            this.qty.HeaderText = "Quentity";
            this.qty.Name = "qty";
            // 
            // price
            // 
            this.price.FillWeight = 89.54314F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // discount
            // 
            this.discount.FillWeight = 89.54314F;
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.Visible = false;
            // 
            // remove
            // 
            this.remove.HeaderText = "Remove";
            this.remove.Name = "remove";
            // 
            // btnAddToGrid
            // 
            this.btnAddToGrid.ActiveControl = null;
            this.btnAddToGrid.Location = new System.Drawing.Point(244, 653);
            this.btnAddToGrid.Name = "btnAddToGrid";
            this.btnAddToGrid.Size = new System.Drawing.Size(109, 38);
            this.btnAddToGrid.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddToGrid.TabIndex = 99;
            this.btnAddToGrid.Text = "Add to Table";
            this.btnAddToGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToGrid.UseSelectable = true;
            this.btnAddToGrid.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_supliers
            // 
            this.lbl_supliers.AutoSize = true;
            this.lbl_supliers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supliers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_supliers.Location = new System.Drawing.Point(26, 132);
            this.lbl_supliers.Name = "lbl_supliers";
            this.lbl_supliers.Size = new System.Drawing.Size(57, 17);
            this.lbl_supliers.TabIndex = 86;
            this.lbl_supliers.Text = "Supplier";
            // 
            // dbsupplierBindingSource
            // 
            this.dbsupplierBindingSource.DataSource = typeof(res_pos.Model.db_supplier);
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(19, 26);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(137, 23);
            this.lbl_heading.TabIndex = 84;
            this.lbl_heading.Text = "Product Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(247, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 117;
            this.label1.Text = "Unit";
            // 
            // comboUnit
            // 
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.ItemHeight = 23;
            this.comboUnit.Items.AddRange(new object[] {
            "Kilogream (kg)",
            "Gream (g)",
            "Litre (l)",
            "Mililitre (ml)",
            "Meter (m)"});
            this.comboUnit.Location = new System.Drawing.Point(244, 452);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(135, 29);
            this.comboUnit.TabIndex = 116;
            this.comboUnit.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Product Discount %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(26, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 108;
            this.label5.Text = "QTY";
            // 
            // numQty
            // 
            this.numQty.DecimalPlaces = 2;
            this.numQty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numQty.Location = new System.Drawing.Point(23, 452);
            this.numQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(199, 29);
            this.numQty.TabIndex = 107;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(397, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 592);
            this.panel1.TabIndex = 118;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(29, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 5);
            this.panel2.TabIndex = 119;
            // 
            // numProDiscount
            // 
            this.numProDiscount.DecimalPlaces = 2;
            this.numProDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProDiscount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numProDiscount.Location = new System.Drawing.Point(23, 594);
            this.numProDiscount.Name = "numProDiscount";
            this.numProDiscount.Size = new System.Drawing.Size(356, 29);
            this.numProDiscount.TabIndex = 121;
            // 
            // panelStockCat
            // 
            this.panelStockCat.Controls.Add(this.radioDirectSellProducts);
            this.panelStockCat.Controls.Add(this.radioRawProducts);
            this.panelStockCat.Location = new System.Drawing.Point(21, 260);
            this.panelStockCat.Name = "panelStockCat";
            this.panelStockCat.Size = new System.Drawing.Size(330, 53);
            this.panelStockCat.TabIndex = 122;
            this.panelStockCat.TabStop = false;
            this.panelStockCat.Text = "Select Stock Category";
            // 
            // radioDirectSellProducts
            // 
            this.radioDirectSellProducts.AutoSize = true;
            this.radioDirectSellProducts.Location = new System.Drawing.Point(173, 32);
            this.radioDirectSellProducts.Name = "radioDirectSellProducts";
            this.radioDirectSellProducts.Size = new System.Drawing.Size(125, 15);
            this.radioDirectSellProducts.TabIndex = 73;
            this.radioDirectSellProducts.Text = "Direct Sell Products";
            this.radioDirectSellProducts.UseSelectable = true;
            this.radioDirectSellProducts.CheckedChanged += new System.EventHandler(this.radioDirectSellProducts_CheckedChanged);
            // 
            // radioRawProducts
            // 
            this.radioRawProducts.AutoSize = true;
            this.radioRawProducts.Location = new System.Drawing.Point(10, 31);
            this.radioRawProducts.Name = "radioRawProducts";
            this.radioRawProducts.Size = new System.Drawing.Size(95, 15);
            this.radioRawProducts.TabIndex = 72;
            this.radioRawProducts.Text = "Raw Products";
            this.radioRawProducts.UseSelectable = true;
            this.radioRawProducts.CheckedChanged += new System.EventHandler(this.radioRawProducts_CheckedChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_name.Location = new System.Drawing.Point(13, 342);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(96, 16);
            this.lbl_name.TabIndex = 124;
            this.lbl_name.Text = "Product Name";
            // 
            // lblProCode
            // 
            this.lblProCode.AutoSize = true;
            this.lblProCode.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProCode.Location = new System.Drawing.Point(286, 378);
            this.lblProCode.Name = "lblProCode";
            this.lblProCode.Size = new System.Drawing.Size(91, 16);
            this.lblProCode.TabIndex = 123;
            this.lblProCode.Text = "Product Code";
            // 
            // lblSupAddress
            // 
            this.lblSupAddress.AutoSize = true;
            this.lblSupAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupAddress.Location = new System.Drawing.Point(26, 195);
            this.lblSupAddress.Name = "lblSupAddress";
            this.lblSupAddress.Size = new System.Drawing.Size(112, 16);
            this.lblSupAddress.TabIndex = 126;
            this.lblSupAddress.Text = "Supplier Address";
            // 
            // lblSupMobile
            // 
            this.lblSupMobile.AutoSize = true;
            this.lblSupMobile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupMobile.Location = new System.Drawing.Point(247, 195);
            this.lblSupMobile.Name = "lblSupMobile";
            this.lblSupMobile.Size = new System.Drawing.Size(106, 16);
            this.lblSupMobile.TabIndex = 127;
            this.lblSupMobile.Text = "Supplier Mobile";
            // 
            // numSellingPrice
            // 
            this.numSellingPrice.DecimalPlaces = 2;
            this.numSellingPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSellingPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numSellingPrice.Location = new System.Drawing.Point(217, 525);
            this.numSellingPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSellingPrice.Name = "numSellingPrice";
            this.numSellingPrice.Size = new System.Drawing.Size(162, 29);
            this.numSellingPrice.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(220, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 128;
            this.label3.Text = "Selling Price";
            // 
            // numBuyingPrice
            // 
            this.numBuyingPrice.DecimalPlaces = 2;
            this.numBuyingPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBuyingPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numBuyingPrice.Location = new System.Drawing.Point(23, 525);
            this.numBuyingPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBuyingPrice.Name = "numBuyingPrice";
            this.numBuyingPrice.Size = new System.Drawing.Size(162, 29);
            this.numBuyingPrice.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(26, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 130;
            this.label4.Text = "Buying Price";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(39, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 5);
            this.panel3.TabIndex = 132;
            // 
            // comboProName
            // 
            this.comboProName.DataSource = this.dbproductBindingSource;
            this.comboProName.DisplayMember = "pro_name";
            this.comboProName.FormattingEnabled = true;
            this.comboProName.ItemHeight = 23;
            this.comboProName.Location = new System.Drawing.Point(114, 329);
            this.comboProName.Name = "comboProName";
            this.comboProName.Size = new System.Drawing.Size(251, 29);
            this.comboProName.TabIndex = 135;
            this.comboProName.UseSelectable = true;
            this.comboProName.ValueMember = "Id";
            this.comboProName.SelectionChangeCommitted += new System.EventHandler(this.comboProName_SelectionChangeCommitted);
            // 
            // dbproductBindingSource
            // 
            this.dbproductBindingSource.DataSource = typeof(res_pos.Model.db_product);
            // 
            // txtInvNo
            // 
            // 
            // 
            // 
            this.txtInvNo.CustomButton.Image = null;
            this.txtInvNo.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtInvNo.CustomButton.Name = "";
            this.txtInvNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtInvNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvNo.CustomButton.TabIndex = 1;
            this.txtInvNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvNo.CustomButton.UseSelectable = true;
            this.txtInvNo.CustomButton.Visible = false;
            this.txtInvNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInvNo.Lines = new string[0];
            this.txtInvNo.Location = new System.Drawing.Point(21, 95);
            this.txtInvNo.MaxLength = 32767;
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.PasswordChar = '\0';
            this.txtInvNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvNo.SelectedText = "";
            this.txtInvNo.SelectionLength = 0;
            this.txtInvNo.SelectionStart = 0;
            this.txtInvNo.ShortcutsEnabled = true;
            this.txtInvNo.Size = new System.Drawing.Size(330, 25);
            this.txtInvNo.TabIndex = 136;
            this.txtInvNo.UseSelectable = true;
            this.txtInvNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 137;
            this.metroLabel1.Text = "Invoice No";
            // 
            // comboSuppliers
            // 
            this.comboSuppliers.DataSource = this.dbsupplierBindingSource;
            this.comboSuppliers.DisplayMember = "sup_name";
            this.comboSuppliers.FormattingEnabled = true;
            this.comboSuppliers.ItemHeight = 23;
            this.comboSuppliers.Location = new System.Drawing.Point(23, 152);
            this.comboSuppliers.Name = "comboSuppliers";
            this.comboSuppliers.Size = new System.Drawing.Size(330, 29);
            this.comboSuppliers.TabIndex = 85;
            this.comboSuppliers.UseSelectable = true;
            this.comboSuppliers.ValueMember = "Id";
            this.comboSuppliers.SelectionChangeCommitted += new System.EventHandler(this.comboSuppliers_SelectionChangeCommitted);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtInvNo);
            this.Controls.Add(this.comboProName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.numBuyingPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSellingPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSupMobile);
            this.Controls.Add(this.lblSupAddress);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lblProCode);
            this.Controls.Add(this.panelStockCat);
            this.Controls.Add(this.numProDiscount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gridBill);
            this.Controls.Add(this.btnAddToGrid);
            this.Controls.Add(this.lbl_supliers);
            this.Controls.Add(this.comboSuppliers);
            this.Controls.Add(this.lbl_heading);
            this.Name = "frmStock";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.raw_sale_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProDiscount)).EndInit();
            this.panelStockCat.ResumeLayout(false);
            this.panelStockCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbproductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_reset;
        private MetroFramework.Controls.MetroTile btn_save;
        private MetroFramework.Controls.MetroGrid gridBill;
        private MetroFramework.Controls.MetroTile btnAddToGrid;
        private System.Windows.Forms.Label lbl_supliers;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numProDiscount;
        private System.Windows.Forms.GroupBox panelStockCat;
        private MetroFramework.Controls.MetroRadioButton radioDirectSellProducts;
        private MetroFramework.Controls.MetroRadioButton radioRawProducts;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lblProCode;
        private System.Windows.Forms.Label lblSupAddress;
        private System.Windows.Forms.Label lblSupMobile;
        private System.Windows.Forms.NumericUpDown numSellingPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBuyingPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn proId;
        private System.Windows.Forms.DataGridViewTextBoxColumn supId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
        private MetroFramework.Controls.MetroComboBox comboProName;
        private System.Windows.Forms.BindingSource dbproductBindingSource;
        private System.Windows.Forms.BindingSource dbsupplierBindingSource;
        private MetroFramework.Controls.MetroTextBox txtInvNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboSuppliers;
    }
}