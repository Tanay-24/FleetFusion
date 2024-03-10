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
    public partial class Ship_Home_Page : Form
    {
        public Ship_Home_Page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Ships show_Ships = new Show_Ships();
            show_Ships.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ship_Add ship_Add = new Ship_Add();
            ship_Add.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ship_Login ship_Login = new Ship_Login();
            ship_Login.ShowDialog();
        }
    }
}
