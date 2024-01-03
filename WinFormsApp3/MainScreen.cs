using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void ManageCarsButton_Click(object sender, EventArgs e)
        {
            ManageCars manageCars = new ManageCars();
            manageCars.Show();
        }

        private void ManageRentalsButton_Click(object sender, EventArgs e)
        {
            ManageRentals manageRentals = new ManageRentals();
            manageRentals.Show();
        }

        private void ManageUsersButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void ManageMaintenancesButton_Click(object sender, EventArgs e)
        {
            ManageMaintenances manageMaintenances = new ManageMaintenances();
            manageMaintenances.Show();
        }
    }
}
