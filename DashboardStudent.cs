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

    /*public class Course
    {
        public string Section { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public string CourseNumber { get; set; }
    }*/

    //private List<Course> enrolledCourses;

    public partial class DashboardStudent : Form
    {

        public class Course
        {
            public string Section { get; set; }
            public string Semester { get; set; }
            public string Year { get; set; }
            public string CourseNumber { get; set; }
        }

        private List<Course> enrolledCourses;

        public DashboardStudent()
        {
            InitializeComponent();
            comboBoxNavigation.Items.Add("Course Materials");
            comboBoxNavigation.Items.Add("Grades");



            // Initialize the list of hard-coded courses
            enrolledCourses = new List<Course>
            {
                new Course { Section = "A01", Semester = "Fall", Year = "2023", CourseNumber = "CS101" },
                new Course { Section = "B02", Semester = "Spring", Year = "2023", CourseNumber = "MATH201" },
                // Add more hard-coded courses as needed
            };

            // Populate the DataGridView with the hard-coded courses
            //dataGridView1.DataSource = enrolledCourses;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DashboardStudent_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            // Close the Instructor View
            this.Close();

            // Show the Login Form (Assuming your login form is named LoginForm)
            LoginScreen loginForm = new LoginScreen();
            loginForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the Instructor View
            this.Close();

            //shows english course
            ENGcourseStudent englishclass = new ENGcourseStudent();
            englishclass.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the Instructor View
            this.Close();

            //shows english course
            CScourseStudent csclass = new CScourseStudent();
            csclass.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the Instructor View
            this.Close();

            //shows english course
            MTHcourseStudent mthclass = new MTHcourseStudent();
            mthclass.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Close the Instructor View
            this.Close();

            //shows english course
            ENGcourseStudent englishclass = new ENGcourseStudent();
            englishclass.Show();
        }
    }
}
