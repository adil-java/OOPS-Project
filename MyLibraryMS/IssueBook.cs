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
    public partial class IssueBook : Form
    {
        SqlConnection Con;
        public IssueBook()
        {
            InitializeComponent();
            Con=DatabaseHelper.GetConnection();
        }

        public void population()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            string query = "SELECT * FROM IssueTbl";
            SqlDataAdapter adapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
            var ds = new DataSet();
            adapt.Fill(ds);
            IssueGridView.DataSource = ds.Tables[0];

            // Close the connection after data retrieval
            Con.Close();
        }


        private void FillStudentCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT StdName FROM StudentTbl", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr); // Load data directly from SqlDataReader to DataTable

            StudComb.DisplayMember = "StdName"; // Display StdName in the ComboBox
            StudComb.DataSource = dt;
            Con.Close();
        }

        private void FillBooksCombo()
        {
           
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT BookName FROM BookTbl", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(dr);
            BookCombo.ValueMember = "BookName";
            BookCombo.DataSource = dt;
            Con.Close();
        }
        public void updateBookQuantity()
        {
            if (BookCombo.SelectedItem != null)
            {
                int Qty, newQty;
                Con.Open();
                string bookName = BookCombo.SelectedItem.ToString(); // Get the selected book name directly
                string query = "SELECT Qty FROM BookTbl WHERE BookName=@BookName";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@BookName", bookName);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Qty = Convert.ToInt32(dt.Rows[0]["Qty"]);
                    newQty = Qty - 1;

                    // Update the database with the new quantity
                    string query1 = "UPDATE BookTbl SET Qty=@NewQty WHERE BookName=@BookName";
                    SqlCommand cmd1 = new SqlCommand(query1, Con);
                    cmd1.Parameters.AddWithValue("@NewQty", newQty);
                    cmd1.Parameters.AddWithValue("@BookName", bookName);
                    cmd1.ExecuteNonQuery();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Book not found in the database.");
                }

                Con.Close();
            }
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new MainForm());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApplication();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            updateBookQuantity();
            population();
            FillStudentCombo();
            FillBooksCombo();
        }

        private void StudComb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            if (StudComb.SelectedItem == null || BookCombo.SelectedItem == null || string.IsNullOrEmpty(IssueDate.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }
                Con.Open();

                string query = "INSERT INTO IssueTbl (StdName, BookIssue, IssueDate) VALUES (@StdName, @BookIssue, @IssueDate)";

                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@StdName", StudComb.Text);
                command.Parameters.AddWithValue("@BookIssue", BookCombo.Text);
                command.Parameters.AddWithValue("@IssueDate", IssueDate.Value.Date); // Assuming IssueDate is a DateTimePicker

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book Issued Successfully");
                    population(); // Refresh the DataGridView after issuing the book
                    updateBookQuantity();
                Con.Close();
                }
                else
                {
                    MessageBox.Show("Failed to issue book");
                Con.Close();
                }
            
        }

        private void IssueGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.IssueGridView.Rows[e.RowIndex];
                StudComb.Text = row.Cells[0].Value.ToString();
                BookCombo.Text = row.Cells[1].Value.ToString();
                IssueDate.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
