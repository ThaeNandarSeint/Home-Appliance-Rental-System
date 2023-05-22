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
    public partial class CreateRent : Form
    {
        public CreateRent()
        {
            InitializeComponent();
        }

        public string applianceId = "";
        public string customerId = "";
        private void CreateRent_Load(object sender, EventArgs e)
        {
            applianceId = AppliancesScreen.applianceId;
            customerId = AppliancesScreen.customerId;
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string start = tbStartDate.Value.Date.ToString("yyyy-MM-dd");
            string end = tbEndDate.Value.Date.ToString("yyyy-MM-dd");

            if (start == "")
            {
                MessageBox.Show("Start Date is required!");
                return;
            };
            if (end == "")
            {
                MessageBox.Show("End Date is required!");
                return;
            };

            // calculate duration

            char[] dateSperators = { '-' };
            string[] startDateArray = start.Split(dateSperators, StringSplitOptions.RemoveEmptyEntries);

            int startYear = int.Parse(startDateArray[0]);
            int startMonth = int.Parse(startDateArray[1]);
            int startDay = int.Parse(startDateArray[2]);

            string[] endDateArray = end.Split(dateSperators, StringSplitOptions.RemoveEmptyEntries);

            int endYear = int.Parse(endDateArray[0]);
            int endMonth = int.Parse(endDateArray[1]);
            int endDay = int.Parse(endDateArray[2]);

            DateTime startDate = new DateTime(startYear, startMonth, startDay);
            DateTime endDate = new DateTime(endYear, endMonth, endDay);

            int duration = int.Parse((endDate - startDate).TotalDays.ToString());

            try
            {
                connection.Open();

                int totalCost;

                string Query = "SELECT monthlyCost FROM tblAppliances WHERE applianceId = @applianceId";

                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@applianceId", applianceId);

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                foreach (DataRow row in dataTable.Rows)
                {
                    string monthlyCost;

                    string cost = (row["monthlyCost"].ToString());
                    char[] costSperators = { '£' };
                    string[] costCharArray = cost.Split(costSperators, StringSplitOptions.RemoveEmptyEntries);
                    monthlyCost = string.Join("", costCharArray);

                    totalCost = ((duration * int.Parse(monthlyCost)) / 30);

                    string insertQuery = "insert into tblRents(applianceId, customerId, startDate, endDate, duration, totalCost) values(@applianceId, @customerId, @startDate, @endDate, @duration, @totalCost);";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    insertCommand.Parameters.AddWithValue("@applianceId", applianceId);
                    insertCommand.Parameters.AddWithValue("@customerId", customerId);
                    insertCommand.Parameters.AddWithValue("@startDate", startDate);
                    insertCommand.Parameters.AddWithValue("@endDate", endDate);
                    insertCommand.Parameters.AddWithValue("@duration", duration + " days");
                    insertCommand.Parameters.AddWithValue("@totalCost", "£ " + totalCost);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully added!");

                    connection.Close();

                    MyRentLists newForm = new MyRentLists();

                    newForm.Show();

                    this.Hide();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
