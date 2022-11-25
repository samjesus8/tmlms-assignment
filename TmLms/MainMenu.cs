using TmLms.QuizApplication;

namespace TmLms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void smsButton_Click(object sender, EventArgs e)
        {
            var Form = new StudentSystemMenu();
            Form.Show();
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            var Form = new QuizBuilderMenu();
            Form.Show();
        }
    }
}
