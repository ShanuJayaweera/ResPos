namespace res_pos.SystemModules.Dashboard
{
    partial class frmMainDashboard
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
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBasicData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(336, 34);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "[User Name]";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(461, 30);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(48, 158);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(75, 23);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(435, 158);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 23);
            this.btnBilling.TabIndex = 3;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "User Accounts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBasicData
            // 
            this.btnBasicData.Location = new System.Drawing.Point(162, 158);
            this.btnBasicData.Name = "btnBasicData";
            this.btnBasicData.Size = new System.Drawing.Size(87, 23);
            this.btnBasicData.TabIndex = 5;
            this.btnBasicData.Text = "Basic Data";
            this.btnBasicData.UseVisualStyleBackColor = true;
            this.btnBasicData.Click += new System.EventHandler(this.btnBasicData_Click);
            // 
            // frmMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 300);
            this.Controls.Add(this.btnBasicData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmMainDashboard";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmMainDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblUserName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBasicData;
    }
}