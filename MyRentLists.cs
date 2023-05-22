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
    public partial class MyRentLists : Form
    {
        public MyRentLists()
        {
            InitializeComponent();
        }

        public string customerId = "";
        private void MyRentLists_Load(object sender, EventArgs e)
        {
            customerId = Login.userId;

            GetAll();
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        private void GetAll()
        {
            try
            {
                connection.Open();

                string Query = "SELECT * FROM tblRents WHERE customerId=@customerId";

                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@customerId", customerId);

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

        public static string rentId = "";
        public static string applianceId = "";
        public static string duration = "";

        public static string startDate = "";
        public static string endDate = "";
        public static string totalCost = "";
        public static string status = "";
        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rentId = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            applianceId = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            string durationData = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            char[] durationSperators = { 'd', 'a', 'y', 's', ' ' };
            string[] newCharArrayDuration = durationData.Split(durationSperators, StringSplitOptions.RemoveEmptyEntries);
            duration = string.Join("", newCharArrayDuration);

            startDate = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            endDate = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

            string cost = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            char[] sperators = { '£', ' ' };
            string[] newCharArray = cost.Split(sperators, StringSplitOptions.RemoveEmptyEntries);
            totalCost = string.Join("", newCharArray);

            status = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();           
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (rentId == "")
            {
                MessageBox.Show("Please select record to edit");
                return;
            }

            UpdateRent newForm = new UpdateRent();

            newForm.Show();
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (rentId == "")
            {
                MessageBox.Show("Please select record to remove");
                return;
            }

            if (status != "pending")
            {
                MessageBox.Show("The rent record can only be removed on pending state");
                return;
            }

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE tblRents WHERE rentId=@rentId", connection);

                command.Parameters.AddWithValue("@rentId", rentId);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Successfully Removed!");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }

            GetAll();
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
