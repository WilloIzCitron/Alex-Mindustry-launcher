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
            this.Hide();
            System.Diagnostics.Process.Start("mindustry.exe");
        }
    }
}
