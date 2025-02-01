using System;
using System.Windows.Forms;

namespace MyLibraryMS
{
    public static class FormHelper
    {
        public static void MinimizeForm(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public static void ExitApplication()
        {
            Application.Exit();
        }

        public static void LogOut(Form currentForm)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentForm.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        public static void ShowForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.Show();
        }
    }
}
