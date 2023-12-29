using Entities.Concrete;
using Entities.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.ApiResponse.EntityConcrete;
using WinFormsApp2.DTOs;
using Color = Entities.Concrete.Color;

namespace WinFormsApp2
{
    public partial class ManageCars : Form
    {
        private const string apiUrl = "https://localhost:7095/api/";

        public ManageCars()
        {
            InitializeComponent();
            //dataGridView1.CellContentClick += LoadDataAsync;

        }

        private async void LoadDataAsync()
        {
            CarDetailDto cars = new CarDetailDto();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                try
                {
                    var response = await client.GetAsync(apiUrl + "cars/getcardetails");

                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = await response.Content.ReadAsStringAsync();
                        var veri = JsonConvert.DeserializeObject<DetailDTO>(responseData);
                        dataGridView1.DataSource = veri.data;

                        Console.WriteLine(veri.data.ToString());

                    }

                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode.ToString()} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private async void ManageCars_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
            LoadColorCombobox();
            LoadBrandCombobox();
            LoadCarModelCombobox();
            LoadFuelTypeCombobox();
            LoadGearTypeCombobox();
            // LoadDataAsync tamamlandıktan sonra diğer olayları dinlemeye başla
            //brandName.SelectedIndexChanged += brandName_GetBrands;
            //modelName.SelectedIndexChanged += modelName_SelectedIndexChanged;
            //colorName.SelectedIndexChanged += colorName_SelectedIndexChanged;
        }

