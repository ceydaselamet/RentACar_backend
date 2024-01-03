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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp3
{
    public partial class ManageMaintenances : Form
    {
        private IMaintenanceService _maintenanceService;
        private IMaintenanceDescriptionService _maintenanceDescriptionService;
        public ManageMaintenances()
        {
            InitializeComponent();
            _maintenanceService = new MaintenanceManager(new EfMaintenanceDal());
            _maintenanceDescriptionService = new MaintenanceDescriptionManager(new EfMaintenanceDescriptionDal());

            dataGridView1.AutoGenerateColumns = true;
            LoadData();
            LoadMaintenceDescriptionTypeCombobox();
        }

        private void LoadData()
        {
            var maintenanceDetails = _maintenanceService.GetMeintenanceDetails();
            dataGridView1.DataSource = maintenanceDetails.Data;
        }

        private void LoadMaintenceDescriptionTypeCombobox()
        {
            var maintenanceDescriptionTypes = _maintenanceDescriptionService.GetAll();

            maintenanceType.DataSource = maintenanceDescriptionTypes.Data;
            maintenanceType.DisplayMember = "MaintenanceType";
            maintenanceType.ValueMember = "MaintenanceDescriptionId";
        }

        private void FillFormFromGrid(int e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            if (e >= 0 && e < dataGridView1.Rows.Count)
            {
                maintenanceId.Text = dataGridView1.Rows[e].Cells[0].Value.ToString();
                carId.Text = dataGridView1.Rows[e].Cells[1].Value.ToString();
                maintenanceType.Text = dataGridView1.Rows[e].Cells[2].Value.ToString(); // ComboBox'a uygun değeri seç

                // DateTimePicker'a tarih değeri atarken uygun bir tarih nesnesine çevir
                if (DateTime.TryParse(dataGridView1.Rows[e].Cells[3].Value.ToString(), out DateTime dateValue))
                {
                    date.Value = dateValue;
                }
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillFormFromGrid(e.RowIndex);
        }

        //Ekleme
        private void button_1_Click(object sender, EventArgs e)
        {
            Maintenance addToMaintenance = new Maintenance()
            {
                CarId = Convert.ToInt32(carId.Text),
                MaintenanceDescriptionId = Convert.ToInt32(maintenanceType.SelectedValue),
                Date = date.Value
            };
            _maintenanceService.Add(addToMaintenance);
            MessageBox.Show("Araç bakıma gönderildi.");
            LoadData();
        }

        //Düzenleme
        private void button2_Click(object sender, EventArgs e)
        {
            Maintenance updateToMaintenance = new Maintenance()
            {
                MaintenanceId = Convert.ToInt32(maintenanceId.Text),
                CarId = Convert.ToInt32(carId.Text),
                MaintenanceDescriptionId = Convert.ToInt32(maintenanceType.SelectedValue),
                Date = date.Value
            };
            _maintenanceService.Update(updateToMaintenance);
            MessageBox.Show("Araç bakımı güncellendi");
            LoadData();
        }

        //Silme
        private void button3_Click(object sender, EventArgs e)
        {
            Maintenance deleteToMaintenance = new Maintenance()
            {
                MaintenanceId = Convert.ToInt32(maintenanceId.Text),
                CarId = Convert.ToInt32(carId.Text),
                MaintenanceDescriptionId = Convert.ToInt32(maintenanceType.SelectedValue),
                Date = date.Value
            };
            DialogResult result = MessageBox.Show("Bu bakımı silmek istediğinizden emin misiniz?", "Bakım Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Silme işlemi
                _maintenanceService.Delete(deleteToMaintenance);
                MessageBox.Show("Araç bakım başarıyla silindi.");
                LoadData();
            }
        }
    }
}
