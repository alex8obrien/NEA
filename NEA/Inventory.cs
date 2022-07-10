using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NEA
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        public int StaffID { get; set; }
        public Form Menu { get; set; }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadData(chart1);
        }

        private void Btn_LoadChart_Click(object sender, EventArgs e)
        {
            string query;
            string value = txt_number.Text; //Leave blank error to fix in testing
            bool isValid = IsValid(value);
            int number;

            //If it is a valid integer
            if (isValid)
            {
                number = Convert.ToInt32(value);

                //Greater or less than checked
                if (radio_greaterThan.Checked == true)
                {
                    lbl_error.Hide();
                    query = "SELECT ingredientName, numberOf FROM tbl_ingredients WHERE numberOf > @value";
                    Search(query, number, chart1);
                }
                else if (radio_lessThan.Checked == true)
                {
                    lbl_error.Hide();
                    query = "SELECT ingredientName, numberOf FROM tbl_ingredients WHERE numberOf < @value";
                    Search(query, number, chart1);
                }
                else
                {
                    //Shows the please select an option
                    lbl_error.Text = "Please select an option";
                    lbl_error.Show();
                }
            }
            else
            {
                lbl_error.Text = "Please enter a number";
                lbl_error.Show();
            }           
        }

        public static void Search(string query, int param, Chart chart1)
        {
            //Used to store the value for the graph
            List<string> name = new List<string>();
            List<int> number = new List<int>();

            using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        //Reads all of the values bigger or smaller than the value
                        cmd.Parameters.Add("@value", SqlDbType.Int).Value = param;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //For each row of data it adds the name and number to its own list
                                name.Add(reader[0].ToString());
                                number.Add(Convert.ToInt32(reader[1].ToString()));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //The data is bound to the graph
            chart1.Series[0].Points.DataBindXY(name, number);
        }

        public static bool IsValid(string value)
        {
            //If null or blank, then its not valid
            if (value != null || value != "")
            {
                //Tries to parse to int
                if (int.TryParse(value, out _) == true)
                {
                    return true;//Is an int
                }
                else
                {
                    return false;//Isn't an int
                }
            }
            else
            {
                return false;//Isn't an int
            }
        }

        public static void LoadData(Chart chart1)
        {
            List<string> ingredientName = new List<string>(); //This list stores the ingredients name
            List<int> numberOf = new List<int>(); // This list stores the number of each ingredient

            using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ingredientName, numberOf FROM tbl_ingredients", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())//This reads the data from the database and
                                                                      //will loop through each row of data in a specified column
                    {
                        while (reader.Read())// This while loop will run until the rows of data end
                                             // After each row it'll go to the next one
                        {
                            //This converts the data and adds it to its respective array
                            ingredientName.Add(reader[0].ToString());
                            numberOf.Add(Convert.ToInt32(reader[1].ToString()));
                        }
                    }
                }
            }

            // This code is formmating for the chart
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series[0].ChartType = SeriesChartType.Column; // Vertical bar chart
            chart1.ChartAreas[0].AxisX.Title = "Ingredients"; //Axis name
            chart1.ChartAreas[0].AxisY.Title = "Number of Ingredients";
            chart1.Series[0].Points.DataBindXY(ingredientName, numberOf); //Sets the x and y data sets
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            LoadData(chart1);
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        { 
            Menu.Show();
            this.Close();
        }
    }
}
