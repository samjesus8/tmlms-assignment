using TmLms.TM;
using TmLms.Users;

namespace TmLms.UserForms
{
    public partial class AdminForm : Form
    {
        static int CourseID = Program.tmEngine.CourseDictionary.Count; //This will increment by 1 each time a Course is created
        static int ModuleID = Program.tmEngine.ModuleDictionary.Count; //Increment by 1 every time a module is created

        public AdminForm()
        {
            InitializeComponent();
        }

        private void createCourseButton_Click(object sender, EventArgs e)
        {
            if ((((courseNameBox.Text == "") || instructorListBox.Text == "") || courseLevelBox.Text == "") || creditsBox.Text == "" || courseDescriptionBox.Text == "") //This checks if any of the boxes are empty
            {
                MessageBox.Show("Please fill out the Course requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int i = 0;
                Instructor[] instructorsToParse = new Instructor[instructorListBox.CheckedItems.Count];
                foreach (object itemChecked in instructorListBox.CheckedItems) 
                {
                    Instructor castedItem = new Instructor();
                    string[] temp = itemChecked.ToString().Split(" - ");
                    castedItem.InstructorName = temp[1];
                    castedItem.ID = int.Parse(temp[0]);
                    instructorsToParse[i] = castedItem;
                    i++;
                }

                var Course = new Course(courseNameBox.Text, instructorsToParse, int.Parse(courseLevelBox.Text), int.Parse(120.ToString()), courseDescriptionBox.Text);
                Program.tmEngine.CourseDictionary.Add(CourseID, Course); //Adding course to Dictionary

                CourseID++; //Increments every time a new course is Created

                courseManager.Items.Clear(); //Clears box before displaying new courses

                foreach (var course in Program.tmEngine.CourseDictionary) //Loops through dictionary and adds each course to the CourseManager display
                {
                    var item = course.Key.ToString() + " - " + course.Value.Name;
                    courseManager.Items.Add(item);
                }

                MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try 
            {
                moduleSelectorCourse.Items.Clear();

                var item = courseManager.SelectedItem.ToString().Split(" ");

                if (Program.tmEngine.CourseDictionary.ContainsKey(int.Parse(item[0])))
                {
                    Program.tmEngine.CourseDictionary.TryGetValue(int.Parse(item[0]), out var Course);
                    string instructorString = string.Join("\r\n", Course.InstructorDir.Select(pair => string.Format("{0} - {1}", pair.Key, pair.Value.InstructorName)));

                    string output = "Course Name: " + Course.Name + "\r\n\r\n" +
                                    "Course Instructors: \r\n" + instructorString + "\r\n\r\n" +
                                    "Course Level: " + Course.Level + "\r\n" +
                                    "Course Credits: " + Course.Credits + "\r\n" +
                                    "Course Description: " + Course.Description;

                    courseDisplayBox.Text = output;

                    //Loading in the modules
                    string[] courseNameToGet = courseManager.SelectedItem.ToString().Split(" - "); // [0] - Course ID, [1] - Course Name
                    var tempSearch = Program.tmEngine.CourseDictionary.TryGetValue(int.Parse(courseNameToGet[0]), out var searchedCourse);

                    foreach (var module in searchedCourse.ModuleDir) 
                    {
                        string tempModule = module.Key + " - " + module.Value.Name;
                        moduleSelectorCourse.Items.Add(tempModule);
                    }
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
            Program.tmEngine.LoadDummyData();
            LoadExistingCourses();

            creditsBox.Text = "120";

            //Dummy Data for instructors
            foreach (var course in Program.tmEngine.CourseDictionary)
            {
                var item = course.Key.ToString() + " - " + course.Value.Name;
                courseSelectorBox.Items.Add(item);
            }
            foreach (var instructor in Program.tmEngine.Instructors)
            {
                var item = instructor.Value.ID + " - " + instructor.Value.InstructorName;
                instructorListBox.Items.Add(item);
                instructorListBox1.Items.Add(item);
            }
            foreach (var admin in Program.tmEngine.Admins)
            {
                var item = admin.Value.ID + " - " + admin.Value.Name;
                adminListBox.Items.Add(item);
            }
            foreach (var student in Program.tmEngine.Students)
            {
                var item = student.Value.ID + " - " + student.Value.StudentName;
                studentListBox.Items.Add(item);
            }
        }

        private void createModuleButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0; 
            int k = 0;

            var CourseName = courseSelectorBox.Text.Split(" - "); // [0] = ID, [1] = Name
            var GetCourse = Program.tmEngine.CourseDictionary.TryGetValue(int.Parse(CourseName[0]), out var CourseObj); //Gets Course from dictionary

            Administrator[] GetAdmins = new Administrator[adminListBox.CheckedItems.Count];
            Instructor[] GetInstructors = new Instructor[instructorListBox1.CheckedItems.Count];
            Student[] GetStudents = new Student[studentListBox.CheckedItems.Count];

            foreach (object itemChecked in adminListBox.CheckedItems)
            {
                Administrator castedItem = new Administrator();
                string[] temp = itemChecked.ToString().Split(" - ");
                castedItem.Name = temp[1];
                castedItem.ID = int.Parse(temp[0]);
                GetAdmins[i] = castedItem;
                i++;
            }

            foreach (object itemChecked in instructorListBox1.CheckedItems)
            {
                Instructor castedItem = new Instructor();
                string[] temp = itemChecked.ToString().Split(" - ");
                castedItem.InstructorName = temp[1];
                castedItem.ID = int.Parse(temp[0]);
                GetInstructors[j] = castedItem;
                j++;
            }

            foreach (object itemChecked in studentListBox.CheckedItems)
            {
                Student castedItem = new Student();
                string[] temp = itemChecked.ToString().Split(" - ");
                castedItem.StudentName = temp[1];
                castedItem.ID = int.Parse(temp[0]);
                GetStudents[k] = castedItem;
                k++;
            }

            var Module = new Module(CourseObj, moduleNameBox.Text, moduleDescriptionBox.Text,
                                    int.Parse(creditsBox1.Text), GetAdmins, GetStudents, GetInstructors);

            Program.tmEngine.ModuleDictionary.Add(ModuleID, Module);
            CourseObj.ModuleDir.Add(Module.Code, Module);
            ModuleID++;

            string adminView = string.Join("\r\n", GetAdmins.Select(pair => string.Format("{0} - {1}", pair.ID, pair.Name)));
            string instructorView = string.Join("\r\n", GetInstructors.Select(pair => string.Format("{0} - {1}", pair.ID, pair.InstructorName)));
            string studentView = string.Join("\r\n", GetStudents.Select(pair => string.Format("{0} - {1}", pair.ID, pair.StudentName)));

            string OutMsg = "Module Successfully Created \r\n\r\n" +
                            "Course Details \r\n\r\n" +
                            "Course: " + CourseName[1] + "\r\n" +
                            "Module Name: " + moduleNameBox.Text + "\r\n" +
                            "Module Code: " + Module.Code + "\r\n\r\n" +
                            "Assigned Staff \r\n\r\n" +
                            "Admins: \r\n" + adminView + "\r\n\r\n" +
                            "Instructors: \r\n" + instructorView + "\r\n\r\n" +
                            "Other Information \r\n\r\n" +
                            "Credits: " + creditsBox1.Text + "\r\n" +
                            "Students Enrolled on this module: \r\n" +
                            studentView;

            outputBox1.Text = OutMsg;

        }

        private void deleteModuleButton_Click(object sender, EventArgs e)
        {
            //Need to implement
        }

        private void LoadExistingCourses() 
        {
            foreach (var courses in Program.tmEngine.CourseDictionary) 
            {
                var item = courses.Key.ToString() + " - " + courses.Value.Name;
                courseManager.Items.Add(item);
            }
        }

        private void moduleSelectorCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] moduleName = moduleSelectorCourse.Text.Split(" - "); //[0] - Module Code, [1] - Module Name
            string moduleDetails = "";

            for (int i = 0; i < Program.tmEngine.CourseDictionary.Count; i++) 
            {
                var moduleList = Program.tmEngine.CourseDictionary[i].ModuleDir;

                foreach (var module in moduleList) 
                {
                    if (module.Key == moduleName[0]) 
                    {
                        var searchedModule = moduleList.TryGetValue(moduleName[0], out var moduleOut);

                        string adminView = string.Join("\r\n", moduleOut.Admins.Select(pair => string.Format("{0} - {1}", pair.Value.ID, pair.Value.Name)));
                        string instructorView = string.Join("\r\n", moduleOut.Instructors.Select(pair => string.Format("{0} - {1}", pair.Value.ID, pair.Value.InstructorName)));
                        string studentView = string.Join("\r\n", moduleOut.Students.Select(pair => string.Format("{0} - {1}", pair.Value.ID, pair.Value.StudentName)));

                        moduleDetails = "Module Name: " + moduleOut.Name + "\r\n" +
                                        "Module Code: " + moduleOut.Code + "\r\n\r\n" +
                                        "Assigned Staff \r\n\r\n" +
                                        "Admins: \r\n" + adminView + "\r\n\r\n" +
                                        "Instructors: \r\n" + instructorView + "\r\n\r\n" +
                                        "Other Information \r\n\r\n" +
                                        "Credits: " + moduleOut.Credits + "\r\n" +
                                        "Students Enrolled on this module: \r\n" +
                                        studentView;
                    }
                }
            }

            moduleOutputBox.Text = moduleDetails;
        }
    }
}
