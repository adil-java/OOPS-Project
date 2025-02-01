using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibraryMS
{
    public partial class ReturnBook : Form
    {
        SqlConnection Con;

        public ReturnBook()
        {
            InitializeComponent();
            Con = DatabaseHelper.GetConnection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new MainForm());
        }

        public void population1()
        {
            Con.Open();
            string query = "SELECT * FROM IssueTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IssueGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        public void population2()
        {
            Con.Open();
            string query = "SELECT * FROM ReturnTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReturnGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }

        private void IssueGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IssueGridView.SelectedRows.Count > 0)
            {
                BookName.Text = IssueGridView.SelectedRows[0].Cells[2].Value.ToString();
                StudentName.Text = IssueGridView.SelectedRows[0].Cells[5].Value.ToString();
                ReturnDate.Text = IssueGridView.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            population1();
            population2();
        }

        private void ReturnGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ReturnGridView.SelectedRows.Count > 0)
            {
                BookName.Text = ReturnGridView.SelectedRows[0].Cells[2].Value.ToString();
                StudentName.Text = ReturnGridView.SelectedRows[0].Cells[5].Value.ToString();
                ReturnDate.Text = ReturnGridView.SelectedRows[0].Cells[6].Value.ToString();
                ReturnDate.Text = ReturnGridView.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BookName.Text == "" || StudentName.Text == "" || ReturnDate.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                using (SqlConnection Con = DatabaseHelper.GetConnection())
                {
                    Con.Open();
                    string query = "INSERT INTO ReturnTbl (StdName, Bookreturn, IssueDate, ReturnDate) VALUES (@StudentName, @BookName, @IssueDate, @ReturnDate)";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@BookName", BookName.Text);
                        cmd.Parameters.AddWithValue("@StudentName", StudentName.Text);

                        DateTime issueDate;
                        DateTime returnDate;
                        if (DateTime.TryParse(IssueDate.Text, out issueDate) && DateTime.TryParse(ReturnDate.Text, out returnDate))
                        {
                            cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                            cmd.Parameters.AddWithValue("@ReturnDate", returnDate);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Book Returned Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please enter dates in a valid format.");
                        }
                    }
                    Con.Close();
                    population2(); // Refresh data after successful insertion
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookName.Text == "")
                {
                    MessageBox.Show("Missing Information");
                    return; // Exit method early if BookName is empty
                }

                using (SqlConnection Con = DatabaseHelper.GetConnection())
                {
                    Con.Open();
                    string query = "DELETE FROM IssueTbl WHERE BookIssue = @BookName";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@BookName", BookName.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book Returned Successfully");
                            population1(); // Refresh data after successful deletion
                        }
                        else
                        {
                            MessageBox.Show("No records found for the specified BookName.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private decimal GetBookPriceFromDatabase(string bookName)
        {
            decimal price = 0.0m;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();
                    string query = "SELECT Price FROM bookTbl WHERE BookName = @BookName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BookName", bookName);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            price = Convert.ToDecimal(result);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving price for book '{bookName}': {ex.Message}");
            }

            return price;
        }

        private decimal ComputeTotalAmount()
        {
            decimal totalAmount = 0.0m;

            foreach (DataGridViewRow row in IssueGridView.Rows)
            {
                if (row.Selected)
                {
                    string bookName = row.Cells[2].Value.ToString();
                    decimal bookPrice = GetBookPriceFromDatabase(bookName);
                    totalAmount += bookPrice;
                }
            }

            return totalAmount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = StudentName.Text;
            string issueDate = IssueDate.Text;
            decimal totalAmount = ComputeTotalAmount();

            string billingContent = $"Student Name: {studentName}\nIssue Date: {issueDate}\nTotal Amount: {totalAmount:C}";

            MessageBox.Show("Billing Information:\n\n" + billingContent, "Billing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print logic if needed
        }
    }
}
