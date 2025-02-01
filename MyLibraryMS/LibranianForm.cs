using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibraryMS
{
    public partial class LibranianForm : Form
    {
        private SqlConnection Con;

        public LibranianForm()
        {
            InitializeComponent();
            Con = DatabaseHelper.GetConnection();
        }

        public void Population()
        {
            Con.Open();
            string query = "SELECT * FROM LibrarianTbl";
            SqlDataAdapter adapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
            var ds = new DataSet();
            adapt.Fill(ds);
            LibraryGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new MainForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApplication();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Add Librarian
        private void button1_Click(object sender, EventArgs e)
        {
            if (LibId.Text=="" || LibName.Text=="" || Libpass.Text=="")
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                Con.Open();

                string query = "INSERT INTO LibrarianTbl (LibId, LibName, LibPassword, LibPhone) VALUES (@LibId, @LibName, @LibPass, @LibPhone)";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@LibId", LibId.Text);
                cmd.Parameters.AddWithValue("@LibName", LibName.Text);
                cmd.Parameters.AddWithValue("@LibPass", Libpass.Text);
                cmd.Parameters.AddWithValue("@LibPhone", Libphone.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Librarian Added Successfully");

                Population(); // Refresh dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Handle exceptions (logging, etc.)
            }
            finally
            {
                Con.Close();
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
            Population();
        }

        // Delete Librarian
        private void button3_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "")
            {
                MessageBox.Show("Enter The Librarian Information needed to update");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM LibrarianTbl WHERE LibId = @LibId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@LibId", LibId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarian Deleted Successfully");
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        // Update Librarian
        private void button4_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE LibrarianTbl SET LibName = @LibName, LibPass = @LibPass, LibPhone = @LibPhone WHERE LibId = @LibId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@LibId", LibId.Text);
                    cmd.Parameters.AddWithValue("@LibName", LibName.Text);
                    cmd.Parameters.AddWithValue("@LibPass", Libpass.Text);
                    cmd.Parameters.AddWithValue("@LibPhone", Libphone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarian Updated Successfully");
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }
    }
}
