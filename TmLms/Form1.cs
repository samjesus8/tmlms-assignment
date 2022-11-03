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
            else if (comboBoxUserType.SelectedIndex == 1) //Instructor (Teacher) Open
            {             
                InstructorForm instructorForm = new InstructorForm();
                instructorForm.Show();
            }
            else if (comboBoxUserType.SelectedIndex == 2) //Student Open
            {               
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
            }
            else if (comboBoxUserType.SelectedIndex == -1)  //If Nothing is selected
            {
                MessageBox.Show("Please Select A User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Environment.Exit(0);
        }
    }
}