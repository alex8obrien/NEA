using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace NEA
{
    public partial class Home : Form
    {
        //This is used to count how many login attempts the user has made
        //If it goes to 0 then they have ran out of attempts
        int loginChance = 3;

        public Home()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            int staffID = 0;
            string user = txt_username.Text;
            string pass = txt_password.Text;
            string dbUser = null, dbPass = null, firstname = null, lastname = null;
            //Creates the hashed password
            string hashedPass = Hashing(pass);

            if (loginChance == 0)//Checking if the user has had three login attempts
            {
                lbl_error.Text = "You have ran out of login attempts";
                lbl_error.Show();
            }
            else
            {
                //This will automatically close the connection when the brackets are exited
                using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                {
                    try
                    {
                        //This opens the connection to the database
                        con.Open();

                        //This SQL Command selects the staffID, username and password from the database
                        using (SqlCommand loginCmd = new SqlCommand("SELECT staffID, username, password, firstname, lastname FROM tbl_staff WHERE username = @user AND password = @pass", con))
                        {
                            //This adds the values to the parameters
                            loginCmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                            loginCmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = hashedPass;
                            SqlDataReader reader = loginCmd.ExecuteReader();

                            //This reads the data selected by the SQL query
                            while (reader.Read())
                            {
                                staffID = Convert.ToInt32(reader[0].ToString());
                                dbUser = reader[1].ToString();
                                dbPass = reader[2].ToString();
                                firstname = reader[3].ToString();
                                lastname = reader[4].ToString();
                            }
                        }
                    }
                    catch (Exception problem)
                    {
                        //This is error checking for any issue
                        MessageBox.Show(problem.Message);
                    }
                }

                //If the username and password matches
                if (user == dbUser && hashedPass == dbPass)
                {
                    //A new main menu form is created and values are passed to it
                    Form menu = new Main_Menu
                    {
                        Firstname = firstname,
                        Lastname = lastname,
                        StaffID = staffID,
                        Home = this
                    };
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    loginChance--;
                    lbl_error.Text = "Incorrect Username and Password\n" + loginChance + " chance(s) left";
                    lbl_error.Show();
                    this.txt_username.Clear();
                    this.txt_password.Clear();
                }                    
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            //Opens a new Registration page and hides this page
            Form register = new Registration();
            register.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ConnectionTest();
        }
        
        private static void ConnectionTest()
        {
            SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true");

            try//This opens and closes the database connection to test that it works and a database is detected
            {
                con.Open();
                con.Close();
            }
            catch (Exception problem)
            {
                MessageBox.Show("Failed to connect to database\nThe program will now quit after this message");
                MessageBox.Show(problem.Message);
                Application.Exit();
            }
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

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            txt_username.Text = null;
            txt_password.Text = null;
            loginChance = 3;
            lbl_error.Hide();
        }
    }
}