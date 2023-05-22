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
    public partial class UpdateRent : Form
    {
        public UpdateRent()
        {
            InitializeComponent();
        }

        public string rentId = "";
        public string applianceId = "";
        public string status = "";
        private void UpdateRent_Load(object sender, EventArgs e)
        {
            rentId = MyRentLists.rentId;
            applianceId = MyRentLists.applianceId;
            status = MyRentLists.status;

            tbStartDate.Text = MyRentLists.startDate;
            tbEndDate.Text = MyRentLists.endDate;            
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        private void BtnEdit_Click(object sender, EventArgs e)
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

            if(status != "pending")
            {
                MessageBox.Show("The rent record can only be edited on pending state");
                return ;
            }

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
                                        
                    string updateQuery = "UPDATE tblRents SET applianceId=@applianceId, startDate=@startDate, endDate=@endDate, duration=@duration, totalCost=@totalCost WHERE rentId=@rentId;";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

                    updateCommand.Parameters.AddWithValue("@rentId", rentId);
                    updateCommand.Parameters.AddWithValue("@applianceId", applianceId);
                    updateCommand.Parameters.AddWithValue("@startDate", startDate);
                    updateCommand.Parameters.AddWithValue("@endDate", endDate);
                    updateCommand.Parameters.AddWithValue("@duration", duration + " days");
                    updateCommand.Parameters.AddWithValue("@totalCost", "£ " + totalCost);

                    updateCommand.ExecuteNonQuery();

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

        // navigate
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Rents newForm = new Rents();

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
