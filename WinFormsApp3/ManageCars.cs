using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Firebase.Storage;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class ManageCars : Form
    {
        private ICarService _carService;
        private IBrandService _brandService;
        private ICarModelService _carModelService;
        private IColorService _colorService;
        private IFuelTypeService _fuelTypeService;
        private IGearTypeService _gearTypeService;

        public ManageCars()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
            _brandService = new BrandManager(new EfBrandDal());
            _carModelService = new CarModelManager(new EfCarModelDal());
            _colorService = new ColorManager(new EfColorDal());
            _fuelTypeService = new FuelTypeManager(new EfFuelTypeDal());
            _gearTypeService = new GearTypeManager(new EfGearTypeDal());


            LoadData();
            LoadBrandCombobox();
            LoadCarModelCombobox();
            LoadColorCombobox();
            LoadGearTypeCombobox();
            LoadFuelTypeCombobox();
        }

        //private List<CarDetailDto> ConvertJsonToCarDetailList(string json)
        //{
        //    var result = JsonConvert.DeserializeObject<ResponseModel<List<CarDetailDto>>>(json);
        //    return result.Data;
        //}
        private async void LoadData()
        {
            var carDetails = _carService.GetCarDetails();
            dataGridView1.DataSource = carDetails.Data;
        }

        private async void LoadBrandCombobox()
        {
            var brands = _brandService.GetAll();

            brandName.DataSource = brands.Data;
            brandName.DisplayMember = "BrandName";
            brandName.ValueMember = "BrandId";
        }

        private async void LoadCarModelCombobox()
        {
            var carModels = _carModelService.GetAll();

            carModelName.DataSource = carModels.Data;
            carModelName.DisplayMember = "ModelName";
            carModelName.ValueMember = "ModelId";
        }

        private async void LoadColorCombobox()
        {
            var colors = _colorService.GetAll();

            colorName.DataSource = colors.Data;
            colorName.DisplayMember = "ColorName";
            colorName.ValueMember = "ColorId";
        }

        private async void LoadFuelTypeCombobox()
        {
            var fuelTypes = _fuelTypeService.GetAll();

            fuelTypeName.DataSource = fuelTypes.Data;
            fuelTypeName.DisplayMember = "FuelTypeName";
            fuelTypeName.ValueMember = "FuelTypeId";
        }

        private async void LoadGearTypeCombobox()
        {
            var gearTypes = _gearTypeService.GetAll();

            gearTypeName.DataSource = gearTypes.Data;
            gearTypeName.DisplayMember = "GearTypeName";
            gearTypeName.ValueMember = "GearId";
        }

        //Ekleme
        private async void button_1_ClickAsync(object sender, EventArgs e)
        {
            if (!urlInLocale.Equals(""))
                imageUrlAdress = await uploadAsync(urlInLocale);
            Car addToCar = new Car()
            {
                BrandId = Convert.ToInt32(brandName.SelectedValue),
                ModelId = Convert.ToInt32(carModelName.SelectedValue),
                ColorId = Convert.ToInt32(colorName.SelectedValue),
                FuelTypeId = Convert.ToInt32(fuelTypeName.SelectedValue),
                GearTypeId = Convert.ToInt32(gearTypeName.SelectedValue),
                ModelYear = Convert.ToInt32(modelYear.Text),
                DailyPrice = Convert.ToDecimal(dailyPrice.Text),
                CarImage = imageUrlAdress,
                IsSuitable = true
            };
            _carService.Add(addToCar);
            MessageBox.Show("Araç başarıyla eklendi.");
            LoadData();
            urlInLocale = "";
        }

        //Düzenleme
        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            if (!urlInLocale.Equals(""))
                imageUrlAdress = await uploadAsync(urlInLocale);
            Car updatedCar = new Car()
            {
                CarId = Convert.ToInt32(carId.Text),
                BrandId = Convert.ToInt32(brandName.SelectedValue),
                ModelId = Convert.ToInt32(carModelName.SelectedValue),
                ColorId = Convert.ToInt32(colorName.SelectedValue),
                FuelTypeId = Convert.ToInt32(fuelTypeName.SelectedValue),
                GearTypeId = Convert.ToInt32(gearTypeName.SelectedValue),
                ModelYear = Convert.ToInt32(modelYear.Text),
                DailyPrice = Convert.ToDecimal(dailyPrice.Text),
                CarImage = imageUrlAdress,
                IsSuitable = true
            };

            _carService.Update(updatedCar);
            MessageBox.Show("Araç başarıyla güncellendi.");
            LoadData();
            urlInLocale = "";
        }

        // SEÇİLİ ARABAYI SİL
        private void button3_Click(object sender, EventArgs e)
        {
            Car deletedCar = new Car()
            {
                CarId = Convert.ToInt32(carId.Text),
                BrandId = Convert.ToInt32(brandName.SelectedValue),
                ModelId = Convert.ToInt32(carModelName.SelectedValue),
                ColorId = Convert.ToInt32(colorName.SelectedValue),
                FuelTypeId = Convert.ToInt32(fuelTypeName.SelectedValue),
                GearTypeId = Convert.ToInt32(gearTypeName.SelectedValue),
                ModelYear = Convert.ToInt32(modelYear.Text),
                DailyPrice = Convert.ToDecimal(dailyPrice.Text),
                CarImage = imageUrlAdress,
                IsSuitable = true
            };
            DialogResult result = MessageBox.Show("Bu aracı silmek istediğinizden emin misiniz?", "Araç Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Silme işlemi
                _carService.Delete(deletedCar);
                MessageBox.Show("Araç başarıyla silindi.");
                LoadData();
            }
        }

        private async Task FillFormFromGridAsync(int e)
        {
            if (e >= 0 && e < dataGridView1.Rows.Count)
            {
                carId.Text = dataGridView1.Rows[e].Cells[0].Value.ToString();
                brandName.Text = dataGridView1.Rows[e].Cells[1].Value.ToString();
                carModelName.Text = dataGridView1.Rows[e].Cells[3].Value.ToString();
                colorName.Text = dataGridView1.Rows[e].Cells[2].Value.ToString();
                fuelTypeName.Text = dataGridView1.Rows[e].Cells[4].Value.ToString();
                gearTypeName.Text = dataGridView1.Rows[e].Cells[5].Value.ToString();
                modelYear.Text = dataGridView1.Rows[e].Cells[6].Value.ToString();
                dailyPrice.Text = dataGridView1.Rows[e].Cells[7].Value.ToString();

                if (!dataGridView1.Rows[e].Cells[8].Value.ToString().Equals(""))
                {
                    pictureBox1.Image = await DownloadImageAsync(dataGridView1.Rows[e].Cells[8].Value.ToString());
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Samet\\Desktop\\car-default.jpg");
                }
                string s = dataGridView1.Rows[e].Cells[9].Value.ToString();

            }
        }

        private async Task<Image> DownloadImageAsync(string imageUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] imageBytes = webClient.DownloadData(imageUrl);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button_1.Enabled = false;
            FillFormFromGridAsync(e.RowIndex);

        }

        //resmin internetteki konumunu döndürür.
        private async Task<string> uploadAsync(string url)
        {
            Guid guid = Guid.NewGuid();
            var downloadUrl = "";

            var stream = File.Open(url, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            var task = new FirebaseStorage("uploadimageiot.appspot.com")
                .Child("carImages")
                .Child(guid.ToString() + ".png")
                .PutAsync(stream);

            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

            downloadUrl = await task;

            stream.Close();
            stream.Dispose();

            return downloadUrl.ToString();
        }

        // resmin bilgisayardaki konumunu döndürür.
        private string SelectImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    return selectedImagePath;
                }

                openFileDialog.Dispose();
            }
            return "";
        }
        private string imageUrlAdress = "";
        private string urlInLocale = "";
        private void selectCarImageButton_Click(object sender, EventArgs e)
        {
            urlInLocale = SelectImage();
            pictureBox1.Image = Image.FromFile(urlInLocale);
        }

        private void addButtonActive(object sender, EventArgs e)
        {
            button_1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = false;
        }
    }
}
