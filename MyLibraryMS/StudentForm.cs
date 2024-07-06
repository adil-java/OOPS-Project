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
    public partial class StudentForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\oops project\MyLibraryMS\MyLibraryMS\Mylibrarydb.mdf"";Integrated Security=True");
        public StudentForm()
        {
            InitializeComponent();
        }

        public void population()
        {
            Con.Open();
            string query = "SELECT *FROM StudentTbl";
            SqlDataAdapter adapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(adapt);
            var ds = new DataSet();
            adapt.Fill(ds);
            StudentGridView.DataSource = ds.Tables[0];
            Con.Close();

       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            population();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(StudName.Text == "" || StudId.Text == "" || StudDept.Text == "" || StudPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl values(" + StudId.Text + ",'" + StudName.Text + "','" + StudDept.Text + "','"+ StudSem.Text +"','" + StudPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added");
                Con.Close();
                population();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        if(StudId.Text=="")
                   {
            MessageBox.Show("Enter The Student Id");
        }
                   else
            {
            Con.Open();
            string query = "UPDATE StudentTbl set StdName='" + StudName.Text + "',StdDept='" + StudDept.Text + "',StdPhone='" + StudPhone.Text +"',Sem='"+StudSem.Text+ "' where StdId=" + StudId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Updated");
                Con.Close();
            population();
        }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(StudId.Text=="")
            {
                MessageBox.Show("Enter The Student Id");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM StudentTbl where StdId=" + StudId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Deleted");
                Con.Close();
                population();
            }
        }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StudentGridView.Rows[e.RowIndex];
                StudId.Text = row.Cells[0].Value.ToString();
                StudName.Text = row.Cells[1].Value.ToString();
                StudDept.Text = row.Cells[2].Value.ToString();
                StudSem.Text = row.Cells[3].Value.ToString();
                StudPhone.Text = row.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
