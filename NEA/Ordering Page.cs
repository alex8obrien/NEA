using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NEA
{
    public partial class Ordering_Page : Form
    {
        int id;
        decimal totalPrice;
        decimal decimalPrice;
        List<int> missingIngredients = new List<int>();
        List<int> menuID = new List<int>();
        List<decimal> price = new List<decimal>();
        List<string> menuName = new List<string>();

        public Ordering_Page()
        {
            InitializeComponent();
        }

        public int StaffID { get; set; }
        public Form Menu { get; set; }

        private void Ordering_Page_Load(object sender, EventArgs e)
        {
            int rowNum;
            DataTable dt2 = new DataTable();

            using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
            {
                con.Open();

                using (SqlCommand creategridView = new SqlCommand("SELECT * FROM tbl_menu", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(creategridView))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Visible = false;
                    }
                }

                //This cross-table SQL query combines the ingredientItem table and the ingredients table
                //Thus allowing the code to track which ingredient matches to each dish
                using (SqlCommand cmdCrossTableIngredient = new SqlCommand("SELECT * FROM tbl_ingredientItem FULL OUTER JOIN tbl_ingredients ON tbl_ingredientItem.ingredientID = tbl_ingredients.ingredientID WHERE numberOf = 0", con))
                {
                    //This fills the data table
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmdCrossTableIngredient))
                    {
                        adapter.Fill(dt2);
                    }

                    //This adds all of the menuIDs with missing ingredients to a list
                    using (SqlDataReader reader = cmdCrossTableIngredient.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            missingIngredients.Add(Convert.ToInt32(reader[1].ToString()));
                        }
                    }
                }
            }

            //For each dish missing an ingredient
            foreach (int i in missingIngredients)
            {
                //The row is selectedd
                foreach (DataRow row in dt2.Rows)
                {
                    //If the menuID of that row is the same
                    if (Convert.ToInt32(row["menuID"].ToString()) == i)
                    {
                        //Gets the row number
                        //-1 as rows count from 1
                        rowNum = Convert.ToInt32(row["menuID"]) - 1;
                        //If it's missing an ingredient then the row is changed to red
                        dataGridView1.Rows[rowNum].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void Btn_menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }

        private void Btn_addtoorder_Click(object sender, EventArgs e)
        {
            string menuNameTextbox = txt_menuName.Text;
            lbl_error.Hide();

            if (string.IsNullOrEmpty(menuNameTextbox))
            {
                lbl_error.Text = "Please select or type in an item";
                lbl_error.Show();
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                {
                    try
                    {
                        con.Open();
                    }
                    catch (Exception ex)
                    {
                        //If the connection fails then it will load the main menu
                        MessageBox.Show("Connection fail\n\n" + ex.Message);
                        con.Dispose();
                        btn_menu.PerformClick();
                    }

                    try
                    {
                        //Selects the menuID and price from the database
                        using (SqlCommand cmdSelectMenu = new SqlCommand("SELECT menuID, price FROM tbl_menu WHERE menuName = @menuName", con))
                        {
                            cmdSelectMenu.Parameters.Add("@menuName", SqlDbType.NVarChar).Value = menuNameTextbox;
                            using (SqlDataReader reader = cmdSelectMenu.ExecuteReader())
                            {
                                bool valid = ValidItem(reader);

                                if (!valid)
                                {
                                    lbl_error.Show();
                                    lbl_error.Text = "Please enter a valid item";
                                }
                                else
                                {

                                    //Reads the two values
                                    while (reader.Read())
                                    {

                                        if (missingIngredients.Contains((int)reader[0]))
                                        {
                                            lbl_error.Text = "You cannot order this item\nIt is missing some ingredients";
                                            lbl_error.Show();
                                        }
                                        else
                                        {
                                            //Adds the name to a list
                                            menuName.Add(menuNameTextbox);

                                            //Reads the ID and adds it to a list
                                            id = Convert.ToInt32(reader[0].ToString());
                                            menuID.Add(id);

                                            //Reads the price and adds it to a list
                                            decimalPrice = Convert.ToDecimal(reader[1].ToString());
                                            price.Add(decimalPrice);
                                            totalPrice += decimalPrice;
                                        }
                                    }
                                    //Updates the label to show the added items
                                    lbl_currentOrder.Text+= menuNameTextbox + " \t.....\t £ " + decimalPrice.ToString("G29") + "\n";
                                    lbl_totalPrice.Text = "Total Price: £ " +totalPrice.ToString("G29");
                                }
                            }
                        } 

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed\n\n" + ex.Message);
                    }
                }
            }
        }

        private bool ValidItem(SqlDataReader reader)
        {
            if (reader.HasRows)
            { return true; }
            else { return false; }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Selects the string in the menu name column of the selected row
                int rowID = e.RowIndex;
                DataGridViewRow row = this.dataGridView1.Rows[rowID];
                txt_menuName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void Btn_finish_Click(object sender, EventArgs e)
        {
            if (menuID.Count == 0)
            {
                lbl_error.Text = "Empty order";
                lbl_error.Show();
            }
            else
            {
                List<int> ingredientIDList = new List<int>();
                int ordersID, menuItemID;

                try
                {
                    //The connection to the database is created
                    using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                    {
                        con.Open();

                        try
                        {
                            //Reading the largest orderID and adds one for new orderID
                            using (SqlCommand largeOrderID = new SqlCommand("SELECT MAX(ordersID) FROM tbl_orders", con))
                            {
                                ordersID = (int)largeOrderID.ExecuteScalar();
                                ordersID++;
                            }
                        }
                        catch (InvalidCastException)
                        {
                            ordersID = 1;
                        }

                        try
                        {
                            using (SqlCommand largeMenuItemID = new SqlCommand("SELECT MAX(itemID) FROM tbl_menuItem", con))
                            {
                                menuItemID = (int)largeMenuItemID.ExecuteScalar();
                                menuItemID++;
                            }
                        }
                        catch (InvalidCastException)
                        {
                            menuItemID = 1;
                        }
                        //The order details are inserted into the database
                        //The order ID is created automatically as it is autonumerable
                        using (SqlCommand InsertOrderCmd = new SqlCommand("INSERT INTO tbl_orders VALUES (@ordersID, @staffID, @totalCost, @dateTime)", con))
                        {
                            InsertOrderCmd.Parameters.Add("@ordersID", SqlDbType.Int).Value = ordersID;
                            InsertOrderCmd.Parameters.Add("@staffID", SqlDbType.Int).Value = StaffID;
                            InsertOrderCmd.Parameters.Add("@totalCost", SqlDbType.Money).Value = totalPrice;
                            //The current time and data is recorded and put into SQL dateTime format
                            SqlDateTime dateAndTime = new SqlDateTime(DateTime.Now);
                            InsertOrderCmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = dateAndTime;
                            InsertOrderCmd.ExecuteNonQuery();
                        }

                        foreach (int value in menuID)
                        {
                            //This creates the foreign key links in the table for the order top each item in the menu
                            //Loops through each item in the order
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_menuItem VALUES (@itemID, @menuID, @ordersID)", con))
                            {
                                cmd.Parameters.Add("@itemID", SqlDbType.Int).Value = menuItemID;
                                cmd.Parameters.Add("@menuID", SqlDbType.Int).Value = value;
                                cmd.Parameters.Add("@ordersID", SqlDbType.Int).Value = ordersID;
                                cmd.ExecuteNonQuery();
                            }
                            menuItemID++;
                        }
                        
                        foreach (int MenuIDValue in menuID)
                        {
                            ingredientIDList.Clear();

                            //This selects all of the ingredients for that item in the menu
                            using (SqlCommand ingredientIDcmd = new SqlCommand("SELECT ingredientID FROM tbl_ingredientItem WHERE menuID = @menuID", con))
                            {
                                ingredientIDcmd.Parameters.Add("@menuID", SqlDbType.Int).Value = MenuIDValue;

                                using (SqlDataReader reader = ingredientIDcmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        //Each row is added to the list of ingredients
                                        ingredientIDList.Add(Convert.ToInt32(reader[0]));
                                    }
                                }
                            }

                            foreach (int i in ingredientIDList)
                            {
                                //Removes values from the inventory page
                                //Foreach menu get the inventory items and - 1
                                using (SqlCommand remove = new SqlCommand("UPDATE tbl_ingredients SET numberOf = numberOf - 1 WHERE ingredientID = @ingredientID", con))
                                {
                                    remove.Parameters.Add("@ingredientID", SqlDbType.Int).Value = i;
                                    remove.ExecuteScalar();
                                }
                            }
                        }
                    }
                    lbl_finishedOrder.Show();
                    btn_addtoorder.Enabled = false;
                    btn_remove.Enabled = false;
                    btn_finish.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            if (menuName.Count == 0)
            {
                lbl_error.Text = "You cannot remove anything\nfrom an empty order";
                lbl_error.Show();
            }
            else
            {
                //This removes the last items price from the total price
                totalPrice -= price.Last();

                //This removes the last item from the list
                price.RemoveAt(price.Count - 1);
                menuName.RemoveAt(menuName.Count - 1);

                lbl_currentOrder.Text = "Current Order: \n\n";

                for (int count = 0; count < menuName.Count; count++)
                {
                    //Resets the label with the new order
                    lbl_currentOrder.Text += menuName[count] + " \t.....\t £ " + price[count].ToString("G29") + "\n";
                    lbl_totalPrice.Text = "Total Price: £ " + totalPrice.ToString("G29");
                }
                if (menuName.Count == 0)
                {
                    //Essentially resets the order to blank
                    lbl_totalPrice.Text = "Total Price: £ 0.00";
                }
            }
        }
    }
}