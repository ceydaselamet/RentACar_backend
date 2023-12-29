using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class ManageUsers : Form
    {
        private IUserService _userService;
        public ManageUsers()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());

            LoadData();
        }


        private void LoadData()
        {
            var users = _userService.GetAll();
            dataGridView1.DataSource = users.Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();

            // Kullanıcı arama işlemi
            var users = _userService.GetAll();

            if (users.Success)
            {
                // DataGridView'deki her bir satırı kontrol et
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool rowVisible = false;

                    // DataGridView'deki her bir hücreyi kontrol et
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Hücrenin metnini küçük harfe çevir
                        string cellText = cell.Value?.ToString().ToLower();

                        // Arama metni ile hücrenin metni karşılaştır
                        if (cellText != null && cellText.Contains(searchText))
                        {
                            rowVisible = true;
                            break;
                        }
                    }

                    // Eğer herhangi bir hücre eşleşiyorsa satırı göster, aksi takdirde gizle
                    row.Visible = rowVisible;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //Ekleme
        private void button_1_Click(object sender, EventArgs e)
        {
            User userToAdd = new User()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Email = email.Text,
                Password = password.Text
            };
            _userService.Add(userToAdd);
            MessageBox.Show("Kullanıcı başarıyla eklendi.");
            LoadData();
        }

        //Düzenleme
        private void button4_Click(object sender, EventArgs e)
        {
            User userToUpdate = new User()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Email = email.Text,
                Password = password.Text
            };
            _userService.Update(userToUpdate);
            MessageBox.Show("Kullanıcı başarıyla güncellendi.");
            LoadData();
        }

        //Silme
        private void button3_Click(object sender, EventArgs e)
        {
            User userToDelete = new User()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Email = email.Text,
                Password = password.Text
            };
            DialogResult result = MessageBox.Show("Bu kullanıcıyı silmek istediğinizden emin misiniz?", "Kullanıcı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _userService.Delete(userToDelete);
                MessageBox.Show("Araç başarıyla silindi.");
                LoadData();
            }
        }
        private void FillFormFromGrid(int e)
        {
            if (e >= 0 && e < dataGridView1.Rows.Count)
            {
                userId.Text = dataGridView1.Rows[e].Cells[0].Value.ToString();
                firstName.Text = dataGridView1.Rows[e].Cells[1].Value.ToString();
                lastName.Text = dataGridView1.Rows[e].Cells[3].Value.ToString();
                email.Text = dataGridView1.Rows[e].Cells[2].Value.ToString();
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillFormFromGrid(e.RowIndex);
        }
    }
}
