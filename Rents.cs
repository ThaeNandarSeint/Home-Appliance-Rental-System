using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace House_Appliance_Rental_System
{
    public partial class Rents : Form
    {
        public Rents()
        {
            InitializeComponent();
            GetAll();
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        
        private void ApproveRent(string rentId)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE tblRents SET status=@status WHERE rentId=@rentId", connection);

                command.Parameters.AddWithValue("@rentId", rentId);
                command.Parameters.AddWithValue("@status", "approved");
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Successfully Approved!");

                GetAll();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }
        private void RejectRent(string rentId)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE tblRents SET status=@status WHERE rentId=@rentId", connection);

                command.Parameters.AddWithValue("@rentId", rentId);
                command.Parameters.AddWithValue("@status", "rejected");
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Successfully Rejected!");

                GetAll();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }
        private void GetAll()
        {
            try
            {
                connection.Open();

                string Query = "SELECT * FROM tblRents";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGrid.DataSource = dataTable;

                connection.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        public static string rentId = "";
        public static string applianceId = "";
        public static string customerId = "";
        public static string startDate = "";
        public static string endDate = "";
        public static string duration = "";
        public static string totalCost = "";

        private void dataGrid_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            rentId = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            applianceId = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerId = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            startDate = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            endDate = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            duration = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            totalCost = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (rentId == "")
            {
                MessageBox.Show("Please select record to approve");
                return;
            }
            ApproveRent(rentId);            
        }
        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (rentId == "")
            {
                MessageBox.Show("Please select record to reject");
                return;
            }
            RejectRent(rentId);            
        }

        // navigate
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Appliances newForm = new Appliances();

            newForm.Show();

            this.Hide();
        }

        private void LblAppliances_Click(object sender, EventArgs e)
        {
            Appliances newForm = new Appliances();

            newForm.Show();

            this.Hide();
        }

        private void LblApplianceTypes_Click(object sender, EventArgs e)
        {
            ApplianceTypes newForm = new ApplianceTypes();

            newForm.Show();

            this.Hide();
        }

        private void LblRents_Click(object sender, EventArgs e)
        {
            Rents newForm = new Rents();

            newForm.Show();

            this.Hide();
        }

        private void LblAdmins_Click(object sender, EventArgs e)
        {
            Admins newForm = new Admins();

            newForm.Show();

            this.Hide();
        }

        private void LblCustomers_Click(object sender, EventArgs e)
        {
            Customers newForm = new Customers();

            newForm.Show();

            this.Hide();
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();

            newForm.Show();

            this.Hide();
        }
    }

}
