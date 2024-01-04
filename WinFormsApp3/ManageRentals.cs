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
        ICarService _carService;

        DataGridViewButtonColumn approveButtonColumn;
        DataGridViewButtonColumn rejectButtonColumn;

        public ManageRentals()
        {
            InitializeComponent();
            _rentalService = new RentalManager(new EfRentalDal());
            _statusService = new StatusManager(new EfStatusDal());
            _carService = new CarManager(new EfCarDal());

            approveButtonColumn = new DataGridViewButtonColumn();
            approveButtonColumn.Name = "btnApprove_Click";
            approveButtonColumn.Text = "Onayla";
            approveButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(approveButtonColumn);

            rejectButtonColumn = new DataGridViewButtonColumn();
            rejectButtonColumn.Name = "btnReject_Click";
            rejectButtonColumn.Text = "Reddet";
            rejectButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(rejectButtonColumn);

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
        //Onaylama
        private void button_1_Click(object sender, EventArgs e)
        {
            /*
            Rental addToRental = new Rental()
            {
                CarId = int.TryParse(carId.Text, out int result) ? result : -1,
                CustomerId = int.TryParse(fullName.Text, out int customerResult) ? customerResult : -1,
                RentDate = rentDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                ReturnDate = returnDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                CarStatusId = Convert.ToInt32(carStatus.SelectedValue)
            };
            _rentalService.Add(addToRental);
            MessageBox.Show("Kiralama işlemi başarıyla gerçekleşti.");
            */
            LoadData();
        }

        //Reddetme
        private void button4_Click(object sender, EventArgs e)
        {
            /*
            Rental updateToRental = new Rental()
            {
                CarId = int.TryParse(carId.Text, out int result) ? result : -1,
                CustomerId = int.TryParse(fullName.Text, out int customerResult) ? customerResult : -1,
                RentDate = rentDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                ReturnDate = returnDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                CarStatusId = Convert.ToInt32(carStatus.SelectedValue)
            };
            _rentalService.Update(updateToRental);
            MessageBox.Show("Kiralama işlemi güncellendi");
            */
            LoadData();
        }

        private async Task FillFormFromGridAsync(int e)
        {
            /*
            if (e >= 0 && e < dataGridView1.Rows.Count)
            {
                carId.Text = dataGridView1.Rows[e].Cells[0].Value.ToString();
                fullName.Text = dataGridView1.Rows[e].Cells[1].Value.ToString();
                rentDate.Text = dataGridView1.Rows[e].Cells[3].Value.ToString();
                returnDate.Text = dataGridView1.Rows[e].Cells[2].Value.ToString();
                carStatus.Text = dataGridView1.Rows[e].Cells[4].Value.ToString();
            }
            */
        }



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rentalId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            

            if (e.ColumnIndex == dataGridView1.Columns["btnApprove_Click"].Index)
            {
                ProcessRentalApproval(rentalId);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["btnReject_Click"].Index)
            {
                ProcessRentalRejection(rentalId);
            }

            LoadData();
        }

        private void ProcessRentalApproval(int rentalId)
        {
            Rental rental = GetRentalById(rentalId);
            if (rental != null)
            {
                SetCarSuitable(rental.CarId, false);
                SetRentalStatus(rentalId, "Onaylandı");
            }
        }

        private void ProcessRentalRejection(int rentalId)
        {
            Rental rental = GetRentalById(rentalId);
            if (rental != null)
            {
                SetCarSuitable(rental.CarId, true);
                SetRentalStatus(rentalId, "Reddedildi");
            }
        }
        private void SetCarSuitable(int carId, bool isSuitable)
        {
            Car car = GetByCarId(carId);

            if (car != null)
            {
                car.IsSuitable = isSuitable;
                _carService.Update(car);
            }
        }

        private void SetRentalStatus(int rentalId, string status)
        {
            Rental rental = GetRentalById(rentalId);

            if (rental != null)
            {
                rental.CarStatusId = GetCarStatusIdByName(status);
                _rentalService.Update(rental);
            }
        }

        private Car GetByCarId(int carId)
        {
            return _carService.GetById(carId).Data;
        }

        private Rental GetRentalById(int rentalId)
        {
            return _rentalService.GetById(rentalId).Data;
        }

        private int GetCarStatusIdByName(string statusName)
        {
            return _statusService.GetByName(statusName).Data.StatusId;
        }


    }
}
