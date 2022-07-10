using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA
{
    public partial class Owners_Menu : Form
    {
        public Owners_Menu()
        {
            InitializeComponent();
        }

        public int StaffID { get; set; }
        public Form Menu { get; set; }

        private void Btn_staffOverview_Click(object sender, EventArgs e)
        {
            Form sales = new Staff_Overview()
            {
                StaffID = StaffID,
                Owners = this,
                Menu = Menu,
            };
            sales.Show();
            this.Close();
        }

        private void Btn_restaurantOverview_Click(object sender, EventArgs e)
        {
            Form restaurant = new Owner()
            {
                Staff = StaffID,
                Menu = Menu,
                Owners = this,
            };
            restaurant.Show();
            this.Close();
        }

        private void Btn_menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }
    }
}
