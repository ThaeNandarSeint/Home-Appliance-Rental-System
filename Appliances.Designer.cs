namespace House_Appliance_Rental_System
{
    partial class Appliances
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCustomers = new System.Windows.Forms.Label();
            this.LblAdmins = new System.Windows.Forms.Label();
            this.LblRents = new System.Windows.Forms.Label();
            this.LblApplianceTypes = new System.Windows.Forms.Label();
            this.LblLogout = new System.Windows.Forms.Label();
            this.LblAppliances = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.PictureBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(268, 172);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1062, 611);
            this.dataGrid.TabIndex = 11;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblCustomers);
            this.panel1.Controls.Add(this.LblAdmins);
            this.panel1.Controls.Add(this.LblRents);
            this.panel1.Controls.Add(this.LblApplianceTypes);
            this.panel1.Controls.Add(this.LblLogout);
            this.panel1.Controls.Add(this.LblAppliances);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 776);
            this.panel1.TabIndex = 9;
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
            // LblCustomers
            // 
            this.LblCustomers.AutoSize = true;
            this.LblCustomers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomers.ForeColor = System.Drawing.Color.Transparent;
            this.LblCustomers.Location = new System.Drawing.Point(6, 575);
            this.LblCustomers.Name = "LblCustomers";
            this.LblCustomers.Padding = new System.Windows.Forms.Padding(55, 10, 55, 10);
            this.LblCustomers.Size = new System.Drawing.Size(215, 43);
            this.LblCustomers.TabIndex = 6;
            this.LblCustomers.Text = "Customers";
            this.LblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCustomers.Click += new System.EventHandler(this.LblCustomers_Click);
            // 
            // LblAdmins
            // 
            this.LblAdmins.AutoSize = true;
            this.LblAdmins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmins.ForeColor = System.Drawing.Color.Transparent;
            this.LblAdmins.Location = new System.Drawing.Point(6, 478);
            this.LblAdmins.Name = "LblAdmins";
            this.LblAdmins.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.LblAdmins.Size = new System.Drawing.Size(214, 43);
            this.LblAdmins.TabIndex = 5;
            this.LblAdmins.Text = "Admins";
            this.LblAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAdmins.Click += new System.EventHandler(this.LblAdmins_Click);
            // 
            // LblRents
            // 
            this.LblRents.AutoSize = true;
            this.LblRents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRents.ForeColor = System.Drawing.Color.Transparent;
            this.LblRents.Location = new System.Drawing.Point(8, 387);
            this.LblRents.Name = "LblRents";
            this.LblRents.Padding = new System.Windows.Forms.Padding(75, 10, 75, 10);
            this.LblRents.Size = new System.Drawing.Size(211, 43);
            this.LblRents.TabIndex = 4;
            this.LblRents.Text = "Rents";
            this.LblRents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRents.Click += new System.EventHandler(this.LblRents_Click);
            // 
            // LblApplianceTypes
            // 
            this.LblApplianceTypes.AutoSize = true;
            this.LblApplianceTypes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplianceTypes.ForeColor = System.Drawing.Color.Transparent;
            this.LblApplianceTypes.Location = new System.Drawing.Point(6, 302);
            this.LblApplianceTypes.Name = "LblApplianceTypes";
            this.LblApplianceTypes.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.LblApplianceTypes.Size = new System.Drawing.Size(214, 43);
            this.LblApplianceTypes.TabIndex = 3;
            this.LblApplianceTypes.Text = "Appliance Types";
            this.LblApplianceTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblApplianceTypes.Click += new System.EventHandler(this.LblApplianceTypes_Click);
            // 
            // LblLogout
            // 
            this.LblLogout.AutoSize = true;
            this.LblLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogout.ForeColor = System.Drawing.Color.Transparent;
            this.LblLogout.Location = new System.Drawing.Point(7, 672);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.LblLogout.Size = new System.Drawing.Size(210, 43);
            this.LblLogout.TabIndex = 2;
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
            this.LblAppliances.Location = new System.Drawing.Point(5, 209);
            this.LblAppliances.Name = "LblAppliances";
            this.LblAppliances.Padding = new System.Windows.Forms.Padding(55, 10, 55, 10);
            this.LblAppliances.Size = new System.Drawing.Size(215, 43);
            this.LblAppliances.TabIndex = 1;
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
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.Black;
            this.BtnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCreate.Location = new System.Drawing.Point(1166, 102);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(134, 42);
            this.BtnCreate.TabIndex = 15;
            this.BtnCreate.Text = "Create +";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(660, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 38);
            this.label9.TabIndex = 56;
            this.label9.Text = "Appliances List";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::House_Appliance_Rental_System.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(345, 105);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(53, 39);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRefresh.TabIndex = 57;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Black;
            this.BtnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEdit.Location = new System.Drawing.Point(997, 103);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(134, 42);
            this.BtnEdit.TabIndex = 58;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Black;
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.BtnDelete.Location = new System.Drawing.Point(828, 104);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(134, 42);
            this.BtnDelete.TabIndex = 59;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Appliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appliances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appliances";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblCustomers;
        private System.Windows.Forms.Label LblAdmins;
        private System.Windows.Forms.Label LblRents;
        private System.Windows.Forms.Label LblApplianceTypes;
        private System.Windows.Forms.Label LblLogout;
        private System.Windows.Forms.Label LblAppliances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox BtnRefresh;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
    }
}