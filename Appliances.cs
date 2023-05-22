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
    public partial class Appliances : Form
    {
        public Appliances()
        {
            InitializeComponent();
            GetAll();
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        
        private void DeleteData(string applianceId)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE tblAppliances WHERE applianceId=@applianceId", connection);

                command.Parameters.AddWithValue("@applianceId", applianceId);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Successfully Deleted!");
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

                string Query = "SELECT * FROM tblAppliances ORDER BY energyConsumption DESC";
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
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateAppliance newForm = new CreateAppliance();

            newForm.Show();

            this.Hide();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }       

        public static string applianceId = "";
        public static string name = "";
        public static string description = "";
        public static string powerUsage = "";
        public static string typicalUsage = "";
        public static string monthlyCost = "";
        public static string annualCost = "";
        public static string energyConsumption = "";
        public static string stocks = "";       
        public static string applianceTypeId = "";
        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            applianceId = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            description = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            powerUsage = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            typicalUsage = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            string cost = (dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString());
            char[] sperators = { '£', ' ' };
            string[] newCharArray = cost.Split(sperators, StringSplitOptions.RemoveEmptyEntries);
            monthlyCost = string.Join("", newCharArray);

            annualCost = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

            string energy = (dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
            char[] energySperators = { 'w', 'a', 't', 't', 's' };
            string[] energyCharArray = energy.Split(energySperators, StringSplitOptions.RemoveEmptyEntries);
            energyConsumption = string.Join("", energyCharArray);

            stocks = dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            applianceTypeId = dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (applianceId == "")
            {
                MessageBox.Show("Please select record to delete");
                return;
            }

            DeleteData(applianceId);

            GetAll();
        }

        public static string id = "";        
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (applianceId == "")
            {
                MessageBox.Show("Please select record to edit");
                return;
            }

            UpdateAppliance newForm = new UpdateAppliance();

            newForm.Show();

            this.Hide();
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
