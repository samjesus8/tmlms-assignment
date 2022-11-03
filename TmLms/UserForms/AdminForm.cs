using TmLms.TM;
using TmLms.Users;

namespace TmLms.UserForms
{
    public partial class AdminForm : Form
    {
        static int ID = 0; //This will increment by 1 each time a Course is created
        public AdminForm()
        {
            InitializeComponent();

            creditsBox.Text = 120.ToString();

            //Dummy Data for instructors
            Program.tmEngine.LoadDummyData();

            foreach (var instructor in Program.tmEngine.Instructors) 
            {
                var item = instructor.Value.ID + " - " + instructor.Value.InstructorName;
                instructorBox.Items.Add(item);
                instructorBox1.Items.Add(item);
            }
            foreach (var admin in Program.tmEngine.Admins) 
            {
                var item = admin.Value.ID + " - " + admin.Value.Name;
                adminBox.Items.Add(item);
            }
            foreach (var student in Program.tmEngine.Students) 
            {
                var item = student.Value.Id + " - " + student.Value.StudentName;
                studentListBox.Items.Add(item);
            }
        }

        private void createCourseButton_Click(object sender, EventArgs e) //Opens the Course Creator
        {
            if (((((courseNameBox.Text == "") || instructorBox.Text == "") || courseLevelBox.Text == "") || creditsBox.Text == "") || courseDescriptionBox.Text == "") //This checks if any of the boxes are empty
            {
                MessageBox.Show("Please fill out the Course requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                var Course = new Course(courseNameBox.Text, instructorBox.Text, int.Parse(courseLevelBox.Text), int.Parse(120.ToString()), courseDescriptionBox.Text);
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

        private void viewButton_Click(object sender, EventArgs e)
        {
            try 
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
            catch (Exception ex) 
            {
                string ErrorMsg = ex.ToString() + "\r\n The course list is empty";
                MessageBox.Show(ErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void createModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteModuleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
