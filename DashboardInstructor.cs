using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DashboardInstructor : Form
    {
        public DashboardInstructor()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            // Close the Instructor View
            this.Close();

            // Show the Login Form (Assuming your login form is named LoginForm)
            LoginScreen loginForm = new LoginScreen();
            loginForm.Show();
        }
    }
}
