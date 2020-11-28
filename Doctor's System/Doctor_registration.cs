using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace Doctor_s_System
{
    public partial class Doctor_registration : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\Visual Studio 2019\Projects\Doctor's System\Doctor's Database.mdf;Integrated Security=True";
        SqlConnection conn;

        public Doctor_registration()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {//get input data
            string name = textbox_name.Text,
                   last_name = textbox_lastname.Text,
                   password = textbox_password.Text,
                   admin_password = textbox_admin.Text;

            bool validated = false;

            password = Encrypt(password); //SHA256 encryption to store in database
            admin_password = Encrypt(admin_password);
            //validate through admin login data
            string sql_validation = "SELECT * FROM Doctors WHERE Name = 'Admin'";
            //store new employee data in the doctors table
            string sql = "INSERT INTO Doctors (Name, LastName, Password) VALUES ('" + name + "', '" + last_name + "', '" + password + "')";

            using (conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_validation, conn);
                SqlDataReader reader = cmd.ExecuteReader(); //execute validation
                while(reader.Read())
                {
                    if (reader["Password"].ToString() == admin_password) //compare input and stored hash
                    {
                        validated = true;
                    }
                }
                reader.Close();
                if (validated)
                {
                    SqlCommand cmd_insert = new SqlCommand(sql, conn);
                    cmd_insert.ExecuteNonQuery(); //register new employee
                }
            }
        }

        public static string Encrypt(string text) //simple SHA256 encryption with built-in Cryptography library
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            data = new SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
