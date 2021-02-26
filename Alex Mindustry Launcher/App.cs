using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alex_Mindustry_Launcher
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!text.Contains("mindustry.exe"))
            {
                errorProvider1.SetError(textBox1, "oh no. Invalid mindustry.exe path");
            }
            else if (text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "oh no. mindustry path must be fill");
            }
            else
            {
                this.Hide();
                System.Diagnostics.Process.Start(text);
            }
        }

        public string text;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void github_Click(object sender, EventArgs e)
        {

        }
    }
}
