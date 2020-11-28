namespace Doctor_s_System
{
    partial class Doctor_registration
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
            this.label = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.textbox_admin = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label.Location = new System.Drawing.Point(462, 76);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(346, 39);
            this.label.TabIndex = 0;
            this.label.Text = "Employee registration";
            // 
            // textbox_name
            // 
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_name.Location = new System.Drawing.Point(514, 134);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(248, 26);
            this.textbox_name.TabIndex = 1;
            this.textbox_name.Tag = "";
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_lastname.Location = new System.Drawing.Point(514, 180);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(248, 26);
            this.textbox_lastname.TabIndex = 2;
            // 
            // textbox_password
            // 
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_password.Location = new System.Drawing.Point(514, 232);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(248, 26);
            this.textbox_password.TabIndex = 3;
            this.textbox_password.UseSystemPasswordChar = true;
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_register.Location = new System.Drawing.Point(596, 326);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(83, 35);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textbox_admin
            // 
            this.textbox_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_admin.Location = new System.Drawing.Point(514, 282);
            this.textbox_admin.Name = "textbox_admin";
            this.textbox_admin.Size = new System.Drawing.Size(248, 26);
            this.textbox_admin.TabIndex = 5;
            this.textbox_admin.UseSystemPasswordChar = true;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_name.Location = new System.Drawing.Point(456, 140);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(425, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(432, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(389, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Admin Password";
            // 
            // Doctor_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textbox_admin);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_lastname);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label);
            this.Name = "Doctor_registration";
            this.Text = "Doctor Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_lastname;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textbox_admin;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}