using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryMS
{
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Myprogress_progressChanged(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            Percentage.Text = "% " + startpoint;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
        }

        private void Firstpage_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
