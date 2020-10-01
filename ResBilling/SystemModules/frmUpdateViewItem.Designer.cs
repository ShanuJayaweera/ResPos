namespace ResBilling.SystemModules
{
    partial class frmUpdateViewItem
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
            this.numDis = new System.Windows.Forms.NumericUpDown();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.label3 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_product_code = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProCode = new MetroFramework.Controls.MetroTextBox();
            this.txtProName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numDis
            // 
            this.numDis.DecimalPlaces = 2;
            this.numDis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numDis.Location = new System.Drawing.Point(530, 145);
            this.numDis.Name = "numDis";
            this.numDis.Size = new System.Drawing.Size(120, 29);
            this.numDis.TabIndex = 44;
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_update.Location = new System.Drawing.Point(530, 207);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(120, 40);
            this.btn_update.TabIndex = 43;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(394, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Item Discount";
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numQty.Location = new System.Drawing.Point(530, 81);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 29);
            this.numQty.TabIndex = 41;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_name.Location = new System.Drawing.Point(394, 85);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(73, 21);
            this.lbl_name.TabIndex = 40;
            this.lbl_name.Text = "Quentity";
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_price.Location = new System.Drawing.Point(31, 176);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(122, 23);
            this.lbl_price.TabIndex = 39;
            this.lbl_price.Text = "Price";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_product_name.Location = new System.Drawing.Point(31, 129);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(122, 23);
            this.lbl_product_name.TabIndex = 38;
            this.lbl_product_name.Text = "Product Name";
            this.lbl_product_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_product_code
            // 
            this.lbl_product_code.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_code.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_product_code.Location = new System.Drawing.Point(31, 83);
            this.lbl_product_code.Name = "lbl_product_code";
            this.lbl_product_code.Size = new System.Drawing.Size(108, 23);
            this.lbl_product_code.TabIndex = 37;
            this.lbl_product_code.Text = "Product Code";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(33, 23);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(120, 23);
            this.lbl_heading.TabIndex = 36;
            this.lbl_heading.Text = "Update Item";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numPrice.Location = new System.Drawing.Point(159, 176);
            this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.ReadOnly = true;
            this.numPrice.Size = new System.Drawing.Size(178, 29);
            this.numPrice.TabIndex = 45;
            // 
            // txtProCode
            // 
            // 
            // 
            // 
            this.txtProCode.CustomButton.Image = null;
            this.txtProCode.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtProCode.CustomButton.Name = "";
            this.txtProCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProCode.CustomButton.TabIndex = 1;
            this.txtProCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProCode.CustomButton.UseSelectable = true;
            this.txtProCode.CustomButton.Visible = false;
            this.txtProCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProCode.Lines = new string[0];
            this.txtProCode.Location = new System.Drawing.Point(159, 81);
            this.txtProCode.MaxLength = 32767;
            this.txtProCode.Name = "txtProCode";
            this.txtProCode.PasswordChar = '\0';
            this.txtProCode.ReadOnly = true;
            this.txtProCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProCode.SelectedText = "";
            this.txtProCode.SelectionLength = 0;
            this.txtProCode.SelectionStart = 0;
            this.txtProCode.ShortcutsEnabled = true;
            this.txtProCode.Size = new System.Drawing.Size(178, 25);
            this.txtProCode.TabIndex = 46;
            this.txtProCode.UseSelectable = true;
            this.txtProCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProName
            // 
            // 
            // 
            // 
            this.txtProName.CustomButton.Image = null;
            this.txtProName.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtProName.CustomButton.Name = "";
            this.txtProName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProName.CustomButton.TabIndex = 1;
            this.txtProName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProName.CustomButton.UseSelectable = true;
            this.txtProName.CustomButton.Visible = false;
            this.txtProName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProName.Lines = new string[0];
            this.txtProName.Location = new System.Drawing.Point(159, 129);
            this.txtProName.MaxLength = 32767;
            this.txtProName.Name = "txtProName";
            this.txtProName.PasswordChar = '\0';
            this.txtProName.ReadOnly = true;
            this.txtProName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProName.SelectedText = "";
            this.txtProName.SelectionLength = 0;
            this.txtProName.SelectionStart = 0;
            this.txtProName.ShortcutsEnabled = true;
            this.txtProName.Size = new System.Drawing.Size(178, 25);
            this.txtProName.TabIndex = 47;
            this.txtProName.UseSelectable = true;
            this.txtProName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmUpdateViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 282);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProCode);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numDis);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.lbl_product_code);
            this.Controls.Add(this.lbl_heading);
            this.Name = "frmUpdateViewItem";
            this.Load += new System.EventHandler(this.frmUpdateViewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDis;
        private MetroFramework.Controls.MetroTile btn_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Label lbl_product_code;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.NumericUpDown numPrice;
        private MetroFramework.Controls.MetroTextBox txtProCode;
        private MetroFramework.Controls.MetroTextBox txtProName;
    }
}