using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace NEA
{
    public partial class Owner : Form
    {
        public int Staff { get; set; }
        public Form Menu { get; set; }
        public Form Owners { get; set; }

        public Owner()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
            {
                int leastID, mostID, largestMenuID, smallestMenuID;
                List<int> id = new List<int>();
                List<int> menu = new List<int>();

                con.Open();

                //Returns total number of staff
                using (SqlCommand cmdNumberOfStaff = new SqlCommand("SELECT COUNT (*) FROM tbl_staff", con))
                {
                    lbl_staffCount.Text += cmdNumberOfStaff.ExecuteScalar().ToString();
                }

                //Returns the total amount of money made from selling food
                using (SqlCommand selectTotalCost = new SqlCommand("SELECT SUM(totalCost) FROM tbl_orders", con))
                {
                    lbl_moneyMade.Text += selectTotalCost.ExecuteScalar().ToString();
                }

                //Returns the ID of the most sold dish
                using (SqlCommand mostFrequentIdCmd = new SqlCommand("SELECT menuID FROM tbl_menuItem GROUP BY menuID ORDER BY COUNT(menuID) DESC", con))
                {
                    mostID = (int)mostFrequentIdCmd.ExecuteScalar();
                }

                //Returns the name of the most sold dish
                using (SqlCommand mostName = new SqlCommand("SELECT menuName FROM tbl_menu WHERE menuID = @id", con))
                {
                    mostName.Parameters.Add("@id", SqlDbType.Int).Value = mostID;
                    lbl_mostSold.Text += mostName.ExecuteScalar().ToString();
                }

                //Returns the ID of the least sold dish
                using (SqlCommand leastFrequentIdCmd = new SqlCommand("SELECT menuID FROM tbl_menuItem GROUP BY menuID ORDER BY COUNT(menuID) ASC", con))
                {
                    leastID = (int)leastFrequentIdCmd.ExecuteScalar();
                }

                //Returns the name of the least sold dish
                using(SqlCommand leastName = new SqlCommand("SELECT menuName FROM tbl_menu WHERE menuID = @id", con))
                {
                    leastName.Parameters.Add("@id", SqlDbType.Int).Value = leastID;
                    lbl_leastSold.Text += leastName.ExecuteScalar().ToString();
                }

                //Returns the ID of the most sold dish this month
                using (SqlCommand thisMonthsOrderIDs = new SqlCommand("SELECT ordersID FROM tbl_orders WHERE Month(dateTime) = @month", con))
                {
                    thisMonthsOrderIDs.Parameters.Add("@month", SqlDbType.Int).Value = DateTime.Now.Month;
                    using (SqlDataReader reader = thisMonthsOrderIDs.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id.Add(reader.GetInt32(0));
                        }
                    }
                }

                foreach(int orderID in id)
                {
                    using (SqlCommand selectMenuID = new SqlCommand("SELECT menuID FROM tbl_menuItem WHERE ordersID = @id", con))
                    {
                        selectMenuID.Parameters.Add("@id", SqlDbType.Int).Value = orderID;
                        using (SqlDataReader reader = selectMenuID.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                menu.Add(Convert.ToInt32(reader[0].ToString()));
                            }
                        }
                    }
                }

                var groups = menu.GroupBy(x => x);
                var largest = groups.OrderByDescending(x => x.Count()).First();
                var smallest = groups.OrderByDescending(x =>x.Count()).Last();
                largestMenuID = largest.Key;
                smallestMenuID = smallest.Key;

                using (SqlCommand monthlyMost = new SqlCommand("SELECT menuName FROM tbl_menu WHERE menuID = @id", con))
                {
                    monthlyMost.Parameters.Add("@id", SqlDbType.Int).Value = largestMenuID;
                    lbl_mostMonth.Text += monthlyMost.ExecuteScalar().ToString();
                }

                using (SqlCommand monthlyLeast = new SqlCommand("SELECT menuName FROM tbl_menu WHERE menuID = @id", con))
                {
                    monthlyLeast.Parameters.Add("@id", SqlDbType.Int).Value = smallestMenuID;
                    lbl_leastMonth.Text += monthlyLeast.ExecuteScalar().ToString();
                }
            }
        }

        private void Btn_ownersMenu_Click(object sender, EventArgs e)
        {
            Owners.Show();
            this.Close();
        }
    }
}