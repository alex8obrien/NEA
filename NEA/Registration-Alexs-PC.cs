using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace NEA
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits program
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            //These variables store the information from the textboxes
            int staffID = 0;
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string phoneNum = txt_phone.Text;
            string email = txt_email.Text;
            string user = txt_username.Text;
            string pass = txt_password.Text;
            string conPass = txt_confirmPassword.Text;

            //Creating the hashed password
            string hashedPass = Hashing(pass);
            //This ensures that all of the fields have the information filled in
            bool isNull = CheckNull(firstname, lastname, phoneNum, email, user, pass, conPass);
            //This ensures that the two entered passswords are the same
            bool isSame = CheckPassword(pass, conPass);
            //Ensures that the phone number is valid
            bool phoneValid = ValidNum(phoneNum);
            //Ensures that the email is valid
            bool emailValid = ValidEmail(email);
            //Is the user an owner or admin
            bool admin = IsAdmin(chk_admin);


            lbl_error.Hide(); //Resets the error label

            if (isNull == true)
            {
                lbl_error.Text = "Please fill in all of textboxes";
                lbl_error.Show();
            }
            else
            {
                if (phoneValid == true && emailValid == true && isSame == true)
                {
                    //This using line will contain the connection to the brackets so it will auto close the connection at the end of it
                    using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                    {
                        //This try will catch any errors that occur when it attepts to connect and send info the database
                        try
                        {
                            con.Open();

                            //Reading the largest staffID and adds one for the new staffID
                            using (SqlCommand largeStaffID = new SqlCommand("SELECT MAX(staffID) FROM tbl_staff", con))
                            {
                                staffID = (int)largeStaffID.ExecuteScalar();
                                staffID++;
                            }

                            //This is the SQL statement that will be used to insert the data into the database
                            using (SqlCommand cmdRegister = new SqlCommand("INSERT INTO tbl_staff (staffID, username, password, phonenumber, email, admin, firstname, lastname) VALUES (@staffID, @username, @password, @phonenumber, @email, @admin, @firstname, @lastname)", con))
                            {
                                //It uses the info stored in the variables for the database
                                cmdRegister.Parameters.Add("@staffID", SqlDbType.Int).Value = staffID;
                                cmdRegister.Parameters.Add("@username", SqlDbType.NVarChar).Value = user;
                                cmdRegister.Parameters.Add("@password", SqlDbType.NVarChar).Value = hashedPass;
                                cmdRegister.Parameters.Add("@phonenumber", SqlDbType.NVarChar).Value = phoneNum;
                                cmdRegister.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                                cmdRegister.Parameters.Add("@admin", SqlDbType.Bit).Value = admin;
                                cmdRegister.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = firstname;
                                cmdRegister.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = lastname;
                                cmdRegister.ExecuteNonQuery();
                            }
                        }
                        catch (Exception problem)
                        {
                            //This is error checking for trying to connect to the database as a part of the try-catch loop
                            MessageBox.Show("Error during insert:\n" + problem.Message);
                        }
                    }

                    try
                    {
                        //A new main menu form is created and values are passed to it
                        Form menu = new Main_Menu
                        {
                            Firstname = firstname,
                            Lastname = lastname,
                            StaffID = staffID,
                            Admin = admin
                        };
                        menu.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            //This loads a new menu page and then quits the current page, saving RAM
            var home = new Home();
            home.Show();
            this.Close();
        }

        private void Txt_phone_TextChanged(object sender, EventArgs e)
        {
            //The data is taken from the text box
            string number = txt_phone.Text;

            //Checks if its valid
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

            foreach(char c in chars)
            {
                //Builds the string from the array
                password += c;
            }

            txt_password.Text = password;
            txt_confirmPassword.Text = password;
        }

        private static bool CheckNull(string firstname, string lastname, string phoneNum, string email, string username, string pass, string conPass)
        {
            if (firstname == "" || lastname == "" || phoneNum == "" || email == "" || username == "" || pass == "" || conPass == "")
            { return true; } //Are they blank
            else
            { return false; }
        }

        private static bool CheckPassword(string pass, string conPass)
        {
            if (pass == conPass) //Are the passwords the same
            { return true; }
            else
            { return false; }
        }

        private static string Hashing(string rawPassword)
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

        private void Txt_email_TextChanged(object sender, EventArgs e)
        {
            //Takes in the data
            string email = txt_email.Text;

            //Checks if the data is valid
            bool valid = ValidEmail(email);

            switch (valid)
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

        private void Txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            //Takes in the data
            string pass = txt_password.Text;
            string conPass = txt_confirmPassword.Text;

            //Checks if they are the same
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

        private static bool IsAdmin(CheckBox chk_admin)
        {
            switch (chk_admin.Checked)
            {
                //If it is ticked
                case true:
                    return true;

                //If it is unticked
                case false:
                    return false;

                //If it is unticked
                default:
                    return false;
            }
        }
    }
}