        private async void LoadColorCombobox()
        {
            Color colors = new Color();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl + "colors/getall");
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var veri = JsonConvert.DeserializeObject<ColorApiResponse>(responseData);
                    colorName.DataSource = veri.Data;
                }
            }
        }

        private async void LoadBrandCombobox()
        {
            Brand brands = new Brand();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl + "brands/getall");
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var veri = JsonConvert.DeserializeObject<BrandApiResponse>(responseData);
                    brandName.DataSource = veri.Data;
                    brandName.DisplayMember = "BrandName";
                    brandName.ValueMember = "BrandId";
                }
            }
        }

        private async void LoadCarModelCombobox()
        {
            CarModel CarModels = new CarModel();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl + "carmodels/getall");
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var veri = JsonConvert.DeserializeObject<CarModelApiResponse>(responseData);
                    modelName.DataSource = veri.Data;
                    modelName.DisplayMember = "ModelName";
                    modelName.ValueMember = "ModelId";
                }
            }
        }

        private async void LoadFuelTypeCombobox()
        {
            FuelType fuelType = new FuelType();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl + "fueltypes/getall");
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var veri = JsonConvert.DeserializeObject<FuelTypeApiResponse>(responseData);
                    fuelTypeName.DataSource = veri.Data;
                    fuelTypeName.DisplayMember = "FuelTypeName";
                    fuelTypeName.ValueMember = "FuelTypeId";
                }
            }
        }

        private async void LoadGearTypeCombobox()
        {
            GearType gearType = new GearType();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl + "geartypes/getall");
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var veri = JsonConvert.DeserializeObject<GearTypeApiResponse>(responseData);
                    gearTypeName.DataSource = veri.Data;
                    gearTypeName.DisplayMember = "GearTypeName";
                    gearTypeName.ValueMember = "GearId";
                }
            }
        }
        //Ekleme
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Car carToAdd = new Car
                {

                    BrandId = Convert.ToInt32(brandName.SelectedValue),
                    ModelId = Convert.ToInt32(modelName.SelectedValue),
                    ColorId = Convert.ToInt32(colorName.SelectedValue),
                    FuelTypeId = Convert.ToInt32(fuelTypeName.SelectedValue),
                    GearTypeId = Convert.ToInt32(gearTypeName.SelectedValue),
                    ModelYear = Convert.ToInt32(modelYear.Text),
                    DailyPrice = Convert.ToDecimal(dailyPrice.Text),
                    CarImage = null,
                    IsSuitable = true
                };
                List<Car> carsToAdd = new List<Car> { carToAdd };

                string jsonData = JsonConvert.SerializeObject(carToAdd);

                using (HttpClient client = new HttpClient())
                {
                    
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("cars/add", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Araç başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode.ToString()} - {response.ReasonPhrase}");
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



        //Brand Combobox
        private async void brandName_GetBrands(object sender, EventArgs e)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        var response = await client.GetAsync(apiUrl + "brands/getall");

            //        if (response.IsSuccessStatusCode)
            //        {
            //            var responseData = await response.Content.ReadAsStringAsync();
            //            var veri = JsonConvert.DeserializeObject<BrandApiResponse>(responseData);

            //            if (brandApiResponse.Success)
            //            {
            //                brandName.DataSource = veri.Data;
            //                brandName.DisplayMember = "BrandName";
            //                brandName.ValueMember = "BrandId";

            //            }
            //            else
            //            {
            //                MessageBox.Show($"Error: {brandApiResponse.Message}");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Error: {response.StatusCode.ToString()} - {response.ReasonPhrase}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occurred: {ex.Message}");
            //    }
            //}
        }

        //CarModel Combobox
        private async void modelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CarModel carModels = new CarModel();
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        var response = await client.GetAsync(apiUrl + "carmodels/getall");

            //        if (response.IsSuccessStatusCode)
            //        {
            //            var responseData = await response.Content.ReadAsStringAsync();
            //            var carModelApiResponse = JsonConvert.DeserializeObject<CarModelApiResponse>(responseData);

            //            if (carModelApiResponse.Success)
            //            {
            //                modelName.DataSource = carModelApiResponse.Data;
            //                modelName.DisplayMember = "ModelName";
            //                modelName.ValueMember = "ModelId";

            //                await Console.Out.WriteLineAsync(carModels.ToString());
            //            }
            //            else
            //            {
            //                MessageBox.Show($"Error: {carModelApiResponse.Message}");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Error: {response.StatusCode.ToString()} - {response.ReasonPhrase}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occurred: {ex.Message}");
            //    }
            //}
        }

        //Color Combobox
        private async void colorName_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    using (HttpClient client = new HttpClient())
            //    {
            //        try
            //        {
            //            var response = await client.GetAsync(apiUrl + "colors/getall");

            //            if (response.IsSuccessStatusCode)
            //            {
            //                var responseData = await response.Content.ReadAsStringAsync();
            //                var colorApiResponse = JsonConvert.DeserializeObject<ColorApiResponse>(responseData);

            //                // Debug
            //                if (colorApiResponse.Success)
            //                {
            //                    this.Invoke((MethodInvoker)delegate
            //                    {
            //                        // ComboBox'ı temizle
            //                        colorName.DataSource = null;

            //                        // Veriyi ata
            //                        colorName.DataSource = colorApiResponse.Data;
            //                        colorName.DisplayMember = "ColorName";
            //                        colorName.ValueMember = "ColorId";

            //                        // DataBind metodu ile ComboBox'ı güncelle
            //                        colorName.DataBindings.Clear();
            //                        colorName.DataBindings.Add("DataSource", colorApiResponse.Data, null, false, DataSourceUpdateMode.OnPropertyChanged);
            //                        colorName.SelectedIndex = -1;
            //                    });
            //                }
            //                else
            //                {
            //                    MessageBox.Show($"Error: {colorApiResponse.Message}");
            //                }
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            //MessageBox.Show($"An error occurred: {ex.Message}");
            //        }

            //    }
        }

        //FuelType Combobox
        private async void fuelTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        var response = await client.GetAsync(apiUrl + "fueltypes/getall");

            //        if (response.IsSuccessStatusCode)
            //        {
            //            var responseData = await response.Content.ReadAsStringAsync();
            //            var fuelTypeApiResponse = JsonConvert.DeserializeObject<FuelTypeApiResponse>(responseData);

            //            if (fuelTypeApiResponse.Success)
            //            {
            //                // FuelType bilgilerini ComboBox içine ekleyin
            //                fuelTypeName.DataSource = fuelTypeApiResponse.Data;
            //                fuelTypeName.DisplayMember = "FuelTypeName"; // FuelType içindeki görüntülenecek özellik adı
            //                fuelTypeName.ValueMember = "FuelTypeId"; // FuelType içindeki değer özelliği adı
            //            }
            //            else
            //            {
            //                MessageBox.Show($"Error: {fuelTypeApiResponse.Message}");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Error: {response.StatusCode.ToString()} - {response.ReasonPhrase}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occurred: {ex.Message}");
            //    }
            //}
        }

        //GearType Combobox
        private async void gearTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        var response = await client.GetAsync(apiUrl + "geartypes/getall");

            //        if (response.IsSuccessStatusCode)
            //        {
            //            var responseData = await response.Content.ReadAsStringAsync();
            //            var gearTypeApiResponse = JsonConvert.DeserializeObject<GearTypeApiResponse>(responseData);

            //            if (gearTypeApiResponse.Success)
            //            {
            //                gearTypeName.DataSource = gearTypeApiResponse.Data;
            //                gearTypeName.DisplayMember = "GearTypeName";
            //                gearTypeName.ValueMember = "GearTypeId";
            //            }
            //            else
            //            {
            //                MessageBox.Show($"Error: {gearTypeApiResponse.Message}");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Error: {response.StatusCode.ToString()} - {response.ReasonPhrase}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occurred: {ex.Message}");
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
