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
using System.Security.Cryptography;

namespace House_Appliance_Rental_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public int maxLoginAttempts = 5;

        public static string userId = "";
        public static string isSuperadmin = "";

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-061VM0Q;Initial Catalog=Home Appliance Rental Management System;Integrated Security=True;");
        
        // Logical Functions
        private string HashPassword (string password)
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

        private int CheckCustomer (string email, string hashedPassword)
        {
            string checkCustomer = "SELECT COUNT(*) FROM tblCustomers WHERE email = @email AND password = @password";

            SqlCommand checkCustomerCommand = new SqlCommand(checkCustomer, connection);

            checkCustomerCommand.Parameters.AddWithValue("@email", email);
            checkCustomerCommand.Parameters.AddWithValue("@password", hashedPassword);

            int customerCount = (int)checkCustomerCommand.ExecuteScalar();

            return customerCount;
        }

        private int CheckAdmin (string email, string hashedPassword)
        {
            string checkAdmin = "SELECT COUNT(*) FROM tblAdmins WHERE email = @email AND password = @password";
                        
            SqlCommand checkAdminCommand = new SqlCommand(checkAdmin, connection);

            checkAdminCommand.Parameters.AddWithValue("@email", email);
            checkAdminCommand.Parameters.AddWithValue("@password", hashedPassword);

            int adminCount = (int)checkAdminCommand.ExecuteScalar();

            return adminCount;
        }

        //
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Email is required!");
                return;
            };
            if (tbPassword.Text == "")
            {
                MessageBox.Show("Password is required!");
                return;
            };
            try
            {
                connection.Open();
                
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                string hashedPassword = HashPassword(password);

                int customerCount = CheckCustomer(email, hashedPassword);
                int adminCount = CheckAdmin(email, hashedPassword);

                if (customerCount > 0)
                {
                    MessageBox.Show("Successfully Login");

                    // Pass customer's Id to other screens

                    string Query = "SELECT customerId FROM tblCustomers WHERE email = @email";

                    SqlCommand command = new SqlCommand(Query, connection);
                    command.Parameters.AddWithValue("@email", email);

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        userId = row["customerId"].ToString();

                        connection.Close();

                        AppliancesScreen newForm = new AppliancesScreen();

                        newForm.Show();

                        this.Hide();

                        return;
                    }
                }
                else if (adminCount > 0)
                {
                    MessageBox.Show("Successfully Login");

                    // Pass admin's role to other screens

                    string Query = "SELECT isSuperAdmin FROM tblAdmins WHERE email = @email";

                    SqlCommand command = new SqlCommand(Query, connection);
                    command.Parameters.AddWithValue("@email", email);

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        isSuperadmin = row["isSuperAdmin"].ToString();

                        connection.Close();

                        Appliances newForm = new Appliances();

                        newForm.Show();

                        this.Hide();

                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Crendials");
                    connection.Close();
                    maxLoginAttempts = maxLoginAttempts - 1;
                }

                if (maxLoginAttempts == 0)
                {
                    MessageBox.Show("Time Out");
                    Application.Exit();
                }

                else if (maxLoginAttempts < 2)
                {
                    MessageBox.Show("You have only 1 chance");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                connection.Close();
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register newForm = new Register();

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
