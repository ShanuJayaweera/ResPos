namespace res_pos.SystemModules.Dashboard
{
    partial class frmStockDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockDashboard));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnViewStockByInvoiceId = new System.Windows.Forms.Button();
            this.btnViewRealTimeStock = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(434, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 62);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(24, 127);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(88, 23);
            this.btnAddStock.TabIndex = 5;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnViewStockByInvoiceId
            // 
            this.btnViewStockByInvoiceId.Location = new System.Drawing.Point(154, 127);
            this.btnViewStockByInvoiceId.Name = "btnViewStockByInvoiceId";
            this.btnViewStockByInvoiceId.Size = new System.Drawing.Size(157, 23);
            this.btnViewStockByInvoiceId.TabIndex = 6;
            this.btnViewStockByInvoiceId.Text = "View Stock By Invoice ID";
            this.btnViewStockByInvoiceId.UseVisualStyleBackColor = true;
            this.btnViewStockByInvoiceId.Click += new System.EventHandler(this.btnViewStockByInvoiceId_Click);
            // 
            // btnViewRealTimeStock
            // 
            this.btnViewRealTimeStock.Location = new System.Drawing.Point(339, 127);
            this.btnViewRealTimeStock.Name = "btnViewRealTimeStock";
            this.btnViewRealTimeStock.Size = new System.Drawing.Size(157, 23);
            this.btnViewRealTimeStock.TabIndex = 7;
            this.btnViewRealTimeStock.Text = "View Real Time Stock";
            this.btnViewRealTimeStock.UseVisualStyleBackColor = true;
            this.btnViewRealTimeStock.Click += new System.EventHandler(this.btnViewRealTimeStock_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(154, 180);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(157, 23);
            this.btnSupplier.TabIndex = 8;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // frmStockDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 238);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnViewRealTimeStock);
            this.Controls.Add(this.btnViewStockByInvoiceId);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnBack);
            this.Name = "frmStockDashboard";
            this.Resizable = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnViewStockByInvoiceId;
        private System.Windows.Forms.Button btnViewRealTimeStock;
        private System.Windows.Forms.Button btnSupplier;
    }
}