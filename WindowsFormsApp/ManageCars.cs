using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.DTOs;


namespace WindowsFormsApp
{
    public partial class ManageCars : Form
    {
        private const string apiUrl = "https://localhost:44314/api/";
        public ManageCars()
        {
            InitializeComponent();
        }

        private async Task comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        List<CarDetailDto> carDetailsDto = JsonConvert.DeserializeObject<List<CarDetailDto>>(responseData);

                        dataGridView1.DataSource = carDetailsDto;
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
    }
}
