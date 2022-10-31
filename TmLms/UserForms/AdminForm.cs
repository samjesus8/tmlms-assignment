using TmLms.TM;
using TmLms.Users;

namespace TmLms.UserForms
{
    public partial class AdminForm : Form
    {
        static int ID = 0;
        public AdminForm()
        {
            InitializeComponent();

            //Dummy Data for instructors
            var Instructor1 = new Instructor("Mr Anderson");
            var Instructor2 = new Instructor("Mr Malkovich");
            var Instructor3 = new Instructor("Mr Folabi");

            var Item1 = Instructor1.ID + " - " + Instructor1.InstructorName;
            var Item2 = Instructor2.ID + " - " + Instructor2.InstructorName;
            var Item3 = Instructor3.ID + " - " + Instructor3.InstructorName;

            instructorBox.Items.Add(Item1);
            instructorBox.Items.Add(Item2);
            instructorBox.Items.Add(Item3);
        }

        private void createCourseButton_Click(object sender, EventArgs e) //Opens the Course Creator
        {
            if (((((courseNameBox.Text == "") || instructorBox.Text == "") || courseLevelBox.Text == "") || creditsBox.Text == "") || courseDescriptionBox.Text == "") //This checks if any of the boxes are empty
            {
                MessageBox.Show("Please fill out the Course requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                var Course = new Course(courseNameBox.Text, instructorBox.Text, int.Parse(courseLevelBox.Text), int.Parse(creditsBox.Text), courseDescriptionBox.Text);
                Program.tmEngine.CourseDictionary.Add(ID, Course); //Adding course to Dictionary

                ID++; //Increments every time a new course is Created

                courseManager.Items.Clear(); //Clears box before displaying new courses

                foreach (var course in Program.tmEngine.CourseDictionary) //Loops through dictionary and adds each course to the CourseManager display
                {
                    var item = course.Key.ToString() + " " + course.Value.Name;
                    courseManager.Items.Add(item);
                }
            }
        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            var item = courseManager.SelectedItem.ToString().Split(" ");
            if (Program.tmEngine.CourseDictionary.ContainsKey(int.Parse(item[0])))
            {
                Program.tmEngine.CourseDictionary.Remove(int.Parse(item[0]));

                courseManager.Items.Clear(); //Clears box before displaying new courses

                foreach (var course in Program.tmEngine.CourseDictionary) //Loops through dictionary and adds each course to the CourseManager display
                {
                    var item1 = course.Key.ToString() + " " + course.Value.Name;
                    courseManager.Items.Add(item1);
                }
            }
        }

        private void createModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            var item = courseManager.SelectedItem.ToString().Split(" ");

            if (Program.tmEngine.CourseDictionary.ContainsKey(int.Parse(item[0])))
            {
                Program.tmEngine.CourseDictionary.TryGetValue(int.Parse(item[0]), out var Course);
                string output = "Course Name: " + Course.Name + "\r\n" +
                                "Course Instructor: " + Course.Administrator + "\r\n" +
                                "Course Level: " + Course.Level + "\r\n" +
                                "Course Credits: " + Course.Credits + "\r\n" +
                                "Course Description: " + Course.Description;

                courseDisplayBox.Text = output;
            }
        }
    }
}
