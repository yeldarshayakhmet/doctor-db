namespace Doctor_s_System
{
    partial class Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_sort = new System.Windows.Forms.Button();
            this.textbox_filter = new System.Windows.Forms.TextBox();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.patients_tab = new System.Windows.Forms.TabPage();
            this.name_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.diagnosis_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.appointments_tab = new System.Windows.Forms.TabPage();
            this.label_doctor_name = new System.Windows.Forms.Label();
            this.tab_control.SuspendLayout();
            this.patients_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_refresh.Location = new System.Drawing.Point(490, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(74, 30);
            this.button_refresh.TabIndex = 0;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // button_filter
            // 
            this.button_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_filter.Location = new System.Drawing.Point(360, 12);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(56, 30);
            this.button_filter.TabIndex = 1;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.Button_filter_Click);
            // 
            // button_sort
            // 
            this.button_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_sort.Location = new System.Drawing.Point(430, 12);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(48, 30);
            this.button_sort.TabIndex = 2;
            this.button_sort.Text = "Sort";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.Button_sort_Click);
            // 
            // textbox_filter
            // 
            this.textbox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textbox_filter.Location = new System.Drawing.Point(200, 13);
            this.textbox_filter.Name = "textbox_filter";
            this.textbox_filter.Size = new System.Drawing.Size(150, 27);
            this.textbox_filter.TabIndex = 3;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.patients_tab);
            this.tab_control.Controls.Add(this.appointments_tab);
            this.tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tab_control.ItemSize = new System.Drawing.Size(60, 45);
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1000, 433);
            this.tab_control.TabIndex = 4;
            // 
            // patients_tab
            // 
            this.patients_tab.AutoScroll = true;
            this.patients_tab.Controls.Add(this.name_label);
            this.patients_tab.Controls.Add(this.id_label);
            this.patients_tab.Controls.Add(this.diagnosis_label);
            this.patients_tab.Controls.Add(this.lastname_label);
            this.patients_tab.Location = new System.Drawing.Point(4, 49);
            this.patients_tab.Name = "patients_tab";
            this.patients_tab.Padding = new System.Windows.Forms.Padding(3);
            this.patients_tab.Size = new System.Drawing.Size(992, 380);
            this.patients_tab.TabIndex = 0;
            this.patients_tab.Text = "Patients";
            this.patients_tab.UseVisualStyleBackColor = true;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_label.Location = new System.Drawing.Point(337, 5);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(64, 25);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_label.Location = new System.Drawing.Point(675, 5);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(31, 25);
            this.id_label.TabIndex = 4;
            this.id_label.Text = "ID";
            // 
            // diagnosis_label
            // 
            this.diagnosis_label.AutoSize = true;
            this.diagnosis_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.diagnosis_label.Location = new System.Drawing.Point(1012, 5);
            this.diagnosis_label.Name = "diagnosis_label";
            this.diagnosis_label.Size = new System.Drawing.Size(140, 25);
            this.diagnosis_label.TabIndex = 2;
            this.diagnosis_label.Text = "Last Diagnosis";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lastname_label.Location = new System.Drawing.Point(0, 5);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(106, 25);
            this.lastname_label.TabIndex = 1;
            this.lastname_label.Text = "Last Name";
            // 
            // appointments_tab
            // 
            this.appointments_tab.AutoScroll = true;
            this.appointments_tab.Location = new System.Drawing.Point(4, 49);
            this.appointments_tab.Name = "appointments_tab";
            this.appointments_tab.Padding = new System.Windows.Forms.Padding(3);
            this.appointments_tab.Size = new System.Drawing.Size(792, 397);
            this.appointments_tab.TabIndex = 1;
            this.appointments_tab.Text = "Appointments";
            this.appointments_tab.UseVisualStyleBackColor = true;
            // 
            // label_doctor_name
            // 
            this.label_doctor_name.AutoSize = true;
            this.label_doctor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_doctor_name.Location = new System.Drawing.Point(1000, 14);
            this.label_doctor_name.Name = "label_doctor_name";
            this.label_doctor_name.Size = new System.Drawing.Size(0, 22);
            this.label_doctor_name.TabIndex = 5;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_doctor_name);
            this.Controls.Add(this.textbox_filter);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.tab_control);
            this.Name = "Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Data_Load);
            this.tab_control.ResumeLayout(false);
            this.patients_tab.ResumeLayout(false);
            this.patients_tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.TextBox textbox_filter;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage patients_tab;
        private System.Windows.Forms.TabPage appointments_tab;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label diagnosis_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label label_doctor_name;
    }
}