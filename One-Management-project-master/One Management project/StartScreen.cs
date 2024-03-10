using System;
using System.Windows.Forms;

namespace One_Management_project
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
        private void progressBar1_Click(object sender, EventArgs e)
        {
         
        }

        int startpoint = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 70)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Choose_Login choose_Login = new Choose_Login();
                choose_Login.Show();
                this.Hide();
            }
        }
    }
}
