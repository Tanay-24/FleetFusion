using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Management_project.Airline_Folder
{
    public partial class Show_Flight : Form
    {
        public Show_Flight()
        {
            InitializeComponent();
        }

        private void Show_Flight_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM transportadd.flightadd", conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "flightadd");
                dataGridView1.DataSource = ds.Tables["flightadd"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 15);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Airline_Home_page home_Page = new Airline_Home_page();
            home_Page.ShowDialog();
        }
    }
}
