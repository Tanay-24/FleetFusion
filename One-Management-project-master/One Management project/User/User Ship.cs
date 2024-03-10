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

namespace One_Management_project.User
{
    public partial class User_Ship : Form
    {
        public User_Ship()
        {
            InitializeComponent();
        }

        private void User_Ship_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM transportadd.shipadd", conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "shipadd");
                dataGridView1.DataSource = ds.Tables["shipadd"];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
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
            Choose_Type choose_Type = new Choose_Type();
            choose_Type.ShowDialog();
        }
    }
}
