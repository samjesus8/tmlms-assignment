using TmLms.QuizAnswerManager;

namespace TmLms.QuizApplication
{
    public partial class QuizPlayer : Form
    {
        public UserControl UserControl = new UserControl();
        private QuizManager manager = new QuizManager();
        private int QuestionId = 1;
        private string QuestionType = string.Empty;

        public QuizPlayer()
        {
            InitializeComponent();
            nextButton.Enabled = false;
            previousButton.Enabled = false;
        }

        private void loadQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionType = "TOF";
            ToFLoad(QuestionId);
            nextButton.Enabled = true;
            previousButton.Enabled = true;
        }

        private void loadSQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void loadMCQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void loadMAQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (QuestionType == "TOF") 
            {
                QuestionId--; //Decrements question ID
                ToFLoad(QuestionId); //Gets the previous question
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (QuestionType == "TOF") 
            {
                QuestionId++; //Increments question ID
                ToFLoad(QuestionId); //Gets the next question and displays it
            }
        }

        private void ToFLoad(int questionNo) 
        {
            try 
            {
                var questionSet = manager.LoadQuestions("TOF");
                questionSet.Item1.TryGetValue(questionNo, out var question);

                panel1.Controls.Clear();
                UserControl = new TrueOrFalsePlay.ToFPlay();
                panel1.Controls.Add(UserControl);

                TrueOrFalsePlay.ToFPlay ToF = (TrueOrFalsePlay.ToFPlay)UserControl;
                ToF.inputBox.Text = question.QuestionName;
            }
            catch(NullReferenceException ex) 
            {
                MessageBox.Show("You have reached the maximum number of questions in this set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
