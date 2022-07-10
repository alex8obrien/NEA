using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace NEA
{
    public partial class Staff_Update : Form
    {
        public Staff_Update()
        {
            InitializeComponent();
        }

        public int StaffID { get; set; }
        public Form Menu { get; set; }

        private void Staff_Update_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
            {
                con.Open();

                //This command will select all of the data from the staff table
                using (SqlCommand readData = new SqlCommand("SELECT * FROM tbl_staff WHERE staffID = @id", con))
                {
                    readData.Parameters.Add("@id", SqlDbType.Int).Value = StaffID;
                    using (SqlDataReader reader = readData.ExecuteReader())
                    {
                        //It doesn't need a while loop bc its only read once
                        reader.Read();

                        txt_firstname.Text = reader[6].ToString();
                        txt_lastname.Text = reader[7].ToString();
                        txt_phone.Text = reader[3].ToString();
                        txt_email.Text = reader[4].ToString();
                        txt_username.Text = reader[1].ToString();

                        //The bit 1 or 0 is read from the database
                        //This is then converted to a bool for C#
                        if (Convert.ToBoolean(reader[5].ToString()))
                        { chk_admin.Checked = true; }
                    }
                }
            } 
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            bool admin = IsAdmin(chk_admin);

            //Ensures that the phone number is valid
            bool phoneValid = ValidNum(phone);
            //Ensures that the email is valid
            bool emailValid = ValidEmail(email);
            //This ensures that all of the fields have the information filled in
            bool isNull = CheckNullInfo(firstname, lastname, phone, email);

            if (isNull)
            {
                lbl_error.Text = "Please fill in all of the textboxes";
                lbl_error.Show();
            }
            else
            {
                if (phoneValid == true && emailValid == true)
                {
                    using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                    {
                        using (SqlCommand updateInfo = new SqlCommand("UPDATE tbl_staff SET firstname = @firstname, lastname = @lastname, phoneNumber = @phone, " +
                            "email = @email, admin = @admin WHERE staffID = @id", con))
                        {
                            updateInfo.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = firstname;
                            updateInfo.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = lastname;
                            updateInfo.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                            updateInfo.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                            updateInfo.Parameters.Add("@admin", SqlDbType.Bit).Value = admin;
                            updateInfo.Parameters.Add("@id", SqlDbType.Int).Value = StaffID;

                            try
                            {
                                updateInfo.ExecuteScalar();
                                lbl_error.Text = "Update Successful";
                                lbl_error.Show();
                            }
                            catch
                            {
                                con.Close();
                                lbl_error.Text = "Error during insert of data";
                                lbl_error.Show();
                            }
                        }
                    }
                }
            }
        }

        public static bool ValidNum(string number)
        {
            //The phone number must start with +44 or 0
            //Must then have a further 10 digits with no spaces
            Regex regexPhone = new Regex(@"^((\+44)|(0))(\d{10})$");

            //Does it match the regex
            if (regexPhone.IsMatch(number))
            { return true; }
            else
            { return false; }
        }

        public static bool ValidEmail(string email)
        {
            //The email must be valid
            Regex regexEmail = new Regex(@"^(([.]*[a-z]*[0-9]*)+)@([a-z]*[0-9]*[.])+([a-z]{2,})$");

            //Does it match the regex
            if (regexEmail.IsMatch(email))
            { return true; }
            else
            { return false; }
        }

        private static bool CheckNullInfo(string firstname, string lastname, string phoneNum, string email)
        {
            if (firstname == "" || lastname == "" || phoneNum == "" || email == "")
            { return true; } //Are they blank
            else
            { return false; }
        }

        private static bool CheckNullPassword(string password, string confirmedPassword)
        {
            if (password == "" || confirmedPassword == "")
            { return true; }
            else
            { return false; }
        }

        private static bool CheckUser(string username)
        {
            if (username == "")
            { return true; }
            else
            { return false; }
        }

        private void Btn_resetUser_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            bool check = CheckUser(username);

            if (check)
            {
                lbl_error.Text = "Please enter a new username";
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                {
                    using (SqlCommand updateUser = new SqlCommand("UPDATE tbl_staff SET username = @username WHERE staffID = @staffID", con))
                    {
                        updateUser.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                        updateUser.Parameters.Add("@staffID", SqlDbType.Int).Value = StaffID;
                        updateUser.ExecuteScalar();
                    }
                }
            }
        }

        private void Btn_resetPass_Click(object sender, EventArgs e)
        {
            string password = txt_password.Text;
            string confirmedPassword = txt_confirmPassword.Text;
            string hashedPass = Hashing(password);
            bool isSame = CheckPassword(password, confirmedPassword);
            bool check = CheckNullPassword(password, confirmedPassword);

            if (check)
            {
                lbl_error.Text = "Please enter a new password";
            }
            else
            {
                if (isSame)
                {
                    using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                    {
                        using (SqlCommand updatePass = new SqlCommand("UPDATE tbl_staff SET password = @hashedPass WHERE staffID = @staffID", con))
                        {
                            updatePass.Parameters.Add("@hashedPass", SqlDbType.NVarChar).Value = hashedPass;
                            updatePass.Parameters.Add("@staffID", SqlDbType.Int).Value = StaffID;
                            updatePass.ExecuteScalar();
                        }
                    }
                }
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }

        private void Btn_generatePassword_Click(object sender, EventArgs e)
        {
            int length = 10; //Length of the password
            //Characters to use in the password
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();
            char[] chars = new char[length]; //Creates a char array
            string password = null;

            for (int i = 0; i < length; i++)
            {
                //Fills the array with a random string of 10 characters
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }

            foreach (char c in chars)
            {
                //Builds the string from the array
                password += c;
            }

            txt_password.Text = password;
            txt_confirmPassword.Text = password;
        }

        public static string Hashing(string rawPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create()) //A new instance of the hash is made
            {
                //Firstly, the line below converts the raw password to a string of bytes formatted to unicode as it has better symbol support
                //Then, it hashes this string of unicode formatted bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.Unicode.GetBytes(rawPassword));
                StringBuilder builder = new StringBuilder(); //Creates a new string builder class to help create the hashed password
                for (int i = 0; i < bytes.Length; i++) //Runs for length of password
                {
                    builder.Append(bytes[i].ToString("x2")); //It formats each byte of data to lowercase hexidecimal then builds a string using the hex value
                }
                return builder.ToString(); //Returns the hex formatted hashed password
            }
        }

        private void Txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            string pass = txt_password.Text;
            string conPass = txt_confirmPassword.Text;

            bool valid = CheckPassword(pass, conPass);

            switch (valid)
            {
                case true:
                    lbl_error.Hide();
                    break;

                case false:
                    //If the two passwords don't match then it will stop and get you to correct them
                    lbl_error.Text = "Your passwords don't match";
                    lbl_error.Show();
                    break;
            }
        }
        
        private static bool CheckPassword(string pass, string conPass)
        {
            if (pass == conPass) //Are the passwords the same
            { return true; }
            else
            { return false; }
        }

        private static bool IsAdmin(CheckBox chk_admin)
        {
            switch (chk_admin.Checked)
            {
                case true:
                    return true;

                case false:
                    return false;

                default:
                    return false;
            }
        }

        private void Txt_phone_TextChanged(object sender, EventArgs e)
        {
            string number = txt_phone.Text;

            bool valid = ValidNum(number);

            switch (valid)
            {
                case true:
                    lbl_error.Hide();
                    break;

                case false:
                    lbl_error.Text = "Please enter a valid phone number";
                    lbl_error.Show();
                    break;
            }
        }

        private void Txt_email_TextChanged(object sender, EventArgs e)
        {
            string email = txt_email.Text;

            bool valid = ValidEmail(email);

            switch(valid)
            {
                case true:
                    lbl_error.Hide();
                    break;

                case false:
                    lbl_error.Text = "Please enter a valid email";
                    lbl_error.Show();
                    break;
            }
        }
    }    
}
