using TmLms.QuizAnswerManager;

namespace TmLms.QuizApplication
{
    public partial class QuizPlayer : Form
    {
        private QuizManager manager = new QuizManager();
        public UserControl UserControl = new UserControl();
        public string QuestionType = "";
        public int QuestionId = 1;

        public QuizPlayer()
        {
            InitializeComponent();
        }

        private void loadQuestionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
