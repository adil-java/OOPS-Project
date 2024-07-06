using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibraryMS
{
    public partial class BookTbl : Form
    {
        public BookTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\oops project\MyLibraryMS\MyLibraryMS\Mylibrarydb.mdf"";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void BookTbl_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.BookGridView.Rows[e.RowIndex];
                BookName.Text = row.Cells[0].Value.ToString();
                AuthorName.Text = row.Cells[1].Value.ToString();
                PubName.Text = row.Cells[2].Value.ToString();
                BookPrice.Text = row.Cells[3].Value.ToString();
                BookQty.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BookName.Text == "" || AuthorName.Text == ""||BookQty.Text=="")
            {
                MessageBox.Show("Missing Information");
                return;
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO BookTbl values('" + BookName.Text + "','" + AuthorName.Text +"','"+PubName.Text+"','" + BookPrice.Text + "','" + BookQty.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Added Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(BookName.Text))
            {
                MessageBox.Show("Enter The Book Id");
            }
            else
            {
                Con.Open();
                string query = "UPDATE BookTbl set BookName='" + BookName.Text + "',Author='" + AuthorName.Text + "',Qty='" + BookQty.Text + "' where BookName=" + BookName.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Updated");
                Con.Close();
                populate();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Id.Text))
            {
                MessageBox.Show("Enter The Book Id");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM BookTbl where BookID=" + Id.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void BookName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Id_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
