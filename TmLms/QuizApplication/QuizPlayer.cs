using TmLms.QuizAnswerManager;

namespace TmLms.QuizApplication
{
    public partial class QuizPlayer : Form
    {
        private QuizManager manager = new QuizManager();
        public UserControl UserControl = new UserControl();
        public int QuestionId = 1;

        public QuizPlayer()
        {
            InitializeComponent();
        }

        private void loadQuestionButton_Click(object sender, EventArgs e)
        {
            var questionSet = manager.LoadQuestions();
            questionSet.Item1.TryGetValue(QuestionId, out var question);

            panel1.Controls.Clear();
            UserControl = new TrueOrFalsePlay.ToFPlay();
            panel1.Controls.Add(UserControl);

            TrueOrFalsePlay.ToFPlay ToF = (TrueOrFalsePlay.ToFPlay)UserControl;
            ToF.inputBox.Text = question.QuestionName;
        }
    }
}
