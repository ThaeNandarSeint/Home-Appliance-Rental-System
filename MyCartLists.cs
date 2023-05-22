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
    public partial class MyCartLists : Form
    {
        public MyCartLists()
        {
            InitializeComponent();
        }

        public string customerId = "";
        private void MyCartLists_Load(object sender, EventArgs e)
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

                string Query = "SELECT * FROM tblCarts WHERE customerId=@customerId";

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
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        public static string cartId = "";
        public static string applianceId = "";
        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cartId = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            applianceId = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (cartId == "")
            {
                MessageBox.Show("Please select record to remove");
                return;
            }

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE tblCarts WHERE cartId=@cartId", connection);

                command.Parameters.AddWithValue("@cartId", cartId);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Successfully Removed!");

                GetAll();
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
