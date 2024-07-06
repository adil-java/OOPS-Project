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
    public partial class LibranianForm : Form
    {
    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\oops project\MyLibraryMS\MyLibraryMS\Mylibrarydb.mdf"";Integrated Security=True");
        public LibranianForm()
        {
            InitializeComponent();
        }
      
        public void population()
        {
            Con.Open();
            string query = "SELECT *FROM LibrarianTbl";
            SqlDataAdapter adapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(adapt);
            var ds = new DataSet();
            adapt.Fill(ds);
            LibraryGridView.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                  
        }
        //Add Librarian
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LibId.Text) || string.IsNullOrWhiteSpace(LibName.Text) || string.IsNullOrWhiteSpace(Libpass.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
               
                
                    Con.Open();

                    string query = "INSERT INTO LibrarianTbl (LibId, LibName, LibPass, LibPhone) VALUES (@LibId, @LibName, @LibPass, @LibPhone)";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@LibId", LibId.Text);
                    cmd.Parameters.AddWithValue("@LibName", LibName.Text);
                    cmd.Parameters.AddWithValue("@LibPass", Libpass.Text);
                    cmd.Parameters.AddWithValue("@LibPhone", Libphone.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Librarian Added Successfully");

                    population(); // Refresh dataGridView1
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Handle exceptions (logging, etc.)
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < LibraryGridView.Rows.Count)
                {
                    DataGridViewRow selectedRow = LibraryGridView.Rows[e.RowIndex];

                    LibId.Text = selectedRow.Cells[0].Value?.ToString();
                    LibName.Text = selectedRow.Cells[1].Value?.ToString();
                    Libpass.Text = selectedRow.Cells[2].Value?.ToString();
                    Libphone.Text = selectedRow.Cells[3].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void LibranianForm_Load_1(object sender, EventArgs e)
        {
            population();
        }

        //Delete Librarian
        private void button3_Click(object sender, EventArgs e)
        {
            if(LibId.Text == "")
            {
                MessageBox.Show("Enter The Librarian Information needed to update");
            }
            else
            {
                
                    Con.Open();
                    string query = "DELETE FROM LibrarianTbl WHERE LibId = '" + LibId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Deleted Successfully");
                Con.Close();
                population();
                
                
            }
        }
        //Update Librarian
        private void button4_Click(object sender, EventArgs e)
        {
            if(LibId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                
                    Con.Open();
                    string query = "UPDATE LibrarianTbl SET LibName = '" + LibName.Text + "', LibPassword = '" + Libpass.Text + "', LibPhone = '" + Libphone.Text + "' WHERE LibId = '" + LibId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarian Updated Successfully");
                    Con.Close();
                   population();
                
               
            }   
        }

      
    }
}
