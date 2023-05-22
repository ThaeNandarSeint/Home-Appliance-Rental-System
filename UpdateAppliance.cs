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
    public partial class UpdateAppliance : Form
    {
        public UpdateAppliance()
        {
            InitializeComponent();
        }

        public string applianceId = "";
        private void UpdateAppliance_Load(object sender, EventArgs e)
        {
            applianceId = Appliances.applianceId;

            tbName.Text = Appliances.name;
            tbDescription.Text = Appliances.description;
            tbPower.Text = Appliances.powerUsage;
            tbTypical.Text = Appliances.typicalUsage;
            tbMonthlyCost.Text = Appliances.monthlyCost;
            tbEnergy.Text = Appliances.energyConsumption;
            tbStocks.Text = Appliances.stocks;
            applianceTypesSelect.Text = Appliances.applianceTypeId;

            try
            {
                connection.Open();

                string Query = "SELECT * FROM tblApplianceTypes";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    applianceTypesSelect.Items.Add(reader[0].ToString());
                }

                connection.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }

        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        
        private void UpdateData(string name, string description, string powerUsage, string typicalUsage, string stocks, string applianceTypeId, string monthlyCost, string energyConsumption)
        {
            try
            {
                connection.Open();

                string Query = "UPDATE tblAppliances SET name=@name, description=@description, powerUsage=@powerUsage, typicalUsage=@typicalUsage, stocks=@stocks, monthlyCost=@monthlyCost, annualCost=@annualCost, energyConsumption=@energyConsumption, applianceTypeId=@applianceTypeId WHERE applianceId = @applianceId;";

                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@applianceId", applianceId);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@powerUsage", powerUsage);
                command.Parameters.AddWithValue("@typicalUsage", typicalUsage);
                command.Parameters.AddWithValue("@stocks", stocks);
                command.Parameters.AddWithValue("@applianceTypeId", applianceTypeId);
                command.Parameters.AddWithValue("@monthlyCost", "£ " + monthlyCost);
                command.Parameters.AddWithValue("@annualCost", "£ " + (int.Parse(monthlyCost) * 12).ToString());
                command.Parameters.AddWithValue("@energyConsumption", energyConsumption + " watts");

                command.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated!");

                connection.Close();

                Appliances newForm = new Appliances();

                newForm.Show();

                this.Hide();

                return;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string description = tbDescription.Text;
            string powerUsage = tbPower.Text;
            string typicalUsage = tbTypical.Text;
            string stocks = tbStocks.Text;
            string applianceTypeId = applianceTypesSelect.Text;
            string monthlyCost = tbMonthlyCost.Text;
            string energyConsumption = tbEnergy.Text;

            if (name == "")
            {
                MessageBox.Show("Appliance Name is required!");
                return;
            };
            if (description == "")
            {
                MessageBox.Show("Appliance Description is required!");
                return;
            };
            if (powerUsage == "")
            {
                MessageBox.Show("Appliance Power Usage is required!");
                return;
            };
            if (typicalUsage == "")
            {
                MessageBox.Show("Appliance Typical Usage is required!");
                return;
            };
            if (stocks == "")
            {
                MessageBox.Show("Appliance Stocks Amount is required!");
                return;
            };
            if (applianceTypeId == "")
            {
                MessageBox.Show("Appliance Type is required!");
                return;
            }
            if (monthlyCost == "")
            {
                MessageBox.Show("Appliance Monthly Cost is required!");
                return;
            };
            if (energyConsumption == "")
            {
                MessageBox.Show("Appliance Energy Consumption is required!");
                return;
            };

            UpdateData(name, description, powerUsage, typicalUsage, stocks, applianceTypeId, monthlyCost, energyConsumption);
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
