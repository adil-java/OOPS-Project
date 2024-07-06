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
using System.Xml.Linq;

namespace MyLibraryMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
       
            if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter UserName and Password");
                return;
            }

            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\oops project\MyLibraryMS\MyLibraryMS\Mylibrarydb.mdf"";Integrated Security=True"))
            {
                try
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LibrarianTbl where LibName=@UserName and LibPassword=@Password", Con);
                    sda.SelectCommand.Parameters.AddWithValue("@UserName", UserName.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@Password", Password.Text);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        MainForm main = new MainForm();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }
    }
}
