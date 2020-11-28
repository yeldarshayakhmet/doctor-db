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

namespace Doctor_s_System
{
    public partial class Input : Form
    {
        SqlConnection conn;
        //database connection path
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\Visual Studio 2019\Projects\Doctor's System\Doctor's Database.mdf;Integrated Security=True";
        string sql_patients, sql_appointments;
        public int doctor_id;
        public string doctor_name, doctor_lastname;

        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            label_doctor_name.Text = doctor_name + " " + doctor_lastname; //display doctor's name
        }

        private void button_input_Click(object sender, EventArgs e)
        {//get input string values from textboxes
            string iin = textbox_id.Text,
                   name = textbox_name.Text,
                   last_name = textbox_lastname.Text,
                   diagnosis = textbox_diagnosis.Text,
                   date = date_time.Value.ToString(),
                   symptoms = textbox_symptoms.Text,
                   procs = textbox_proc.Text,
                   meds = textbox_meds.Text;

            using (conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd;

                //try to update the table if the patient exists
                sql_patients = "UPDATE Patients SET Diagnosis = '" + diagnosis + "' WHERE IIN = '" + iin + "'";
                cmd = new SqlCommand(sql_patients, conn);
                int affected_rows = cmd.ExecuteNonQuery();//1 if exists

                if (affected_rows == 0)//add new patient if does not exist in the table
                {
                    sql_patients = "INSERT INTO Patients (IIN, Name, LastName, Diagnosis, Doctor) VALUES ('" + iin + "', '" + name + "', '" +
                                                                                                          last_name + "', '" + diagnosis + "', " + doctor_id + ")";
                    cmd = new SqlCommand(sql_patients, conn);
                    cmd.ExecuteNonQuery();
                }
                //add new appointment record
                sql_appointments = "INSERT INTO Appointments (PatientIIN, Date, Symptoms, Procedures, Medications, Doctor) VALUES ('" + iin + "', '" + date + "', '" +
                                                                                                    symptoms + "', '" + procs + "', '" + meds + "', " + doctor_id + ")";
                cmd = new SqlCommand(sql_appointments, conn);
                cmd.ExecuteNonQuery();
            }

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Data data_form = new Data //open data form when clicked
            {
                doctor_id = doctor_id,
                doctor_name = doctor_name,
                doctor_lastname = doctor_lastname,
            };
            data_form.Show();
        }

        private void Input_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
