using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmLms.UserForms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            instructorNameBox.Visible = false; //Sets the creator boxes to not be visible until user presses button
            courseNameBox.Visible = false;
            courseLengthBox.Visible = false;
            courseDescriptionBox.Visible = false;

            instructorLabel.Visible = false;
            courseNameLabel.Visible = false;
            courseLengthLabel.Visible = false;
            courseDescriptionLabel.Visible = false;
        }

        private void createCourseButton_Click(object sender, EventArgs e) //Opens the Course Creator
        {
            instructorNameBox.Visible = true; //Reveals the creator boxes to create a course
            courseNameBox.Visible = true;
            courseLengthBox.Visible = true;
            courseDescriptionBox.Visible = true;

            instructorLabel.Visible = true;
            courseNameLabel.Visible = true;
            courseLengthLabel.Visible = true;
            courseDescriptionLabel.Visible = true;
        }

        private void deleteCourseButton_Click(object sender, EventArgs e) //Deletes a course
        {

        }

        private void courseAcceptButton_Click(object sender, EventArgs e) //Checks if all boxes are filled and creates the course
        {

        }
    }
}
