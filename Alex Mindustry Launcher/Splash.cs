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
        }

        public int timeLeft { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                this.progressBar1.Increment(1);

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
