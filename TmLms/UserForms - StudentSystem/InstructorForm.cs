using System.Data;
using TmLms.TM;
using TmLms.Users;

namespace TmLms.UserForms
{
    public partial class InstructorForm : Form
    {
        static int ModuleID = Program.tmEngine.ModuleDictionary.Count; //Increment by 1 every time a module is created

        public InstructorForm()
        {
            InitializeComponent();
        }

        private void createModuleButton_Click_1(object sender, EventArgs e)
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

            Module Module = new Module(CourseObj, moduleNameBox.Text, moduleDescriptionBox.Text,
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

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            //Dummy Data for instructors
            foreach (var course in Program.tmEngine.CourseDictionary)
            {
                var item = course.Key.ToString() + " - " + course.Value.Name;
                courseSelectorBox.Items.Add(item);
            }
            foreach (var instructor in Program.tmEngine.Instructors)
            {
                var item = instructor.Value.ID + " - " + instructor.Value.InstructorName;
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
    }
}
