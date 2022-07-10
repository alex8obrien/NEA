namespace NEA
{
    partial class Staff_Update
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
            this.chk_admin = new System.Windows.Forms.CheckBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_generatePassword = new System.Windows.Forms.Button();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_resetUser = new System.Windows.Forms.Button();
            this.btn_resetPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_admin
            // 
            this.chk_admin.AutoSize = true;
            this.chk_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_admin.Location = new System.Drawing.Point(163, 228);
            this.chk_admin.Name = "chk_admin";
            this.chk_admin.Size = new System.Drawing.Size(84, 28);
            this.chk_admin.TabIndex = 30;
            this.chk_admin.Text = "Admin";
            this.chk_admin.UseVisualStyleBackColor = true;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(163, 123);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 21;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.Location = new System.Drawing.Point(66, 119);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(91, 24);
            this.lbl_lastname.TabIndex = 39;
            this.lbl_lastname.Text = "Lastname";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(163, 88);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(100, 20);
            this.txt_firstname.TabIndex = 19;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(59, 84);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(98, 24);
            this.lbl_firstname.TabIndex = 38;
            this.lbl_firstname.Text = "Firstname:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(163, 193);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 25;
            this.txt_email.TextChanged += new System.EventHandler(this.Txt_email_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(95, 189);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 24);
            this.lbl_email.TabIndex = 37;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.Location = new System.Drawing.Point(264, 329);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(103, 24);
            this.lbl_error.TabIndex = 36;
            this.lbl_error.Text = "Error Label";
            this.lbl_error.Visible = false;
            // 
            // btn_generatePassword
            // 
            this.btn_generatePassword.Location = new System.Drawing.Point(12, 12);
            this.btn_generatePassword.Name = "btn_generatePassword";
            this.btn_generatePassword.Size = new System.Drawing.Size(100, 35);
            this.btn_generatePassword.TabIndex = 34;
            this.btn_generatePassword.Text = "Generate Password";
            this.btn_generatePassword.UseVisualStyleBackColor = true;
            this.btn_generatePassword.Click += new System.EventHandler(this.Btn_generatePassword_Click);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(12, 154);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(145, 24);
            this.lbl_phone.TabIndex = 26;
            this.lbl_phone.Text = "Phone Number:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(163, 158);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 23;
            this.txt_phone.TextChanged += new System.EventHandler(this.Txt_phone_TextChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(304, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(167, 24);
            this.lbl_title.TabIndex = 35;
            this.lbl_title.Text = "Update Information";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Back.Location = new System.Drawing.Point(308, 394);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(144, 35);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_update.Location = new System.Drawing.Point(163, 263);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 35);
            this.btn_update.TabIndex = 31;
            this.btn_update.Text = "Update Data";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Location = new System.Drawing.Point(600, 154);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_confirmPassword.TabIndex = 29;
            this.txt_confirmPassword.TextChanged += new System.EventHandler(this.Txt_confirmPassword_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(600, 119);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 28;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(600, 84);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 27;
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(427, 154);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(167, 24);
            this.lbl_ConfirmPassword.TabIndex = 24;
            this.lbl_ConfirmPassword.Text = "Confirm Password:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Password.Location = new System.Drawing.Point(497, 119);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 24);
            this.lbl_Password.TabIndex = 22;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_username.Location = new System.Drawing.Point(492, 84);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(102, 24);
            this.lbl_username.TabIndex = 20;
            this.lbl_username.Text = "Username:";
            // 
            // btn_resetUser
            // 
            this.btn_resetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_resetUser.Location = new System.Drawing.Point(585, 264);
            this.btn_resetUser.Name = "btn_resetUser";
            this.btn_resetUser.Size = new System.Drawing.Size(139, 35);
            this.btn_resetUser.TabIndex = 40;
            this.btn_resetUser.Text = "Reset Username";
            this.btn_resetUser.UseVisualStyleBackColor = true;
            this.btn_resetUser.Click += new System.EventHandler(this.Btn_resetUser_Click);
            // 
            // btn_resetPass
            // 
            this.btn_resetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_resetPass.Location = new System.Drawing.Point(585, 318);
            this.btn_resetPass.Name = "btn_resetPass";
            this.btn_resetPass.Size = new System.Drawing.Size(139, 35);
            this.btn_resetPass.TabIndex = 41;
            this.btn_resetPass.Text = "Reset Password";
            this.btn_resetPass.UseVisualStyleBackColor = true;
            this.btn_resetPass.Click += new System.EventHandler(this.Btn_resetPass_Click);
            // 
            // Staff_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_resetPass);
            this.Controls.Add(this.btn_resetUser);
            this.Controls.Add(this.chk_admin);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_generatePassword);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_ConfirmPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_username);
            this.Name = "Staff_Update";
            this.Text = "Staff_Update";
            this.Load += new System.EventHandler(this.Staff_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_admin;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_generatePassword;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_resetUser;
        private System.Windows.Forms.Button btn_resetPass;
    }
}