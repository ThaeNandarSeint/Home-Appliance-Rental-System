namespace House_Appliance_Rental_System
{
    partial class UpdateRent
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
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.tbEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbStartDate = new System.Windows.Forms.DateTimePicker();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::House_Appliance_Rental_System.Properties.Resources.close;
            this.BtnClose.Location = new System.Drawing.Point(358, 30);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(47, 35);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 101;
            this.BtnClose.TabStop = false;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(48, 232);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(337, 22);
            this.tbEndDate.TabIndex = 100;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(48, 123);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(337, 22);
            this.tbStartDate.TabIndex = 99;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Black;
            this.BtnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEdit.Location = new System.Drawing.Point(136, 308);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(134, 42);
            this.BtnEdit.TabIndex = 98;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(52, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 26);
            this.label11.TabIndex = 97;
            this.label11.Text = "End Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(52, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 26);
            this.label10.TabIndex = 96;
            this.label10.Text = "Start Date";
            // 
            // UpdateRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 385);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRent";
            this.Load += new System.EventHandler(this.UpdateRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.DateTimePicker tbEndDate;
        private System.Windows.Forms.DateTimePicker tbStartDate;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}