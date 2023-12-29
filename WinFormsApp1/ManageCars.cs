using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class ManageCars : Form
    {
        private readonly ICarService _carService;

        public ManageCars(ICarService carService)
        {
            InitializeComponent();
            _carService = carService;
        }
        public ManageCars()
        {
            InitializeComponent();
        }
        private void ManageCars_Load(object sender, EventArgs e)
        {
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            var carDetails = _carService.GetCarDetails();

            if (carDetails.Success)
            {
                dataGridView1.DataSource = carDetails.Data;
            }
            else
            {
                MessageBox.Show(carDetails.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
