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

namespace Doctor_s_System
{
    public partial class Authorization : Form
    {
        //database connection path
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\Visual Studio 2019\Projects\Doctor's System\Doctor's Database.mdf;Integrated Security=True";
        SqlConnection conn;
        int doctor_id;

        public Authorization()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string password = textbox_password.Text; //get password input string 
            password = Encrypt(password);// encrypt input password to compare with the hash in the database

            bool authorized = false;

            string sql_command = "SELECT * FROM Doctors WHERE Name = '" + textbox_name.Text + "' AND LastName = '" + textbox_lastname.Text + "'";
            //sql command string to retrieve id and password from Doctors table
            using (conn = new SqlConnection(connString))
            {//connection structure
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql_command, conn);
                SqlDataReader reader = cmd.ExecuteReader();//build sql command from string and execute

                while (reader.Read())
                {
                    if (reader["Password"].ToString() == password)//compare input and stored hash under "Password" column to authorize
                    {
                        authorized = true;
                        doctor_id = Convert.ToInt32(reader["Id"]);
                        Input input_form = new Input
                        {
                            doctor_id = doctor_id,
                            doctor_name = textbox_name.Text,
                            doctor_lastname = textbox_lastname.Text,
                        };//modify Input class attributes to display doctor's name
                        input_form.Show();
                        Hide();
                    }
                }
                if (!authorized)
                {
                    MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK);
                }
            }
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doctor_registration reg_window = new Doctor_registration();//open doctor registration form through link label
            reg_window.Show();
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
