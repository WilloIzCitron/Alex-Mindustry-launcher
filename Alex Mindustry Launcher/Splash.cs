using System;
using System.Windows.Forms;

namespace Alex_Mindustry_Launcher
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLeft = 100;
            timer1.Start();
            label4.Text = "Copyright© Alex Mindustry " + DateTime.Now.Year +"";
        }

        public int timeLeft { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                this.progressBar1.Increment(1);

                if (timeLeft == 3)
                {
                    label1.Text = "Ready";
                }
                if (timeLeft == 30)
                {
                    label1.Text = "Loading Resources";
                }
                if (timeLeft == 60)
                {
                    label1.Text = "Loading Data";
                }
                if (timeLeft == 100)
                {
                    label1.Text = "Processing";
                }
            }

            else

            {

                timer1.Stop();

                new App().Show();

                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
