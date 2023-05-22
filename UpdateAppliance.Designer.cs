namespace House_Appliance_Rental_System
{
    partial class UpdateAppliance
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCustomers = new System.Windows.Forms.Label();
            this.LblAdmins = new System.Windows.Forms.Label();
            this.LblRents = new System.Windows.Forms.Label();
            this.LblApplianceTypes = new System.Windows.Forms.Label();
            this.LblLogout = new System.Windows.Forms.Label();
            this.LblAppliances = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTypical = new System.Windows.Forms.TextBox();
            this.applianceTypesSelect = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPower = new System.Windows.Forms.TextBox();
            this.tbStocks = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.tbEnergy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMonthlyCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::House_Appliance_Rental_System.Properties.Resources.Appliances;
            this.pictureBox1.Location = new System.Drawing.Point(52, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LblCustomers);
            this.panel1.Controls.Add(this.LblAdmins);
            this.panel1.Controls.Add(this.LblRents);
            this.panel1.Controls.Add(this.LblApplianceTypes);
            this.panel1.Controls.Add(this.LblLogout);
            this.panel1.Controls.Add(this.LblAppliances);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 776);
            this.panel1.TabIndex = 38;
            // 
            // LblCustomers
            // 
            this.LblCustomers.AutoSize = true;
            this.LblCustomers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomers.ForeColor = System.Drawing.Color.Transparent;
            this.LblCustomers.Location = new System.Drawing.Point(6, 559);
            this.LblCustomers.Name = "LblCustomers";
            this.LblCustomers.Padding = new System.Windows.Forms.Padding(55, 10, 55, 10);
            this.LblCustomers.Size = new System.Drawing.Size(215, 43);
            this.LblCustomers.TabIndex = 12;
            this.LblCustomers.Text = "Customers";
            this.LblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCustomers.Click += new System.EventHandler(this.LblCustomers_Click);
            // 
            // LblAdmins
            // 
            this.LblAdmins.AutoSize = true;
            this.LblAdmins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmins.ForeColor = System.Drawing.Color.Transparent;
            this.LblAdmins.Location = new System.Drawing.Point(6, 462);
            this.LblAdmins.Name = "LblAdmins";
            this.LblAdmins.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.LblAdmins.Size = new System.Drawing.Size(214, 43);
            this.LblAdmins.TabIndex = 11;
            this.LblAdmins.Text = "Admins";
            this.LblAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAdmins.Click += new System.EventHandler(this.LblAdmins_Click);
            // 
            // LblRents
            // 
            this.LblRents.AutoSize = true;
            this.LblRents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRents.ForeColor = System.Drawing.Color.Transparent;
            this.LblRents.Location = new System.Drawing.Point(8, 371);
            this.LblRents.Name = "LblRents";
            this.LblRents.Padding = new System.Windows.Forms.Padding(75, 10, 75, 10);
            this.LblRents.Size = new System.Drawing.Size(211, 43);
            this.LblRents.TabIndex = 10;
            this.LblRents.Text = "Rents";
            this.LblRents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRents.Click += new System.EventHandler(this.LblRents_Click);
            // 
            // LblApplianceTypes
            // 
            this.LblApplianceTypes.AutoSize = true;
            this.LblApplianceTypes.BackColor = System.Drawing.Color.Black;
            this.LblApplianceTypes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplianceTypes.ForeColor = System.Drawing.Color.White;
            this.LblApplianceTypes.Location = new System.Drawing.Point(6, 286);
            this.LblApplianceTypes.Name = "LblApplianceTypes";
            this.LblApplianceTypes.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.LblApplianceTypes.Size = new System.Drawing.Size(214, 43);
            this.LblApplianceTypes.TabIndex = 9;
            this.LblApplianceTypes.Text = "Appliance Types";
            this.LblApplianceTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblApplianceTypes.Click += new System.EventHandler(this.LblApplianceTypes_Click);
            // 
            // LblLogout
            // 
            this.LblLogout.AutoSize = true;
            this.LblLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogout.ForeColor = System.Drawing.Color.Transparent;
            this.LblLogout.Location = new System.Drawing.Point(7, 656);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.LblLogout.Size = new System.Drawing.Size(210, 43);
            this.LblLogout.TabIndex = 8;
            this.LblLogout.Text = "Logout";
            this.LblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            // 
            // LblAppliances
            // 
            this.LblAppliances.AutoSize = true;
            this.LblAppliances.BackColor = System.Drawing.Color.White;
            this.LblAppliances.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppliances.ForeColor = System.Drawing.Color.Black;
            this.LblAppliances.Location = new System.Drawing.Point(5, 193);
            this.LblAppliances.Name = "LblAppliances";
            this.LblAppliances.Padding = new System.Windows.Forms.Padding(55, 10, 55, 10);
            this.LblAppliances.Size = new System.Drawing.Size(215, 43);
            this.LblAppliances.TabIndex = 7;
            this.LblAppliances.Text = "Appliances";
            this.LblAppliances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAppliances.Click += new System.EventHandler(this.LblAppliances_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(657, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(290, 38);
            this.label14.TabIndex = 53;
            this.label14.Text = "Update Appliance";
            // 
            // tbTypical
            // 
            this.tbTypical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTypical.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTypical.ForeColor = System.Drawing.Color.Black;
            this.tbTypical.Location = new System.Drawing.Point(837, 357);
            this.tbTypical.Name = "tbTypical";
            this.tbTypical.Size = new System.Drawing.Size(406, 34);
            this.tbTypical.TabIndex = 52;
            // 
            // applianceTypesSelect
            // 
            this.applianceTypesSelect.FormattingEnabled = true;
            this.applianceTypesSelect.Location = new System.Drawing.Point(837, 496);
            this.applianceTypesSelect.Name = "applianceTypesSelect";
            this.applianceTypesSelect.Size = new System.Drawing.Size(406, 24);
            this.applianceTypesSelect.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(841, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 26);
            this.label13.TabIndex = 50;
            this.label13.Text = "Appliance Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(841, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 26);
            this.label11.TabIndex = 49;
            this.label11.Text = "Typical Usage";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(841, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 26);
            this.label12.TabIndex = 48;
            this.label12.Text = "Appliance Description";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.Color.Black;
            this.tbDescription.Location = new System.Drawing.Point(837, 233);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(406, 34);
            this.tbDescription.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(358, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 26);
            this.label8.TabIndex = 46;
            this.label8.Text = "Appliance Name";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(354, 236);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(406, 34);
            this.tbName.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(358, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "Stocks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(358, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 26);
            this.label10.TabIndex = 43;
            this.label10.Text = "Power Usage";
            // 
            // tbPower
            // 
            this.tbPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPower.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPower.ForeColor = System.Drawing.Color.Black;
            this.tbPower.Location = new System.Drawing.Point(354, 356);
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(406, 34);
            this.tbPower.TabIndex = 42;
            // 
            // tbStocks
            // 
            this.tbStocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStocks.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStocks.ForeColor = System.Drawing.Color.Black;
            this.tbStocks.Location = new System.Drawing.Point(354, 488);
            this.tbStocks.Name = "tbStocks";
            this.tbStocks.Size = new System.Drawing.Size(406, 34);
            this.tbStocks.TabIndex = 41;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Black;
            this.BtnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEdit.Location = new System.Drawing.Point(1109, 712);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(134, 42);
            this.BtnEdit.TabIndex = 40;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Black;
            this.BtnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBack.Location = new System.Drawing.Point(1109, 108);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(134, 42);
            this.BtnBack.TabIndex = 39;
            this.BtnBack.Text = "< Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // tbEnergy
            // 
            this.tbEnergy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnergy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnergy.ForeColor = System.Drawing.Color.Black;
            this.tbEnergy.Location = new System.Drawing.Point(837, 615);
            this.tbEnergy.Name = "tbEnergy";
            this.tbEnergy.Size = new System.Drawing.Size(406, 34);
            this.tbEnergy.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(841, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Energy Consumption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(358, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "Monthly Cost";
            // 
            // tbMonthlyCost
            // 
            this.tbMonthlyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMonthlyCost.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonthlyCost.ForeColor = System.Drawing.Color.Black;
            this.tbMonthlyCost.Location = new System.Drawing.Point(354, 614);
            this.tbMonthlyCost.Name = "tbMonthlyCost";
            this.tbMonthlyCost.Size = new System.Drawing.Size(406, 34);
            this.tbMonthlyCost.TabIndex = 54;
            // 
            // UpdateAppliance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.tbEnergy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMonthlyCost);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbTypical);
            this.Controls.Add(this.applianceTypesSelect);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPower);
            this.Controls.Add(this.tbStocks);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateAppliance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAppliance";
            this.Load += new System.EventHandler(this.UpdateAppliance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCustomers;
        private System.Windows.Forms.Label LblAdmins;
        private System.Windows.Forms.Label LblRents;
        private System.Windows.Forms.Label LblApplianceTypes;
        private System.Windows.Forms.Label LblLogout;
        private System.Windows.Forms.Label LblAppliances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTypical;
        private System.Windows.Forms.ComboBox applianceTypesSelect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPower;
        private System.Windows.Forms.TextBox tbStocks;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox tbEnergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMonthlyCost;
    }
}