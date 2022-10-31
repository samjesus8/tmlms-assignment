using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmLms.TM;

namespace TmLms.UserForms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void createCourseButton_Click(object sender, EventArgs e) //Opens the Course Creator
        {
            if (((((courseNameBox.Text == "") || instructorNameBox.Text == "") || courseLevelBox.Text == "") || creditsBox.Text == "") || courseDescriptionBox.Text == "")
            {
                MessageBox.Show("Please fill out the Course requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int ID = 0; //Temporary Variable for storing multiple Courses

                var Course = new Course(courseNameBox.Text, instructorNameBox.Text, int.Parse(courseLevelBox.Text), int.Parse(creditsBox.Text), courseDescriptionBox.Text);
                Program.tmEngine.CourseDictionary.Add(ID, Course);

                ID++; //Increments every time a new course is Created

                foreach (var course in Program.tmEngine.CourseDictionary) 
                {
                    courseManager.Items.Add(course.Value.Name);
                }
            }
        }

        private void deleteCourseButton_Click(object sender, EventArgs e) //Deletes a course
        {

        }
    }
}
