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
    public partial class Customers : Form
    {
        public Customers()
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

                string Query = "SELECT customerId, name, email FROM tblCustomers";
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}
