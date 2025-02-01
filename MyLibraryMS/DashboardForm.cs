using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryMS
{
    public partial class DashboardForm : Form
    {
        SqlConnection Con;
        public DashboardForm()
        {
            InitializeComponent();
            Con = DatabaseHelper.GetConnection();
        }

        private void BookCount_Click(object sender, EventArgs e)
        {
        }

        private void Return_Click(object sender, EventArgs e)
        {
            
        }

        private void Issue_Click(object sender, EventArgs e)
        {
           

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM BookTbl", Con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            sda1.Fill(dt1);

            BookCount.Text = dt1.Rows[0][0].ToString();
            Con.Close();

            Con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM LibrarianTbl", Con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(dt2);

            Admin.Text = dt2.Rows[0][0].ToString();
            Con.Close();


            Con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM ReturnTbl", Con);
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
            sda3.Fill(dt3);

            Return.Text = dt3.Rows[0][0].ToString();
            Con.Close();

            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM IssueTbl", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            Issue.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
