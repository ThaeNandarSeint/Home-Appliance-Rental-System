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
    public partial class AppliancesScreen : Form
    {
        public AppliancesScreen()
        {
            InitializeComponent();
            GetAll();
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
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
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        public static string applianceId = "";
        public static string customerId = "";
        private void AppliancesScreen_Load(object sender, EventArgs e)
        {
            customerId = Login.userId;
        }
        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            applianceId = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void BtnRent_Click(object sender, EventArgs e)
        {
            if (customerId == "")
            {
                MessageBox.Show("Please Login!");
                return;
            }
            else if (applianceId == "")
            {
                MessageBox.Show("Please select an appliance!");
                return;
            } 
            else
            {
                CreateRent newForm = new CreateRent();

                newForm.Show();
            }
        }
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (applianceId == "")
            {
                MessageBox.Show("Please select an appliance");
                return;
            }

            try
            {
                connection.Open();

                string Query = "insert into tblCarts(customerId, applianceId) values(@customerId, @applianceId);";

                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@customerId", customerId);
                command.Parameters.AddWithValue("@applianceId", applianceId);

                command.ExecuteNonQuery();

                MessageBox.Show("Successfully Added!");

                connection.Close();

                MyCartLists newForm = new MyCartLists();

                newForm.Show();

                this.Hide();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string applianceTypeId = tbTitle.Text;

                if (applianceTypeId == "")
                {
                    MessageBox.Show("Please Enter Appliance Type Id to Search");
                    return;
                }

                connection.Open();

                string Query = "SELECT * FROM tblAppliances WHERE applianceTypeId=@applianceTypeId ORDER BY energyConsumption DESC";
                
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@applianceTypeId", applianceTypeId);

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

        // navigate
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Appliances newForm = new Appliances();

            newForm.Show();

            this.Hide();
        }
        private void LblAppliances_Click(object sender, EventArgs e)
        {
            AppliancesScreen newForm = new AppliancesScreen();

            newForm.Show();

            this.Hide();
        }
        private void LblApplianceTypes_Click(object sender, EventArgs e)
        {
            ApplianceTypesScreen newForm = new ApplianceTypesScreen();

            newForm.Show();

            this.Hide();
        }
        private void LblRents_Click(object sender, EventArgs e)
        {
            MyRentLists newForm = new MyRentLists();

            newForm.Show();

            this.Hide();
        }
        private void LblCart_Click(object sender, EventArgs e)
        {
            MyCartLists newForm = new MyCartLists();

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
