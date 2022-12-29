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

        }

        private void moduleSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
