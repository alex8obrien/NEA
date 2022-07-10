using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NEA
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        public Form Home { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int StaffID { get; set; }
        public bool Admin { get; set; }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_orderingPage_Click(object sender, EventArgs e)
        {
            Form orderingPage = new Ordering_Page
            {
                StaffID = StaffID,
                Menu = this
            };
            orderingPage.Show();
            this.Hide();
        }

        private void Btn_ownersMenu_Click(object sender, EventArgs e)
        {
            Form ownersMenu = new Owners_Menu
            {
                StaffID = StaffID,
                Menu = this
            };
            ownersMenu.Show();
            this.Hide();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            lbl_name.Text += Firstname + " " + Lastname;
            if (Admin == true)
            {
                btn_ownersMenu.Show();
            }
        }

        private void Btn_inventoryPage_Click(object sender, EventArgs e)
        {
            Form inventory = new Inventory
            {
                StaffID = StaffID,
                Menu = this
            };
            inventory.Show();
            this.Hide();
        }

        private void Btn_logoff_Click(object sender, EventArgs e)
        {
            Home.Show();
            this.Close();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Form update = new Staff_Update
            {
                StaffID = StaffID,
                Menu = this
            };
            update.Show();
            this.Hide();
        }
    }
}