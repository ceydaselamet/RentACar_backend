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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

        private void FillFormFromGrid(int e)
        {
            if (e >= 0 && e < dataGridView1.Rows.Count)
            {
                userId.Text = dataGridView1.Rows[e].Cells[0].Value.ToString();
                firstName.Text = dataGridView1.Rows[e].Cells[1].Value.ToString();
                lastName.Text = dataGridView1.Rows[e].Cells[3].Value.ToString();
                email.Text = dataGridView1.Rows[e].Cells[2].Value.ToString();
                password.Text = dataGridView1.Rows[e].Cells[4].Value.ToString();
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillFormFromGrid(e.RowIndex);
        }
    }
}
