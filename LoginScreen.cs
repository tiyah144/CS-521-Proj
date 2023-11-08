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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        // Define user roles
        public enum UserRole
        {
            Admin,
            Student
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            // Hard-coded user credentials
            if (username == "teacher" && password == "teacher123") // Admin credentials
            {
                // Open the Instructor View (Dashboard screen)
                OpenInstructorView();
            }
            else if (username == "student" && password == "student123") // Student credentials
            {
                // Open the Student View (dahsboard screen)
                OpenStudentView();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }



        }

        private void OpenInstructorView()
        {
            DashboardInstructor instructorView = new DashboardInstructor();
            instructorView.Show();
            this.Hide();
        }

        private void OpenStudentView()
        {
            DashboardStudent studentView = new DashboardStudent();
            studentView.Show();
            this.Hide();
        }

        //open Create Account Screen
        private void createLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountScreen createaccountView = new CreateAccountScreen();
            createaccountView.Show();
            this.Hide();
        }
    }

}
