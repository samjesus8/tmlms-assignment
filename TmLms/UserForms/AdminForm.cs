using TmLms.TM;
using TmLms.Users;

namespace TmLms.UserForms
{
    public partial class AdminForm : Form
    {
        static int CourseID = 0; //This will increment by 1 each time a Course is created
        static int ModuleID = 0; //Increment by 1 every time a module is created

        public AdminForm()
        {
            InitializeComponent();
            Program.tmEngine.LoadDummyData();
            LoadExistingCourses();

            creditsBox.Text = 120.ToString();

            //Dummy Data for instructors
            foreach (var course in Program.tmEngine.CourseDictionary) 
            {
                var item = course.Key.ToString() + " - " + course.Value.Name;
                courseSelectorBox.Items.Add(item);
            }
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
                Program.tmEngine.CourseDictionary.Add(CourseID, Course); //Adding course to Dictionary

                CourseID++; //Increments every time a new course is Created

                courseManager.Items.Clear(); //Clears box before displaying new courses

                foreach (var course in Program.tmEngine.CourseDictionary) //Loops through dictionary and adds each course to the CourseManager display
                {
                    var item = course.Key.ToString() + " - " + course.Value.Name;
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
                    var item1 = course.Key.ToString() + " - " + course.Value.Name;
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
                                    "Course Instructor: " + Course.Instructor + "\r\n" +
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
            var CourseName = courseSelectorBox.Text.Split(" - "); // [0] = ID, [1] = Name
            var AdminName = adminBox.Text.Split(" - ");
            var InstructorName = instructorBox1.Text.Split(" - ");
            var Students = studentListBox.CheckedItems;


            var Admin1 = Program.tmEngine.Admins.TryGetValue(int.Parse(AdminName[0]), out var AdminResult1);

            var GetCourse = Program.tmEngine.CourseDictionary.TryGetValue(int.Parse(CourseName[0]), out var CourseObj); //Gets module from dictionary
            Administrator[] GetAdmins = { AdminResult1 };
            Student[] GetStudents = {  };

            var Module = new Module(CourseObj, moduleNameBox.Text, moduleDescriptionBox.Text,
                                    int.Parse(creditsBox1.Text), GetAdmins, GetStudents);


            string OutMsg = "Module Successfully Created \r\n\r\n" +
                            "Course Details \r\n\r\n" +
                            "Course: " + CourseName[1] + "\r\n" +
                            "Module Name: " + moduleNameBox.Text + "\r\n" +
                            "Module Code: " + Module.Code + "\r\n\r\n" +
                            "Assigned Staff \r\n\r\n" +
                            "Admins: " + AdminName[1] + "\r\n" +
                            "Instructors: " + InstructorName[1] + "\r\n\r\n" +
                            "Other Information \r\n\r\n" +
                            "Credits: " + creditsBox1.Text;

            outputBox1.Text = OutMsg;

        }

        private void deleteModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadExistingCourses() 
        {
            foreach (var courses in Program.tmEngine.CourseDictionary) 
            {
                var item = courses.Key.ToString() + " - " + courses.Value.Name;
                courseManager.Items.Add(item);
            }
        }
    }
}
