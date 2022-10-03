using TmLms.UserForms;

namespace TmLms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (comboBoxUserType.SelectedIndex == 0) //Admin Open
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            if (comboBoxUserType.SelectedIndex == 1) //Instructor (Teacher) Open
            {             
                InstructorForm instructorForm = new InstructorForm();
                instructorForm.Show();
            }
            if (comboBoxUserType.SelectedIndex == 2) //Student Open
            {               
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}