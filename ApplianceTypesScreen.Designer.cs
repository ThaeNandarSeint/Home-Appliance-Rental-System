namespace House_Appliance_Rental_System
{
    partial class ApplianceTypesScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLogout = new System.Windows.Forms.Label();
            this.LblApplianceTypes = new System.Windows.Forms.Label();
            this.LblCart = new System.Windows.Forms.Label();
            this.LblRents = new System.Windows.Forms.Label();
            this.LblAppliances = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.PictureBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LblLogout);
            this.panel1.Controls.Add(this.LblApplianceTypes);
            this.panel1.Controls.Add(this.LblCart);
            this.panel1.Controls.Add(this.LblRents);
            this.panel1.Controls.Add(this.LblAppliances);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 74);
            this.panel1.TabIndex = 61;
            // 
            // LblLogout
            // 
            this.LblLogout.AutoSize = true;
            this.LblLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogout.ForeColor = System.Drawing.Color.Transparent;
            this.LblLogout.Location = new System.Drawing.Point(1195, 6);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblLogout.Size = new System.Drawing.Size(90, 63);
            this.LblLogout.TabIndex = 67;
            this.LblLogout.Text = "Logout";
            this.LblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            // 
            // LblApplianceTypes
            // 
            this.LblApplianceTypes.AutoSize = true;
            this.LblApplianceTypes.BackColor = System.Drawing.Color.White;
            this.LblApplianceTypes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplianceTypes.ForeColor = System.Drawing.Color.Black;
            this.LblApplianceTypes.Location = new System.Drawing.Point(184, 8);
            this.LblApplianceTypes.Name = "LblApplianceTypes";
            this.LblApplianceTypes.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblApplianceTypes.Size = new System.Drawing.Size(174, 63);
            this.LblApplianceTypes.TabIndex = 65;
            this.LblApplianceTypes.Text = "Appliance Types";
            this.LblApplianceTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblApplianceTypes.Click += new System.EventHandler(this.LblApplianceTypes_Click);
            // 
            // LblCart
            // 
            this.LblCart.AutoSize = true;
            this.LblCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCart.ForeColor = System.Drawing.Color.Transparent;
            this.LblCart.Location = new System.Drawing.Point(551, 6);
            this.LblCart.Name = "LblCart";
            this.LblCart.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblCart.Size = new System.Drawing.Size(148, 63);
            this.LblCart.TabIndex = 8;
            this.LblCart.Text = "My Cart Lists";
            this.LblCart.Click += new System.EventHandler(this.LblCart_Click);
            // 
            // LblRents
            // 
            this.LblRents.AutoSize = true;
            this.LblRents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRents.ForeColor = System.Drawing.Color.Transparent;
            this.LblRents.Location = new System.Drawing.Point(378, 6);
            this.LblRents.Name = "LblRents";
            this.LblRents.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblRents.Size = new System.Drawing.Size(151, 63);
            this.LblRents.TabIndex = 7;
            this.LblRents.Text = "My Rent Lists";
            this.LblRents.Click += new System.EventHandler(this.LblRents_Click);
            // 
            // LblAppliances
            // 
            this.LblAppliances.AutoSize = true;
            this.LblAppliances.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppliances.ForeColor = System.Drawing.Color.Transparent;
            this.LblAppliances.Location = new System.Drawing.Point(41, 6);
            this.LblAppliances.Name = "LblAppliances";
            this.LblAppliances.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblAppliances.Size = new System.Drawing.Size(125, 63);
            this.LblAppliances.TabIndex = 6;
            this.LblAppliances.Text = "Appliances";
            this.LblAppliances.Click += new System.EventHandler(this.LblAppliances_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::House_Appliance_Rental_System.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(223, 99);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(53, 39);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRefresh.TabIndex = 64;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(31, 166);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1293, 611);
            this.dataGrid.TabIndex = 62;
            // 
            // ApplianceTypesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplianceTypesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplianceTypesScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCart;
        private System.Windows.Forms.Label LblRents;
        private System.Windows.Forms.Label LblAppliances;
        private System.Windows.Forms.PictureBox BtnRefresh;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label LblApplianceTypes;
        private System.Windows.Forms.Label LblLogout;
    }
}