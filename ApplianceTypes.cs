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
    public partial class ApplianceTypes : Form
    {
        public ApplianceTypes()
        {
            InitializeComponent();
            GetAll();
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        
        private void InsertData (string title)
        {
            try
            {
                connection.Open();

                string checkRowCount = "SELECT COUNT(*) FROM tblApplianceTypes";
                SqlCommand checkRowCountCommand = new SqlCommand(checkRowCount, connection);

                int rowCount = (int)checkRowCountCommand.ExecuteScalar();

                if (rowCount > 0)
                {
                    string lastId;

                    string getLastRow = "SELECT TOP 1 applianceTypeId FROM tblApplianceTypes ORDER BY applianceTypeId DESC";

                    SqlDataAdapter sDA = new SqlDataAdapter(getLastRow, connection);
                    DataTable table = new DataTable();
                    sDA.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        lastId = (row["applianceTypeId"].ToString());
                        char[] sperators = { 'A', 'T', '_' };
                        string[] newCharArray = lastId.Split(sperators, StringSplitOptions.RemoveEmptyEntries);

                        string oldIdString = string.Join("", newCharArray);

                        int oldId = int.Parse(oldIdString);

                        int newId = oldId + 1;

                        string newIdString = "AT_" + newId.ToString();

                        //

                        string Query = "insert into tblApplianceTypes(applianceTypeId, title) values(@Value1, @Value2);";

                        SqlCommand command = new SqlCommand(Query, connection);
                        
                        command.Parameters.AddWithValue("@Value2", title);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Successfully added!");

                        connection.Close();

                        GetAll();

                        return;
                    }
                }
                else
                {
                    string Query = "insert into tblApplianceTypes(applianceTypeId, title) values(@applianceTypeId, @title);";

                    SqlCommand command = new SqlCommand(Query, connection);

                    command.Parameters.AddWithValue("@applianceTypeId", "AT_1");
                    command.Parameters.AddWithValue("@title", title);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Successfully added!");

                    connection.Close();

                    GetAll();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }

        private void UpdateData (string title)
        {
            try
            {
                connection.Open();

                string Query = "UPDATE tblApplianceTypes SET title=@title WHERE applianceTypeId = @applianceTypeId;";

                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@applianceTypeId", applianceTypeId);

                command.ExecuteNonQuery();

                MessageBox.Show("Successfully updated!");

                connection.Close();

                GetAll();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }

        private void DeleteData (string applianceTypeId)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE tblApplianceTypes WHERE applianceTypeId=@applianceTypeId", connection);

                command.Parameters.AddWithValue("@applianceTypeId", applianceTypeId);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Successfully Deleted!");

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

                string Query = "SELECT * FROM tblApplianceTypes";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGrid.DataSource = dataTable;

                connection.Close();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;

            if (title == "")
            {
                MessageBox.Show("Appliance Type Title is required!");
                return;
            };
            InsertData(title);            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        public static string applianceTypeId = "";        
        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            applianceTypeId = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbTitle.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (applianceTypeId == "")
            {
                MessageBox.Show("Please select a record to edit");
                return;
            }

            string title = tbTitle.Text;

            if (title == "")
            {
                MessageBox.Show("Appliance Type Title is required!");
                return;
            };

            UpdateData(title);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (applianceTypeId == "")
            {
                MessageBox.Show("Please select a record to delete");
                return ;
            }

            DeleteData(applianceTypeId);
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
