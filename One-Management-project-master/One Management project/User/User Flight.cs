using MySql.Data.MySqlClient;
using One_Management_project.Airline_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Management_project.User
{
    public partial class User_Flight : Form
    {
        public User_Flight()
        {
            InitializeComponent();
        }

        private void User_Flight_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM transportadd.flightadd", conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "flightadd");
                dataGridView1.DataSource = ds.Tables["flightadd"];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 15);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_ATicket_Book user_ATicket_Book = new User_ATicket_Book();
            user_ATicket_Book.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choose_Type choose_Type = new Choose_Type();
            choose_Type.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
