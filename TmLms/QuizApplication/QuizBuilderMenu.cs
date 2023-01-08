namespace TmLms.QuizApplication
{
    public partial class QuizBuilderMenu : Form
    {
        public QuizBuilderMenu()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var CreatorForm = new QuizCreator();
            CreatorForm.Show();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            var QuizPlayer = new QuizPlayer();
            QuizPlayer.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
