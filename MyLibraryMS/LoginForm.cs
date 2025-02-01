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
using Bunifu.Framework.UI;

namespace MyLibraryMS
{
    public partial class LoginForm : Form
    {
        private SqlConnection Con;
        public LoginForm()
        {
            InitializeComponent();
            Con = DatabaseHelper.GetConnection();

        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
       
            if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter UserName and Password");
                return;
            }

            
            {
                
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LibrarianTbl where LibName=@UserName and LibPassword=@Password", Con);
                    sda.SelectCommand.Parameters.AddWithValue("@UserName", UserName.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@Password", Password.Text);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                    Con.Close();
                    FormHelper.ShowForm(this, new Firstpage());
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    Con.Close();
                    }
                
               
            }
        }
        public string Username
        {
            get { return UserName.Text; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }

        public void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
          FormHelper.ShowForm(this,new SignupForm());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
