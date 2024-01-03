using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
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
    public partial class ManageRentals : Form
    {
        IRentalService _rentalService;
        IStatusService _statusService;
        ICustomerService _customerService;
        public ManageRentals()
        {
            InitializeComponent();
            _rentalService = new RentalManager(new EfRentalDal());
            _statusService = new StatusManager(new EfStatusDal());
            _customerService = new CustomerManager(new EfCustomerDal());

            LoadData();
            LoadCarStatuses();
        }   

        private async void LoadData()
        {
            var rentalDetails = _rentalService.GetRentalDetails();
            dataGridView1.DataSource = rentalDetails.Data;
            
        }

        private async void LoadCarStatuses()
        {
            var carStatuses = _statusService.GetAll();

            carStatus.DataSource = carStatuses.Data;
            carStatus.DisplayMember = "CarStatus";
            carStatus.ValueMember = "StatusId";
        }
        //Ekleme
        private void button_1_Click(object sender, EventArgs e)
        {

            Rental addToRental = new Rental()
            {
                CarId = int.TryParse(carId.Text, out int result) ? result : -1,
                CustomerId = int.TryParse(fullName.Text, out int customerResult) ? customerResult : -1,
                RentDate = rentDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                ReturnDate = returnDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                StatusId = Convert.ToInt32(carStatus.SelectedValue)
            };
            _rentalService.Add(addToRental);
            MessageBox.Show("Kiralama işlemi başarıyla gerçekleşti.");
            LoadData();
        }

        //Düzenleme
        private void button4_Click(object sender, EventArgs e)
        {
            Rental updateToRental = new Rental()
            {
                CarId = int.TryParse(carId.Text, out int result) ? result : -1,
                CustomerId = int.TryParse(fullName.Text, out int customerResult) ? customerResult : -1,
                RentDate = rentDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                ReturnDate = returnDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                StatusId = Convert.ToInt32(carStatus.SelectedValue)
            };
            _rentalService.Update(updateToRental);
            MessageBox.Show("Kiralama işlemi güncellendi");
            LoadData();
        }
        private async Task FillFormFromGridAsync(int e)
        {
            if (e >= 0 && e < dataGridView1.Rows.Count)
            {
                carId.Text = dataGridView1.Rows[e].Cells[0].Value.ToString();
                fullName.Text = dataGridView1.Rows[e].Cells[1].Value.ToString();
                rentDate.Text = dataGridView1.Rows[e].Cells[3].Value.ToString();
                returnDate.Text = dataGridView1.Rows[e].Cells[2].Value.ToString();
                carStatus.Text = dataGridView1.Rows[e].Cells[4].Value.ToString();
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillFormFromGridAsync(e.RowIndex);
        }


    }
}
