namespace ResBilling.SystemModules
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
            this.txt_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_product_code = new System.Windows.Forms.Label();
            this.txtProCode = new MetroFramework.Controls.MetroTextBox();
            this.txtProPrice = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_discount
            // 
            this.txt_discount.DecimalPlaces = 2;
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_discount.Location = new System.Drawing.Point(519, 148);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(120, 29);
            this.txt_discount.TabIndex = 54;
            this.txt_discount.ValueChanged += new System.EventHandler(this.txt_discount_ValueChanged);
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_update.Location = new System.Drawing.Point(488, 215);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(151, 40);
            this.btn_update.TabIndex = 53;
            this.btn_update.Text = "Update Invoice";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(383, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Item Discount";
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_qty.Location = new System.Drawing.Point(519, 90);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(120, 29);
            this.txt_qty.TabIndex = 51;
            this.txt_qty.ValueChanged += new System.EventHandler(this.txt_qty_ValueChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_name.Location = new System.Drawing.Point(383, 94);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(73, 21);
            this.lbl_name.TabIndex = 50;
            this.lbl_name.Text = "Quentity";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(22, 42);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(127, 23);
            this.lbl_heading.TabIndex = 46;
            this.lbl_heading.Text = "Split Bill Item";
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_price.Location = new System.Drawing.Point(22, 152);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(110, 23);
            this.lbl_price.TabIndex = 55;
            this.lbl_price.Text = "Price - Rs: ";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_product_code
            // 
            this.lbl_product_code.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_code.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_product_code.Location = new System.Drawing.Point(20, 104);
            this.lbl_product_code.Name = "lbl_product_code";
            this.lbl_product_code.Size = new System.Drawing.Size(112, 23);
            this.lbl_product_code.TabIndex = 47;
            this.lbl_product_code.Text = "Product Code";
            // 
            // txtProCode
            // 
            // 
            // 
            // 
            this.txtProCode.CustomButton.Image = null;
            this.txtProCode.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtProCode.CustomButton.Name = "";
            this.txtProCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProCode.CustomButton.TabIndex = 1;
            this.txtProCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProCode.CustomButton.UseSelectable = true;
            this.txtProCode.CustomButton.Visible = false;
            this.txtProCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProCode.Lines = new string[0];
            this.txtProCode.Location = new System.Drawing.Point(157, 102);
            this.txtProCode.MaxLength = 32767;
            this.txtProCode.Name = "txtProCode";
            this.txtProCode.PasswordChar = '\0';
            this.txtProCode.ReadOnly = true;
            this.txtProCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProCode.SelectedText = "";
            this.txtProCode.SelectionLength = 0;
            this.txtProCode.SelectionStart = 0;
            this.txtProCode.ShortcutsEnabled = true;
            this.txtProCode.Size = new System.Drawing.Size(186, 25);
            this.txtProCode.TabIndex = 56;
            this.txtProCode.UseSelectable = true;
            this.txtProCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProPrice
            // 
            // 
            // 
            // 
            this.txtProPrice.CustomButton.Image = null;
            this.txtProPrice.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtProPrice.CustomButton.Name = "";
            this.txtProPrice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProPrice.CustomButton.TabIndex = 1;
            this.txtProPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProPrice.CustomButton.UseSelectable = true;
            this.txtProPrice.CustomButton.Visible = false;
            this.txtProPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProPrice.Lines = new string[0];
            this.txtProPrice.Location = new System.Drawing.Point(157, 152);
            this.txtProPrice.MaxLength = 32767;
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.PasswordChar = '\0';
            this.txtProPrice.ReadOnly = true;
            this.txtProPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProPrice.SelectedText = "";
            this.txtProPrice.SelectionLength = 0;
            this.txtProPrice.SelectionStart = 0;
            this.txtProPrice.ShortcutsEnabled = true;
            this.txtProPrice.Size = new System.Drawing.Size(186, 25);
            this.txtProPrice.TabIndex = 58;
            this.txtProPrice.UseSelectable = true;
            this.txtProPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 287);
            this.Controls.Add(this.txtProPrice);
            this.Controls.Add(this.txtProCode);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_product_code);
            this.Controls.Add(this.lbl_heading);
            this.Name = "frmProduct";
            this.Load += new System.EventHandler(this.frmSplitBillPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txt_discount;
        private MetroFramework.Controls.MetroTile btn_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_product_code;
        private MetroFramework.Controls.MetroTextBox txtProCode;
        private MetroFramework.Controls.MetroTextBox txtProPrice;
    }
}