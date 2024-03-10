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
    public partial class Airline_Home_page : Form
    {
        public Airline_Home_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flight_Add flight_Add = new Flight_Add();
            flight_Add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Flight show_Flight = new Show_Flight();
            show_Flight.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Airline_Login airline_Login = new Airline_Login();
            airline_Login.ShowDialog();
        }
    }
}
