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
    public partial class Data : Form
    {
        //path to the database/connection string
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\Visual Studio 2019\Projects\Doctor's System\Doctor's Database.mdf;Integrated Security=True";
        SqlConnection conn;
        public int doctor_id;
        public string doctor_name, doctor_lastname;

        int counter = 0;
        //coordinates and size values for labels and groupboxes
        int groupbox_width = 1340, groupbox_patients_height = 95, groupbox_apps_height = 205, groupbox_pos_y = 25,
            name_pos_x = 337, lastname_pos_x = 0,
            patients_id_pos_x = 675, appnum_pos_x = 0, apps_id_pos_x = 600,
            diagnosis_pos_x = 1012, date_pos_x = 900,
            pos_shift = 100, label_pos_y = 40;
        (int width, int height) groupbox_size;

        List<List<string>> patient_values = new List<List<string>>(); //stores retrieved values from database to sort/filter later
        List<List<string>> app_values = new List<List<string>>(); //each list contains one record
        Point[] coordinates = new Point[20]; //array of preset coordinates for labels

        List<GroupBox> profile_boxes = new List<GroupBox>(); //stores groupboxes that will contain labels to display records
        List<GroupBox> app_boxes = new List<GroupBox>();

        TabPage selected_tab;


        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            //stores the coordinates for labels: 0-3 for patients groupboxes, 4-9 for appointment groupboxes (to iterate through later)
            coordinates[0] = new Point(patients_id_pos_x, label_pos_y);
            coordinates[1] = new Point(name_pos_x, label_pos_y);
            coordinates[2] = new Point(lastname_pos_x, label_pos_y);
            coordinates[3] = new Point(diagnosis_pos_x, label_pos_y);
            coordinates[4] = new Point(appnum_pos_x, 20);
            coordinates[5] = new Point(apps_id_pos_x, 20);
            coordinates[6] = new Point(date_pos_x, 20);
            coordinates[7] = new Point(0, label_pos_y * 2);
            coordinates[8] = new Point(0, label_pos_y * 3);
            coordinates[9] = new Point(0, label_pos_y * 4);

            label_doctor_name.Text = doctor_name + " " + doctor_lastname; //display doctor's name

            Load_database();//start loading data from database
        }

        private void Load_database() //prepares the form to load data
        {
            for (int i = 0; i < profile_boxes.Count; i++)
            {
                patients_tab.Controls.Remove(profile_boxes[i]);
            }
            for (int i = 0; i < app_boxes.Count; i++)
            {
                appointments_tab.Controls.Remove(app_boxes[i]);
            }
            profile_boxes.Clear();
            patient_values.Clear();
            app_values.Clear();
            counter = 0;
            //resetting all values
            string sql_command_patients = "SELECT * FROM Patients WHERE Doctor = " + doctor_id;
            string sql_command_apps = "SELECT * FROM Appointments WHERE DOctor = " + doctor_id; //loads records associated with the doctor logged in via methods below
            RetrieveData_Patients(sql_command_patients);
            RetrieveData_Appointments(sql_command_apps);
        }

        private void RetrieveData_Patients(string sql) //method to load from Patients table
        {
            counter = 0;
            
            groupbox_size.width = groupbox_width;
            groupbox_size.height = groupbox_patients_height;
            pos_shift = 100; //sets tab specific groupbox sizes/position shifts

            using (conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    patient_values.Add(new List<string>());
                    patient_values.Last().Add(reader["IIN"].ToString());
                    patient_values.Last().Add(reader["Name"].ToString());
                    patient_values.Last().Add(reader["LastName"].ToString());
                    patient_values.Last().Add(reader["Diagnosis"].ToString()); //load values and add to the list
                    Create_groupbox(0); //create groupbox for the record, 0 indicates starting index for coordinates list

                    counter++; //counter used to shift groupboxes
                }
            }
        }

        private void RetrieveData_Appointments(string sql) //method to load from Appointments table
        {
            counter = 0;

            groupbox_size.width = groupbox_width;
            groupbox_size.height = groupbox_apps_height;
            pos_shift = 210;

            using (conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    app_values.Add(new List<string>());
                    app_values.Last().Add("№: " + reader["AppointmentNum"].ToString());
                    app_values.Last().Add("ID: " + reader["PatientIIN"].ToString());
                    app_values.Last().Add("Date: " + reader["Date"].ToString());
                    app_values.Last().Add("Symptoms observed: " + reader["Symptoms"].ToString());
                    app_values.Last().Add("Procedures involved: " + reader["Procedures"].ToString());
                    app_values.Last().Add("Medications prescribed: " + reader["Medications"].ToString());

                    Create_groupbox(4);

                    counter++;
                }
            }
        }

        private void Create_groupbox(int index) //creates groupbox with containing labels to display record data
        {
            int range = 0;

            GroupBox temp_groupbox = new GroupBox
            {
                Location = new Point(0, pos_shift * counter + groupbox_pos_y),
                Height = groupbox_size.height,
                Width = groupbox_size.width,
            };

            if (index == 0) //data is retrieved from patients table
            {
                profile_boxes.Add(temp_groupbox);
                patients_tab.Controls.Add(profile_boxes.Last());
                range = 4;
            }
            else //data is retrieved from appointments table
            {
                app_boxes.Add(temp_groupbox);
                appointments_tab.Controls.Add(app_boxes.Last());
                range = 6;
            }

            int i = 0;
            while (i < range)
            {
                Label temp_label = new Label
                {
                    Location = new Point(coordinates[i + index].X, coordinates[i + index].Y),
                    Font = new Font("Arial", 15),
                    AutoSize = true,
                };

                if (index == 0) //patients
                {
                    temp_label.Text = patient_values.Last()[i]; //assign values retrieved in the method before
                    profile_boxes.Last().Controls.Add(temp_label);
                }
                else //appointments
                {
                    temp_label.Text = app_values.Last()[i];
                    app_boxes.Last().Controls.Add(temp_label);
                }

                i++;
            }
        }

        private void Button_refresh_Click(object sender, EventArgs e) //reloads everything
        {
            Load_database();
        }

        private void Button_filter_Click(object sender, EventArgs e) //filters based on input string and open tab
        {
            counter = 0;
            selected_tab = tab_control.SelectedTab;
            if (textbox_filter.Text != null)
            {
                if (selected_tab == patients_tab) //determines the active tab (patients/appointments) to operate on specific table
                {
                    for (int i = 0; i < profile_boxes.Count; i++)
                    {
                        patients_tab.Controls.Remove(profile_boxes[i]);
                    }
                    profile_boxes.Clear();//reset containers

                    //get records with values that contain a substring equal to input string
                    string sql_command = "SELECT * FROM Patients WHERE Doctor = " + doctor_id + " AND (IIN LIKE '%" +
                    textbox_filter.Text + "%' OR Name LIKE '%" + textbox_filter.Text + "%' OR LastName LIKE '%" +
                    textbox_filter.Text + "%' OR Diagnosis LIKE '%" + textbox_filter.Text + "%')";

                    RetrieveData_Patients(sql_command);
                }
                else if (selected_tab == appointments_tab)
                {
                    for (int i = 0; i < app_boxes.Count; i++)
                    {
                        appointments_tab.Controls.Remove(app_boxes[i]);
                    }
                    app_boxes.Clear(); //same in appointments

                    string sql_command = "SELECT * FROM Appointments WHERE Doctor = " + doctor_id + " AND (PatientIIN LIKE '%" +
                    textbox_filter.Text +"%' OR Date LIKE '%" + textbox_filter.Text + "%' OR Symptoms LIKE '%" +
                    textbox_filter.Text + "%' OR Procedures LIKE '%" + textbox_filter.Text + "%' OR Medications LIKE '%" + textbox_filter.Text + "%')";

                    RetrieveData_Appointments(sql_command);
                }
            }
        }
        
        private void Button_sort_Click(object sender, EventArgs e) //sorts either by patient last name or appointment date & time
        {
            selected_tab = tab_control.SelectedTab;
            if (selected_tab == patients_tab) //determine selected tab
            {
                QuickSort(patient_values, 0, patient_values.Count - 1); //sort list by last name if patients tab is active
                int i = 0;
                while (i < profile_boxes.Count)
                {
                    pos_shift = 100;
                    profile_boxes[i].Location = new Point(0, pos_shift * i + groupbox_pos_y); //reorder/relocate groupboxes by location based on sorted list above
                    i++;
                }
            }
            else
            {
                QuickSort(app_values, 0, app_values.Count - 1); //sort list by date if appointments tab is active
                int i = 0;
                while (i < app_boxes.Count)
                {
                    pos_shift = 210;
                    app_boxes[i].Location = new Point(0, pos_shift * i + groupbox_pos_y); //reorder groupboxes
                    i++;
                }
            }
        }

        private void QuickSort(List<List<string>> list, int left, int right) //quicksort algorithm using recursion
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(list, left, right); //determine the pivot to split the list around
                QuickSort(list, left, pivot - 1); //keep splitting the sublists and reordering them
                QuickSort(list, pivot + 1, right);
            }
            return;
        }

        private int Partition(List<List<string>> list, int left, int right) //finds a value to split the list
        {
            List<string> temp;
            GroupBox temp_box;
            string pivot = list[right][2]; //default pivot is on the right, which shifts left if close to middle values
            int low = left - 1;

            for (int j = left; j < right; j++)
            {
                if (list[j][2].CompareTo(pivot) <= 0) //leaves values less than pivot on the left
                {                                     //values greater on the right
                    low++;

                    temp = list[j];
                    list[j] = list[low];
                    list[low] = temp;

                    if (selected_tab == patients_tab) //rearranges groupbox lists accordingly based on selected tab
                    {
                        temp_box = profile_boxes[j];
                        profile_boxes[j] = profile_boxes[low];
                        profile_boxes[low] = temp_box;
                    }
                    else
                    {
                        temp_box = app_boxes[j];
                        app_boxes[j] = app_boxes[low];
                        app_boxes[low] = temp_box;
                    }
                }
            }

            temp = list[low + 1];
            list[low + 1] = list[right]; //place the pivot in the middle
            list[right] = temp;

            if (selected_tab == patients_tab) //same in groupbox lists
            {
                temp_box = profile_boxes[low + 1];
                profile_boxes[low + 1] = profile_boxes[right];
                profile_boxes[right] = temp_box;
            }
            else
            {
                temp_box = app_boxes[low + 1];
                app_boxes[low + 1] = app_boxes[right];
                app_boxes[right] = temp_box;
            }

            return low + 1; //return the pivot index to the main quicksort recursion
        }
    }
}
