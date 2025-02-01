using System;
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
            FormHelper.ExitApplication();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new StudentForm());

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new BookTbl());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new LibranianForm());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            FormHelper.ShowForm(this, new IssueBook());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApplication();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormHelper.LogOut(this);
        }



        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new ReturnBook());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }
    }
}
