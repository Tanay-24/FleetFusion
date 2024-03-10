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

namespace One_Management_project.Ship_Folder
{
    public partial class Show_Ships : Form
    {
        public Show_Ships()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ship_Home_Page ship_Home_Page = new Ship_Home_Page();
            ship_Home_Page.ShowDialog();
        }

        private void Show_Ships_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM transportadd.shipadd", conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "shipadd");
                dataGridView1.DataSource = ds.Tables["shipadd"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 15);
        }
    }
}
