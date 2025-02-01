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

    public partial class SignupForm : Form
    {
        private SqlConnection Con;
        public SignupForm()
        {
            InitializeComponent();
            Con = DatabaseHelper.GetConnection();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if(UserName.Text == "" || Password.Text == "" || PhoneNo.Text == "")
            {
                MessageBox.Show("Enter all the fields");
                return;
            }
            else
            {
               
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO LibrarianTbl values('" + UserName.Text + "','" + Password.Text + "','" + PhoneNo.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con.Close();
                    FormHelper.ShowForm(this, new LoginForm());
                    UserName.Text = "";
                    Password.Text = "";
                    PhoneNo.Text = "";
             
                 
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new LoginForm());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApplication();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }
    }
}
