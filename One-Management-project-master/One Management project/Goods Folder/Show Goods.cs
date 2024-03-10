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

namespace One_Management_project.Goods_Folder
{
    public partial class Show_Goods : Form
    {
        public Show_Goods()
        {
            InitializeComponent();
        }

        private void Show_Goods_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM transportadd.goodsadd", conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "goodsadd");
                dataGridView1.DataSource = ds.Tables["goodsadd"];
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
            Home_Page home_Page = new Home_Page();
            home_Page.ShowDialog();
        }
    }
}
