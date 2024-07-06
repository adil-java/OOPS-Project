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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm student = new StudentForm();
            student.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookTbl book = new BookTbl();
            book.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibranianForm libranian = new LibranianForm();
            libranian.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            this.Hide();
            IssueBook issuebook = new IssueBook();
            issuebook.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
           
        }


        private void label5_Click(object sender, EventArgs e)
        {

           
        }
    }
}
