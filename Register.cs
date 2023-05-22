using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace House_Appliance_Rental_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        
        // Logical Functions
        private int CheckDuplicateEmail (string email)
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

        private void InsertData (string newIdString, string name, string email, string hashedPassword)
        {
            // insert new customer into database

            string Query = "insert into tblCustomers(customerId, name, email, password) values(@customerId, @name, @email, @password);";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@customerId", newIdString);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", hashedPassword);

            command.ExecuteNonQuery();

            MessageBox.Show("Successfully Register!");

            connection.Close();
        }

        //
        private void BtnRegister_Click(object sender, EventArgs e)
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

                int customerCount = CheckDuplicateEmail(email);

                if (customerCount > 0)
                {
                    MessageBox.Show("This email already exist");
                    connection.Close();
                    return;
                }

                string hashedPassword = HashPassword(password);

                string checkRowCount = "SELECT COUNT(*) FROM tblCustomers";
                SqlCommand checkRowCountCommand = new SqlCommand(checkRowCount, connection);

                int rowCount = (int)checkRowCountCommand.ExecuteScalar();

                // exists last row in database table

                if (rowCount > 0)
                {
                    string lastId;

                    string getLastRow = "SELECT TOP 1 customerId FROM tblCustomers ORDER BY customerId DESC";

                    SqlDataAdapter sDA = new SqlDataAdapter(getLastRow, connection);
                    DataTable table = new DataTable();
                    sDA.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        lastId = (row["customerId"].ToString());
                        char[] sperators = { 'C', '_' };
                        string[] newCharArray = lastId.Split(sperators, StringSplitOptions.RemoveEmptyEntries);

                        string oldIdString = string.Join("", newCharArray);

                        int oldId = int.Parse(oldIdString);

                        int newId = oldId + 1;

                        string newIdString = "C_" + newId.ToString();

                        InsertData(newIdString, name, email, hashedPassword);

                        AppliancesScreen newForm = new AppliancesScreen();

                        newForm.Show();

                        this.Hide();

                        return;
                    }
                }

                // first data entry
                else
                {
                    InsertData("C_1", name, email, hashedPassword);

                    AppliancesScreen newForm = new AppliancesScreen();

                    newForm.Show();

                    this.Hide();

                    return;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
                return;
            }
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login newForm = new Login();

            newForm.Show();

            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
