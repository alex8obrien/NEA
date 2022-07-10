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
            bool admin = false;
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
                        using (SqlCommand loginCmd = new SqlCommand("SELECT staffID, username, password, firstname, lastname, admin FROM tbl_staff WHERE username = @user AND password = @pass", con))
                        {
                            //This adds the values to the parameters
                            loginCmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                            loginCmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = hashedPass;

                            using (SqlDataReader reader = loginCmd.ExecuteReader())
                            {
                                //This reads the data selected by the SQL query
                                while (reader.Read())
                                {
                                    staffID = Convert.ToInt32(reader[0].ToString());
                                    dbUser = reader[1].ToString();
                                    dbPass = reader[2].ToString();
                                    firstname = reader[3].ToString();
                                    lastname = reader[4].ToString();
                                    admin = Convert.ToBoolean(reader[5]);
                                }
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
                        StaffID = staffID,
                        Firstname = firstname,
                        Lastname = lastname,
                        Home = this,
                        Admin = admin
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
            Form register = new Registration
            { Home = this };
            register.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            bool test = ConnectionTest();

            if (!test)
            {
                DialogResult dr = MessageBox.Show("The program failed to detect a database\nWould you like to generate a new database?",
                    "Database Creation", MessageBoxButtons.YesNo);

                switch (dr)
                {
                    case DialogResult.Yes:
                        //Creates the database
                        GenerateDatabase();
                        //Opens a new Registration page and hides this page
                        Form register = new Registration
                        { Home = this };
                        register.Show();
                        this.Hide();
                        break;
                    case DialogResult.No:
                        MessageBox.Show("The program will now quit");
                        Application.Exit();
                        break;
                }
            }
        }

        private static void GenerateDatabase()
        {
            using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;trusted_connection=true"))
            {
                using (SqlCommand createDatabase = new SqlCommand(
                    "CREATE DATABASE cafeDB;" +
                    "CREATE TABLE tbl_staff(staffID INT NOT NULL, username NVARCHAR(50) NOT NULL, password NVARCHAR(MAX) NOT NULL, phoneNumber NVARCHAR(50) NOT NULL, email NVARCHAR(100) NOT NULL," +
                    "firstname NVARCHAR(50) NOT NULL, lastname NVARCHAR(50) NOT NULL, admin BIT NOT NULL, CONSTRAINT PK_staffID PRIMARY KEY (staffID));" +
                    "CREATE TABLE tbl_menu(menuID INT NOT NULL, menuName NVARCHAR(50) NOT NULL, price MONEY NOT NULL, CONSTRAINT PK_menuID PRIMARY KEY(menuID));" +
                    "CREATE TABLE tbl_orders(ordersID INT NOT NULL, staffID INT NOT NULL, totalCost MONEY NOT NULL, [dateTime] DateTime NOT NULL," +
                    "CONSTRAINT PK_ordersID PRIMARY KEY(ordersID), CONSTRAINT FK_staffID FOREIGN KEY(staffID) REFERENCES tbl_staff(staffID));" +
                    "CREATE TABLE tbl_ingredients(ingredientID INT NOT NULL, ingredientName NVARCHAR(50) NOT NULL, numberOf INT NOT NULL, CONSTRAINT PK_ingredientID PRIMARY KEY(ingredientID));" +
                    "CREATE TABLE tbl_menuItem(itemID INT NOT NULL, menuID INT NOT NULL, ordersID INT NOT NULL, CONSTRAINT PK_tbl_menuItem PRIMARY KEY(itemID, menuID, ordersID)," +
                    "CONSTRAINT FK_tbl_menuItem1 FOREIGN KEY(menuID) REFERENCES tbl_menu(menuID), CONSTRAINT FK_tbl_menuItem2 FOREIGN KEY(ordersID) REFERENCES tbl_orders(ordersID));" +
                    "CREATE TABLE tbl_ingredientItem(ingredientID INT NOT NULL, menuID INT NOT NULL, CONSTRAINT PK_tbl_ingredientItem PRIMARY KEY(ingredientID, menuID)," +
                    "CONSTRAINT FK_tbl_ingredientItem1 FOREIGN KEY(ingredientID) REFERENCES tbl_ingredients(ingredientID), CONSTRAINT FK_tbl_ingredientItem2 FOREIGN KEY(menuID) REFERENCES tbl_menu(menuID));", con))
                {
                    createDatabase.ExecuteScalar();
                }
            }
        }

        private static bool ConnectionTest()
        {
            SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true");

            try//This opens and closes the database connection to test that it works and a database is detected
            {
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception problem)
            {
                MessageBox.Show("Failed to connect to database");
                MessageBox.Show(problem.Message);
                return false;
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

        //When the home page is loaded from the registration page
        //Its data is reset to blank
        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            txt_username.Text = null;
            txt_password.Text = null;
            loginChance = 3;
            lbl_error.Hide();
        }
    }
}