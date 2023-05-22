namespace House_Appliance_Rental_System
{
    partial class AppliancesScreen
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
            this.LblAppliances = new System.Windows.Forms.Label();
            this.LblCart = new System.Windows.Forms.Label();
            this.LblRents = new System.Windows.Forms.Label();
            this.LblApplianceTypes = new System.Windows.Forms.Label();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.PictureBox();
            this.BtnRent = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LblLogout);
            this.panel1.Controls.Add(this.LblAppliances);
            this.panel1.Controls.Add(this.LblCart);
            this.panel1.Controls.Add(this.LblRents);
            this.panel1.Controls.Add(this.LblApplianceTypes);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 74);
            this.panel1.TabIndex = 0;
            // 
            // LblLogout
            // 
            this.LblLogout.AutoSize = true;
            this.LblLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogout.ForeColor = System.Drawing.Color.Transparent;
            this.LblLogout.Location = new System.Drawing.Point(1242, 6);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblLogout.Size = new System.Drawing.Size(90, 63);
            this.LblLogout.TabIndex = 67;
            this.LblLogout.Text = "Logout";
            this.LblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            // 
            // LblAppliances
            // 
            this.LblAppliances.AutoSize = true;
            this.LblAppliances.BackColor = System.Drawing.Color.White;
            this.LblAppliances.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppliances.ForeColor = System.Drawing.Color.Black;
            this.LblAppliances.Location = new System.Drawing.Point(26, 8);
            this.LblAppliances.Name = "LblAppliances";
            this.LblAppliances.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblAppliances.Size = new System.Drawing.Size(125, 63);
            this.LblAppliances.TabIndex = 61;
            this.LblAppliances.Text = "Appliances";
            this.LblAppliances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAppliances.Click += new System.EventHandler(this.LblAppliances_Click);
            // 
            // LblCart
            // 
            this.LblCart.AutoSize = true;
            this.LblCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCart.ForeColor = System.Drawing.Color.Transparent;
            this.LblCart.Location = new System.Drawing.Point(540, 5);
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
            this.LblRents.Location = new System.Drawing.Point(374, 5);
            this.LblRents.Name = "LblRents";
            this.LblRents.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblRents.Size = new System.Drawing.Size(151, 63);
            this.LblRents.TabIndex = 7;
            this.LblRents.Text = "My Rent Lists";
            this.LblRents.Click += new System.EventHandler(this.LblRents_Click);
            // 
            // LblApplianceTypes
            // 
            this.LblApplianceTypes.AutoSize = true;
            this.LblApplianceTypes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplianceTypes.ForeColor = System.Drawing.Color.Transparent;
            this.LblApplianceTypes.Location = new System.Drawing.Point(179, 5);
            this.LblApplianceTypes.Name = "LblApplianceTypes";
            this.LblApplianceTypes.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.LblApplianceTypes.Size = new System.Drawing.Size(174, 63);
            this.LblApplianceTypes.TabIndex = 5;
            this.LblApplianceTypes.Text = "Appliance Types";
            this.LblApplianceTypes.Click += new System.EventHandler(this.LblApplianceTypes_Click);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.BackColor = System.Drawing.Color.Black;
            this.BtnAddToCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToCart.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAddToCart.Location = new System.Drawing.Point(1170, 101);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(154, 42);
            this.BtnAddToCart.TabIndex = 59;
            this.BtnAddToCart.Text = "Add To Cart +";
            this.BtnAddToCart.UseVisualStyleBackColor = false;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
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
            this.dataGrid.TabIndex = 58;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::House_Appliance_Rental_System.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(918, 103);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(53, 39);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRefresh.TabIndex = 60;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnRent
            // 
            this.BtnRent.BackColor = System.Drawing.Color.Black;
            this.BtnRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRent.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRent.Location = new System.Drawing.Point(1008, 101);
            this.BtnRent.Name = "BtnRent";
            this.BtnRent.Size = new System.Drawing.Size(129, 42);
            this.BtnRent.TabIndex = 61;
            this.BtnRent.Text = "Rent";
            this.BtnRent.UseVisualStyleBackColor = false;
            this.BtnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Black;
            this.BtnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSearch.Location = new System.Drawing.Point(602, 104);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(134, 42);
            this.BtnSearch.TabIndex = 63;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.Black;
            this.tbTitle.Location = new System.Drawing.Point(31, 108);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(548, 34);
            this.tbTitle.TabIndex = 62;
            // 
            // AppliancesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.BtnRent);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppliancesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppliancesScreen";
            this.Load += new System.EventHandler(this.AppliancesScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCart;
        private System.Windows.Forms.Label LblRents;
        private System.Windows.Forms.Label LblApplianceTypes;
        private System.Windows.Forms.PictureBox BtnRefresh;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label LblAppliances;
        private System.Windows.Forms.Label LblLogout;
        private System.Windows.Forms.Button BtnRent;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox tbTitle;
    }
}