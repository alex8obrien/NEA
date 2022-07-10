using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NEA
{
    public partial class Staff_Overview : Form
    {
        public Staff_Overview()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>();
        List<int> ids = new List<int>();
        DataTable dt = new DataTable();

        public int StaffID { get; set; }
        public Form Menu { get; set; }
        public Form Owners { get; set; }

        private void Staff_Overview_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
            {
                con.Open();

                //This selects the data needed for the data grid view
                using (SqlCommand creategridView = new SqlCommand("SELECT staffID, firstname, lastname FROM tbl_staff", con))
                {
                    using (SqlDataReader reader = creategridView.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //This is a list of the staff IDs
                            ids.Add((int)reader[0]);
                            //This is a list of full names for the staff
                            names.Add(reader[1].ToString() + " " + reader[2].ToString());
                        }
                    }
                }
            }

            //Creating a custom data table
            dt.Columns.Add("Staff ID");
            dt.Columns.Add("Staff List");
            for (int i = 0; i < names.Count; i++)
            {
                //This loops through each value in the 2 lists
                //and adds them to a new row
                dt.Rows.Add(ids[i], names[i]);
            }
            //Binds the data source for the grid view
            dataGridView1.DataSource = dt;
            //User doesnt need to see the IDs
            dataGridView1.Columns[0].Visible = false;
        }
        
        private void Btn_menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            //Error label reset
            lbl_error.Hide();
            string fullname = txt_staffName.Text, admin = "No";
            int id = 0;

            //Loops through the data table to select row ID
            foreach (DataRow row in dt.Rows)
            {
                if (fullname == row[1].ToString())
                {
                    id = Convert.ToInt32(row[0].ToString());
                }
            }

            //If no fullname is found
            //Then the search has failed
            if (id == 0)
            {
                lbl_error.Text = "Please enter a person";
                lbl_error.Show();
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"data source=ALEXS-PC;initial catalog=cafeDB;trusted_connection=true"))
                {
                    con.Open();
                    using (SqlCommand cmdSelectStaff = new SqlCommand("SELECT * FROM tbl_staff WHERE staffID = @id", con))
                    {
                        cmdSelectStaff.Parameters.Add("@id", SqlDbType.Int).Value = id;

                        //All of the data is read from the table
                        using (SqlDataReader reader = cmdSelectStaff.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //If admin == 1 then admin = yes
                                if ((bool)reader[5])
                                { admin = "Yes"; }

                                //Populates info label
                                lbl_information.Text = "Phone number: " + reader[3].ToString() + "\nEmail: " + reader[4].ToString() + "\nAdmin: " + admin;
                            }
                        }
                    }

                    //This counts how many sales this staff member made
                    using (SqlCommand cmdSelectTransactions = new SqlCommand("SELECT COUNT(*) FROM tbl_orders WHERE staffID = @id", con))
                    {
                        cmdSelectTransactions.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        int count = (int)cmdSelectTransactions.ExecuteScalar();
                        lbl_information.Text += "\n\nTotal transactions: " + count;
                    }

                    //Selects the totalCost column based upon the staff ID
                    using (SqlCommand totalCost = new SqlCommand("SELECT SUM(totalCost) FROM tbl_orders WHERE staffID = @id", con))
                    {
                        totalCost.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        decimal sum = Convert.ToDecimal(totalCost.ExecuteScalar());
                        lbl_information.Text += "\nSum: " + sum.ToString("C");
                    }
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Selects the string in the menu name column of the selected row
                int rowID = e.RowIndex;
                DataGridViewRow row = this.dataGridView1.Rows[rowID];
                txt_staffName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void Btn_ownersMenu_Click(object sender, EventArgs e)
        {
            Owners.Show();
            this.Close();
        }
    }
}
