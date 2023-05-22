using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace House_Appliance_Rental_System
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        private void BtnHide_Click(object sender, EventArgs e)
        {
            BtnHide.Visible = false;
            BtnShow.Visible = true;

            tbPassword.PasswordChar = '\0';
        }
        private void BtnShow_Click(object sender, EventArgs e)
        {
            BtnHide.Visible = true;
            BtnShow.Visible = false;
            tbPassword.PasswordChar = '*';
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");

        private int CheckDuplicateEmail(string email)
        {
            string checkDuplicateEmail = "SELECT COUNT(*) FROM tblCustomers WHERE email = @email";
            SqlCommand checkDuplicateEmailCommand = new SqlCommand(checkDuplicateEmail, connection);

            checkDuplicateEmailCommand.Parameters.AddWithValue("@email", email);
            int customerCount = (int)checkDuplicateEmailCommand.ExecuteScalar();

            return customerCount;
        }
        private string HashPassword(string password)
        {
            string secretKey = "m6>`<[TA7,dS=H,e";
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(secretKey));

            tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDESCryptoServiceProvider.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            string hashedPassword = Convert.ToBase64String(result);

            return hashedPassword;
        }

        private void InsertData(string newIdString, string name, string email, string hashedPassword)
        {
            string Query = "insert into tblAdmins(adminId, name, email, password) values(@adminId, @name, @email, @password);";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@adminId", newIdString);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", hashedPassword);

            command.ExecuteNonQuery();

            MessageBox.Show("Successfully added!");

            connection.Close();
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (name == "")
            {
                MessageBox.Show("Username is required!");
                return;
            };
            if (email == "")
            {
                MessageBox.Show("Email is required!");
                return;
            };
            if (password == "")
            {
                MessageBox.Show("Password is required!");
                return;
            };

            // username validation
            Regex pattern = new Regex("^[a-zA-Z0-9]+$");
            if (!pattern.IsMatch(name))
            {
                MessageBox.Show("Username can only contains letters and numbers!");
                return;
            }

            // password validation
            if (password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Password must be of length between EIGHT (8) and SIXTEEN (16) characters!");
                return;
            }

            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password contains at least ONE (1) uppercase character!");
                return;
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password contains at least ONE (1) lowercase character!");
                return;
            }

            try
            {
                connection.Open();

                // check duplicate email
                int customerCount = CheckDuplicateEmail(email);

                if (customerCount > 0)
                {
                    MessageBox.Show("This email already exist");
                    connection.Close();
                    return;
                }                

                // hash password
                string hashedPassword = HashPassword(password);

                // 

                string checkRowCount = "SELECT COUNT(*) FROM tblAdmins";
                SqlCommand checkRowCountCommand = new SqlCommand(checkRowCount, connection);

                int rowCount = (int)checkRowCountCommand.ExecuteScalar();

                if (rowCount > 0)
                {
                    string lastId;

                    string getLastRow = "SELECT TOP 1 adminId FROM tblAdmins ORDER BY adminId DESC";

                    SqlDataAdapter sDA = new SqlDataAdapter(getLastRow, connection);
                    DataTable table = new DataTable();
                    sDA.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        lastId = (row["adminId"].ToString());
                        char[] sperators = { 'A', '_' };
                        string[] newCharArray = lastId.Split(sperators, StringSplitOptions.RemoveEmptyEntries);

                        string oldIdString = string.Join("", newCharArray);

                        int oldId = int.Parse(oldIdString);

                        int newId = oldId + 1;

                        string newIdString = "A_" + newId.ToString();

                        // insert new administrator into database

                        InsertData(newIdString, name, email, hashedPassword);

                        Admins newForm = new Admins();

                        newForm.Show();

                        this.Hide();
                        return;
                    }
                }
                else
                {
                    InsertData("A_1", name, email, hashedPassword);

                    Admins newForm = new Admins();

                    newForm.Show();

                    this.Hide();
                    return;
                }                
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        // navigate
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Admins newForm = new Admins();

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
