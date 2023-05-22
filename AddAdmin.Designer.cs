namespace House_Appliance_Rental_System
{
    partial class AddAdmin
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
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnHide = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.BtnShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShow)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 776);
            this.panel1.TabIndex = 63;
            // 
            // LblCustomers
            // 
            this.LblCustomers.AutoSize = true;
            this.LblCustomers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomers.ForeColor = System.Drawing.Color.Transparent;
            this.LblCustomers.Location = new System.Drawing.Point(6, 560);
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
            this.LblAdmins.BackColor = System.Drawing.Color.White;
            this.LblAdmins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmins.ForeColor = System.Drawing.Color.Black;
            this.LblAdmins.Location = new System.Drawing.Point(6, 463);
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
            this.LblRents.Location = new System.Drawing.Point(8, 372);
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
            this.LblApplianceTypes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplianceTypes.ForeColor = System.Drawing.Color.Transparent;
            this.LblApplianceTypes.Location = new System.Drawing.Point(6, 287);
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
            this.LblLogout.Location = new System.Drawing.Point(7, 657);
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
            this.LblAppliances.BackColor = System.Drawing.Color.Black;
            this.LblAppliances.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppliances.ForeColor = System.Drawing.Color.White;
            this.LblAppliances.Location = new System.Drawing.Point(5, 194);
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
            this.label14.Location = new System.Drawing.Point(663, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 38);
            this.label14.TabIndex = 51;
            this.label14.Text = "Add Admin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(493, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 26);
            this.label12.TabIndex = 46;
            this.label12.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(498, 398);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(571, 34);
            this.tbEmail.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(493, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Username";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(498, 273);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(571, 34);
            this.tbName.TabIndex = 43;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.Black;
            this.BtnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCreate.Location = new System.Drawing.Point(1103, 623);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(134, 42);
            this.BtnCreate.TabIndex = 38;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Black;
            this.BtnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBack.Location = new System.Drawing.Point(1103, 136);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(134, 42);
            this.BtnBack.TabIndex = 37;
            this.BtnBack.Text = "< Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnHide
            // 
            this.BtnHide.BackColor = System.Drawing.Color.Transparent;
            this.BtnHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnHide.Image = global::House_Appliance_Rental_System.Properties.Resources.hidden;
            this.BtnHide.Location = new System.Drawing.Point(1032, 524);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(37, 34);
            this.BtnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHide.TabIndex = 66;
            this.BtnHide.TabStop = false;
            this.BtnHide.UseWaitCursor = true;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(495, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 65;
            this.label3.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(498, 524);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(535, 34);
            this.tbPassword.TabIndex = 64;
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.Transparent;
            this.BtnShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnShow.Image = global::House_Appliance_Rental_System.Properties.Resources.eye;
            this.BtnShow.Location = new System.Drawing.Point(1032, 524);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(37, 34);
            this.BtnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnShow.TabIndex = 67;
            this.BtnShow.TabStop = false;
            this.BtnShow.UseWaitCursor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.BtnHide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShow)).EndInit();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox BtnHide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox BtnShow;
    }
}