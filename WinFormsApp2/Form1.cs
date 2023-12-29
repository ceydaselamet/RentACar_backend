using Entities.Concrete;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SqlConnection sqlConnection = new SqlConnection("Data Source=WIN-47H6MAU8L06;User ID=sa;Password=Rentacar43;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            try
            {
                sqlCommand = new SqlCommand("Select * from users", sqlConnection);

                adapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            User user;
            foreach (DataRow row in dataTable.Rows)
            {
                MessageBox.Show(row["FirstName"].ToString());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                
            
        }
        SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        DataTable dataTable;
    }
}