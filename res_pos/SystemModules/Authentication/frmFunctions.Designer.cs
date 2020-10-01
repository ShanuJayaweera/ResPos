namespace res_pos.SystemModules.Authentication
{
    partial class frmFunctions
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
            this.lbl_heading = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFuncName = new System.Windows.Forms.TextBox();
            this.gridFunc = new MetroFramework.Controls.MetroGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.retToDash = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFormName = new MetroFramework.Controls.MetroComboBox();
            this.authfunctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysformsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authfunctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysformsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_heading.Location = new System.Drawing.Point(23, 26);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(145, 23);
            this.lbl_heading.TabIndex = 100;
            this.lbl_heading.Text = "Auth Functions";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(225, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 39);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(29, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 16);
            this.lblName.TabIndex = 98;
            this.lblName.Text = "Function Name";
            // 
            // txtFuncName
            // 
            this.txtFuncName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFuncName.Location = new System.Drawing.Point(27, 95);
            this.txtFuncName.Name = "txtFuncName";
            this.txtFuncName.Size = new System.Drawing.Size(308, 27);
            this.txtFuncName.TabIndex = 97;
            // 
            // gridFunc
            // 
            this.gridFunc.AllowUserToAddRows = false;
            this.gridFunc.AllowUserToDeleteRows = false;
            this.gridFunc.AllowUserToResizeRows = false;
            this.gridFunc.AutoGenerateColumns = false;
            this.gridFunc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.funcnameDataGridViewTextBoxColumn,
            this.update});
            this.gridFunc.DataSource = this.authfunctionsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFunc.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridFunc.EnableHeadersVisualStyles = false;
            this.gridFunc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridFunc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridFunc.Location = new System.Drawing.Point(365, 112);
            this.gridFunc.Name = "gridFunc";
            this.gridFunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridFunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFunc.Size = new System.Drawing.Size(394, 254);
            this.gridFunc.TabIndex = 96;
            this.gridFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFunc_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(23, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 101;
            this.btnAdd.Text = "Add Function";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // retToDash
            // 
            this.retToDash.ActiveControl = null;
            this.retToDash.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.retToDash.Location = new System.Drawing.Point(612, 54);
            this.retToDash.Name = "retToDash";
            this.retToDash.Size = new System.Drawing.Size(147, 37);
            this.retToDash.TabIndex = 102;
            this.retToDash.Text = "Return to dashboard";
            this.retToDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.retToDash.UseSelectable = true;
            this.retToDash.Click += new System.EventHandler(this.retToDash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(26, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Form Name";
            // 
            // comboFormName
            // 
            this.comboFormName.DataSource = this.sysformsBindingSource;
            this.comboFormName.DisplayMember = "form_name";
            this.comboFormName.FormattingEnabled = true;
            this.comboFormName.ItemHeight = 23;
            this.comboFormName.Location = new System.Drawing.Point(23, 169);
            this.comboFormName.Name = "comboFormName";
            this.comboFormName.Size = new System.Drawing.Size(312, 29);
            this.comboFormName.TabIndex = 105;
            this.comboFormName.UseSelectable = true;
            this.comboFormName.ValueMember = "Id";
            // 
            // authfunctionsBindingSource
            // 
            this.authfunctionsBindingSource.DataSource = typeof(res_pos.Model.auth_functions);
            // 
            // sysformsBindingSource
            // 
            this.sysformsBindingSource.DataSource = typeof(res_pos.Model.sys_forms);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // funcnameDataGridViewTextBoxColumn
            // 
            this.funcnameDataGridViewTextBoxColumn.DataPropertyName = "func_name";
            this.funcnameDataGridViewTextBoxColumn.HeaderText = "Function Name";
            this.funcnameDataGridViewTextBoxColumn.Name = "funcnameDataGridViewTextBoxColumn";
            this.funcnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // update
            // 
            this.update.HeaderText = "Update";
            this.update.Name = "update";
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 389);
            this.Controls.Add(this.comboFormName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retToDash);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtFuncName);
            this.Controls.Add(this.gridFunc);
            this.Name = "frmFunctions";
            this.Load += new System.EventHandler(this.frmFunctions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authfunctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysformsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFuncName;
        private MetroFramework.Controls.MetroGrid gridFunc;
        private System.Windows.Forms.BindingSource authfunctionsBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private MetroFramework.Controls.MetroTile retToDash;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboFormName;
        private System.Windows.Forms.BindingSource sysformsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn update;
    }
}