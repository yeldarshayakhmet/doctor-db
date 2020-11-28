namespace Doctor_s_System
{
    partial class Authorization
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
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(302, 112);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(230, 20);
            this.textbox_name.TabIndex = 0;
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Location = new System.Drawing.Point(302, 178);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(230, 20);
            this.textbox_lastname.TabIndex = 1;
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(302, 248);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(230, 20);
            this.textbox_password.TabIndex = 2;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(378, 306);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(662, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register a new employee";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_name.Location = new System.Drawing.Point(398, 94);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 15);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_lastname.Location = new System.Drawing.Point(386, 160);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(67, 15);
            this.label_lastname.TabIndex = 6;
            this.label_lastname.Text = "Last Name";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_password.Location = new System.Drawing.Point(386, 230);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 15);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Password";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_lastname);
            this.Controls.Add(this.textbox_name);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_lastname;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_password;
    }
}