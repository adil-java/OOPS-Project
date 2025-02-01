using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibraryMS
{
    public partial class StudentForm : Form
    {
        SqlConnection Con;

        public StudentForm()
        {
            InitializeComponent();
            Con = DatabaseHelper.GetConnection();
        }

        public void Population()
        {
            
                Con.Open();
                string query = "SELECT * FROM StudentTbl";
                SqlDataAdapter adapt = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
                var ds = new DataSet();
                adapt.Fill(ds);
                StudentGridView.DataSource = ds.Tables[0];
            Con.Close();
            }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApplication();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new MainForm());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            Population();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO StudentTbl (StdId, StdName, StdDept, StdPhone, Sem) VALUES (@StdId, @StudName, @StudDept, @StudPhone, @StudSem)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@StdId", StudId.Text);  
                    cmd.Parameters.AddWithValue("@StudName", StudName.Text);
                    cmd.Parameters.AddWithValue("@StudDept", StudDept.Text);
                    cmd.Parameters.AddWithValue("@StudPhone", StudPhone.Text);
                    cmd.Parameters.AddWithValue("@StudSem", StudSem.Text);

                    
                    cmd.ExecuteNonQuery();
                }
                con.Close();

                MessageBox.Show("Student Successfully Added");
                Population();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE StudentTbl SET StdName = @StudName, StdDept = @StudDept, StdPhone = @StudPhone, Sem = @StudSem WHERE StdId = @StudId", connection);
                cmd.Parameters.AddWithValue("@StudId", StudId.Text);
                cmd.Parameters.AddWithValue("@StudName", StudName.Text);
                cmd.Parameters.AddWithValue("@StudDept", StudDept.Text);
                cmd.Parameters.AddWithValue("@StudSem", StudSem.Text);
                cmd.Parameters.AddWithValue("@StudPhone", StudPhone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Updated");
                Population();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentTbl WHERE StdId = @StudId", connection);
                cmd.Parameters.AddWithValue("@StudId", StudId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Deleted");
                Population();
            }
        }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
