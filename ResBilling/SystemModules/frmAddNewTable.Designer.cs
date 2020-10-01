namespace ResBilling.SystemModules
{
    partial class frmAddNewTable
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
            this.lbl_heading = new System.Windows.Forms.Label();
            this.btnAddTable = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTblName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(31, 25);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(145, 23);
            this.lbl_heading.TabIndex = 12;
            this.lbl_heading.Text = "Add New Table";
            // 
            // btnAddTable
            // 
            this.btnAddTable.ActiveControl = null;
            this.btnAddTable.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddTable.Location = new System.Drawing.Point(264, 145);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(132, 43);
            this.btnAddTable.TabIndex = 11;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTable.UseSelectable = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Table Name";
            // 
            // txtTblName
            // 
            this.txtTblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTblName.Location = new System.Drawing.Point(132, 91);
            this.txtTblName.Name = "txtTblName";
            this.txtTblName.Size = new System.Drawing.Size(264, 29);
            this.txtTblName.TabIndex = 9;
            // 
            // frmAddNewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 212);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTblName);
            this.Name = "frmAddNewTable";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private MetroFramework.Controls.MetroTile btnAddTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTblName;
    }
}