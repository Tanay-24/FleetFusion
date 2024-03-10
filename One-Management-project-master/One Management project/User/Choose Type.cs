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
    public partial class Choose_Type : Form
    {
        public Choose_Type()
        {
            InitializeComponent();
        }

        private void btnRailwaybooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Railway user_Railway = new User_Railway();
            user_Railway.ShowDialog();
        }

        private void btnBusbooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Bus user_Bus = new User_Bus();
            user_Bus.ShowDialog();
        }

        private void btnFlightbooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Flight user_Flight = new User_Flight();
            user_Flight.ShowDialog();
        }

        private void btnShipbooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Ship user_Ship = new User_Ship();
            user_Ship.ShowDialog();
        }

        private void btnGoodsorTravelingbooking_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //User_Goods_or_Travel user_Goods_Or_Travel = new User_Goods_or_Travel();
            //user_Goods_Or_Travel.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ULogin1 uLogin1 = new ULogin1();
            uLogin1.ShowDialog();
        }
    }
}
