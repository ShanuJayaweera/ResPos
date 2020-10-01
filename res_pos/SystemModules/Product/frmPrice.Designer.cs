namespace res_pos.SystemModules.Product
{
    partial class frmPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrice));
            this.gridPrice = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lblBuyingPrice = new System.Windows.Forms.Label();
            this.lblProCode = new System.Windows.Forms.Label();
            this.radioRawProducts = new MetroFramework.Controls.MetroRadioButton();
            this.radioDirectSellProducts = new MetroFramework.Controls.MetroRadioButton();
            this.panelStockCat = new System.Windows.Forms.GroupBox();
            this.comboProName = new System.Windows.Forms.ComboBox();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.numBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.numSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).BeginInit();
            this.panelStockCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPrice
            // 
            this.gridPrice.AllowUserToAddRows = false;
            this.gridPrice.AllowUserToDeleteRows = false;
            this.gridPrice.AllowUserToResizeRows = false;
            this.gridPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPrice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPrice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPrice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPrice.ColumnHeadersHeight = 40;
            this.gridPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.proName,
            this.buyingPrice,
            this.sellingPrice,
            this.update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPrice.EnableHeadersVisualStyles = false;
            this.gridPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPrice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPrice.Location = new System.Drawing.Point(413, 109);
            this.gridPrice.Name = "gridPrice";
            this.gridPrice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPrice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPrice.RowTemplate.Height = 40;
            this.gridPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrice.Size = new System.Drawing.Size(482, 339);
            this.gridPrice.TabIndex = 65;
            this.gridPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrice_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // proName
            // 
            this.proName.HeaderText = "Product Name";
            this.proName.Name = "proName";
            // 
            // buyingPrice
            // 
            this.buyingPrice.HeaderText = "Buying Price";
            this.buyingPrice.Name = "buyingPrice";
            // 
            // sellingPrice
            // 
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.Name = "sellingPrice";
            // 
            // update
            // 
            this.update.FillWeight = 60F;
            this.update.HeaderText = "Update";
            this.update.Name = "update";
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(140, 389);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 47);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_clear.TabIndex = 64;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(243, 389);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 47);
            this.btn_save.TabIndex = 62;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(389, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 350);
            this.panel1.TabIndex = 59;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(10, 25);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(131, 23);
            this.lbl_heading.TabIndex = 58;
            this.lbl_heading.Text = "Product Price";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_name.Location = new System.Drawing.Point(11, 159);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(96, 16);
            this.lbl_name.TabIndex = 71;
            this.lbl_name.Text = "Product Name";
            // 
            // lblBuyingPrice
            // 
            this.lblBuyingPrice.AutoSize = true;
            this.lblBuyingPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyingPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBuyingPrice.Location = new System.Drawing.Point(11, 246);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(85, 16);
            this.lblBuyingPrice.TabIndex = 69;
            this.lblBuyingPrice.Text = "Buying Price";
            // 
            // lblProCode
            // 
            this.lblProCode.AutoSize = true;
            this.lblProCode.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProCode.Location = new System.Drawing.Point(281, 189);
            this.lblProCode.Name = "lblProCode";
            this.lblProCode.Size = new System.Drawing.Size(91, 16);
            this.lblProCode.TabIndex = 67;
            this.lblProCode.Text = "Product Code";
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
            // panelStockCat
            // 
            this.panelStockCat.Controls.Add(this.radioDirectSellProducts);
            this.panelStockCat.Controls.Add(this.radioRawProducts);
            this.panelStockCat.Location = new System.Drawing.Point(35, 77);
            this.panelStockCat.Name = "panelStockCat";
            this.panelStockCat.Size = new System.Drawing.Size(315, 53);
            this.panelStockCat.TabIndex = 74;
            this.panelStockCat.TabStop = false;
            this.panelStockCat.Text = "Select Stock Category";
            // 
            // comboProName
            // 
            this.comboProName.DisplayMember = "emp_type";
            this.comboProName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboProName.FormattingEnabled = true;
            this.comboProName.Location = new System.Drawing.Point(115, 151);
            this.comboProName.Name = "comboProName";
            this.comboProName.Size = new System.Drawing.Size(260, 29);
            this.comboProName.TabIndex = 75;
            this.comboProName.ValueMember = "id";
            this.comboProName.SelectedIndexChanged += new System.EventHandler(this.comboProName_SelectedIndexChanged);
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSellingPrice.Location = new System.Drawing.Point(11, 291);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(84, 16);
            this.lblSellingPrice.TabIndex = 76;
            this.lblSellingPrice.Text = "Selling Price";
            // 
            // numBuyingPrice
            // 
            this.numBuyingPrice.DecimalPlaces = 2;
            this.numBuyingPrice.Location = new System.Drawing.Point(115, 242);
            this.numBuyingPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBuyingPrice.Name = "numBuyingPrice";
            this.numBuyingPrice.Size = new System.Drawing.Size(146, 20);
            this.numBuyingPrice.TabIndex = 77;
            // 
            // numSellingPrice
            // 
            this.numSellingPrice.DecimalPlaces = 2;
            this.numSellingPrice.Location = new System.Drawing.Point(115, 287);
            this.numSellingPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSellingPrice.Name = "numSellingPrice";
            this.numSellingPrice.Size = new System.Drawing.Size(146, 20);
            this.numSellingPrice.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(11, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Please use one unit price";
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Location = new System.Drawing.Point(115, 332);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(146, 20);
            this.numDiscount.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Discount %";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(833, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 62);
            this.btnBack.TabIndex = 82;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 497);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSellingPrice);
            this.Controls.Add(this.numBuyingPrice);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.comboProName);
            this.Controls.Add(this.panelStockCat);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lblBuyingPrice);
            this.Controls.Add(this.lblProCode);
            this.Controls.Add(this.gridPrice);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_heading);
            this.Name = "frmPrice";
            this.Load += new System.EventHandler(this.frmPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).EndInit();
            this.panelStockCat.ResumeLayout(false);
            this.panelStockCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridPrice;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lblBuyingPrice;
        private System.Windows.Forms.Label lblProCode;
        private MetroFramework.Controls.MetroRadioButton radioRawProducts;
        private MetroFramework.Controls.MetroRadioButton radioDirectSellProducts;
        private System.Windows.Forms.GroupBox panelStockCat;
        private System.Windows.Forms.ComboBox comboProName;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.NumericUpDown numBuyingPrice;
        private System.Windows.Forms.NumericUpDown numSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}