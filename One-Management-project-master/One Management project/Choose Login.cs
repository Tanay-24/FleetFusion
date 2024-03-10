using One_Management_project.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Management_project
{
    public partial class Choose_Login : Form
    {
        public Choose_Login()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ULogin1 login = new ULogin1();  
            login.ShowDialog();
        }
    }
}
