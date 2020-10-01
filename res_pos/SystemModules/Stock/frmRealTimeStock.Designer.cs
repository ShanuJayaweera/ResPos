namespace res_pos.SystemModules.Stock
{
    partial class frmRealTimeStock
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
            this.panelStockCat = new System.Windows.Forms.GroupBox();
            this.radioDirectSellProducts = new MetroFramework.Controls.MetroRadioButton();
            this.radioRawProducts = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboProductName = new MetroFramework.Controls.MetroComboBox();
            this.dbproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridRealTime = new MetroFramework.Controls.MetroGrid();
            this.proId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStockCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStockCat
            // 
            this.panelStockCat.Controls.Add(this.radioDirectSellProducts);
            this.panelStockCat.Controls.Add(this.radioRawProducts);
            this.panelStockCat.Location = new System.Drawing.Point(353, 60);
            this.panelStockCat.Name = "panelStockCat";
            this.panelStockCat.Size = new System.Drawing.Size(330, 53);
            this.panelStockCat.TabIndex = 148;
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(714, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 150;
            this.metroLabel1.Text = "Product Name";
            // 
            // comboProductName
            // 
            this.comboProductName.DataSource = this.dbproductBindingSource;
            this.comboProductName.DisplayMember = "pro_name";
            this.comboProductName.FormattingEnabled = true;
            this.comboProductName.ItemHeight = 23;
            this.comboProductName.Location = new System.Drawing.Point(714, 87);
            this.comboProductName.Name = "comboProductName";
            this.comboProductName.Size = new System.Drawing.Size(285, 29);
            this.comboProductName.TabIndex = 149;
            this.comboProductName.UseSelectable = true;
            this.comboProductName.ValueMember = "Id";
            // 
            // dbproductBindingSource
            // 
            this.dbproductBindingSource.DataSource = typeof(res_pos.Model.db_product);
            // 
            // gridRealTime
            // 
            this.gridRealTime.AllowUserToAddRows = false;
            this.gridRealTime.AllowUserToResizeRows = false;
            this.gridRealTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRealTime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRealTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRealTime.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRealTime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRealTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRealTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRealTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proId,
            this.proName,
            this.qty,
            this.buyingPrice,
            this.sellingPrice,
            this.discount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRealTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridRealTime.EnableHeadersVisualStyles = false;
            this.gridRealTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRealTime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRealTime.Location = new System.Drawing.Point(23, 138);
            this.gridRealTime.Name = "gridRealTime";
            this.gridRealTime.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRealTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridRealTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRealTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRealTime.Size = new System.Drawing.Size(1234, 559);
            this.gridRealTime.TabIndex = 151;
            // 
            // proId
            // 
            this.proId.HeaderText = "Product ID";
            this.proId.Name = "proId";
            this.proId.Visible = false;
            // 
            // proName
            // 
            this.proName.HeaderText = "Product Name";
            this.proName.Name = "proName";
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
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
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            // 
            // frmRealTimeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.gridRealTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboProductName);
            this.Controls.Add(this.panelStockCat);
            this.Name = "frmRealTimeStock";
            this.Load += new System.EventHandler(this.frmRealTimeStock_Load);
            this.panelStockCat.ResumeLayout(false);
            this.panelStockCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox panelStockCat;
        private MetroFramework.Controls.MetroRadioButton radioDirectSellProducts;
        private MetroFramework.Controls.MetroRadioButton radioRawProducts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboProductName;
        private System.Windows.Forms.BindingSource dbproductBindingSource;
        private MetroFramework.Controls.MetroGrid gridRealTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn proId;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
    }
}