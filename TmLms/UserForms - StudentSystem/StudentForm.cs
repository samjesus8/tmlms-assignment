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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString();
            dateTimeBox.Text= dateTime;

            foreach (var course in Program.tmEngine.CourseDictionary)
            {
                var item = course.Key.ToString() + " - " + course.Value.Name;
                courseSelectorBox.Items.Add(item);
            }
        }

        private void courseSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moduleSelectorBox.Items.Clear();
            try 
            {
                var item = courseSelectorBox.SelectedItem.ToString().Split(" ");

                if (Program.tmEngine.CourseDictionary.ContainsKey(int.Parse(item[0])))
                {
                    Program.tmEngine.CourseDictionary.TryGetValue(int.Parse(item[0]), out var Course);
                    string instructorString = string.Join("\r\n", Course.InstructorDir.Select(pair => string.Format("{0} - {1}", pair.Key, pair.Value.InstructorName)));

                    string output = "Course Name: " + Course.Name + "\r\n\r\n" +
                                    "Course Instructors: \r\n" + instructorString + "\r\n\r\n" +
                                    "Course Level: " + Course.Level + "\r\n" +
                                    "Course Credits: " + Course.Credits + "\r\n" +
                                    "Course Description: " + Course.Description;

                    courseViewBox.Text = output;

                    //Loading in the modules
                    string[] courseNameToGet = courseSelectorBox.SelectedItem.ToString().Split(" - "); // [0] - Course ID, [1] - Course Name
                    var tempSearch = Program.tmEngine.CourseDictionary.TryGetValue(int.Parse(courseNameToGet[0]), out var searchedCourse);

                    foreach (var module in searchedCourse.ModuleDir)
                    {
                        string tempModule = module.Key + " - " + module.Value.Name;
                        moduleSelectorBox.Items.Add(tempModule);
                    }
                }
            }
            catch(Exception ex) 
            {
                string ErrorMsg = ex.ToString() + "\r\n The course list is empty";
                MessageBox.Show(ErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moduleSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] moduleName = moduleSelectorBox.Text.Split(" - "); //[0] - Module Code, [1] - Module Name
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

            moduleViewBox.Text = moduleDetails;
        }
    }
}
