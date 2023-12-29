using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
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
        private IRentalService _rentalService;
        private IStatusService _statusService;
        private IBrandService _brandService;
        public ManageRentals()
        {
            InitializeComponent();
            _rentalService = new RentalManager(new EfRentalDal());
            _statusService = new StatusManager(new EfStatusDal());
            _brandService = new BrandManager(new EfBrandDal());

            LoadData();
            LoadCarStatus();
            LoadBrandCombobox();
        }

        private async void LoadData()
        {
            var rentalDetails = _rentalService.GetRentalDetails();
            dataGridView1.DataSource = rentalDetails.Data;

            if (rentalDetails.Data.Count > 0)
            {
                var firstRental = rentalDetails.Data.First();
                rentDate.Value = firstRental.RentDate;

                if (rentalDetails.Data.Any(r => r.ReturnDate.HasValue))
                {
                    var firstReturnedRental = rentalDetails.Data.First(r => r.ReturnDate.HasValue);
                    returnDate.Value = firstReturnedRental.ReturnDate.Value;
                }
            }
        }

        private async void LoadCarStatus()
        {
            var carStatuses = _statusService.GetAll();

            carStatus.DataSource = carStatuses.Data;
            carStatus.DisplayMember = "CarStatus";
            carStatus.ValueMember = "StatusId";
        }

        private async void LoadBrandCombobox()
        {
            var brands = _brandService.GetAll();

            brandName.DataSource = brands.Data;
            brandName.DisplayMember = "BrandName";
            brandName.ValueMember = "BrandId";
        }

        private void getRentalDetails_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
