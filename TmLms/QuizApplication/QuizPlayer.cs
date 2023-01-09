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
            QuestionId = 1; //Reset back to 1 on click
            QuestionType = "TOF";
            ToFLoad(QuestionId);
            nextButton.Enabled = true;
            previousButton.Enabled = true;
        }

        private void loadSQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionId = 1; //Reset back to 1 on click
            QuestionType = "S";
            SLoad(QuestionId);
            nextButton.Enabled = true;
            previousButton.Enabled = true;
        }

        private void loadMCQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionId = 1; //Reset back to 1 on click
            QuestionType = "MC";
            MCLoad(QuestionId);
            nextButton.Enabled = true;
            previousButton.Enabled = true;
        }

        private void loadMAQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionId = 1; //Reset back to 1 on click
            QuestionType = "MA";
            MALoad(QuestionId);
            nextButton.Enabled = true;
            previousButton.Enabled = true;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (QuestionType == "TOF") 
            {
                QuestionId--; //Decrements question ID
                ToFLoad(QuestionId); //Gets the previous question
            }
            else if (QuestionType == "S") 
            {
                QuestionId--;
                SLoad(QuestionId);
            }
            else if (QuestionType == "MC")
            {
                QuestionId--;
                MCLoad(QuestionId);
            }
            else if (QuestionType == "MA")
            {
                QuestionId++;
                MALoad(QuestionId);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (QuestionType == "TOF") 
            {
                QuestionId++; //Increments question ID
                ToFLoad(QuestionId); //Gets the next question and displays it
            }
            else if (QuestionType == "S")
            {
                QuestionId++;
                SLoad(QuestionId);
            }
            else if (QuestionType == "MC")
            {
                QuestionId++;
                MCLoad(QuestionId);
            }
            else if (QuestionType == "MA")
            {
                QuestionId++;
                MALoad(QuestionId);
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
            catch (NullReferenceException ex)
            {
                MessageBox.Show("You have reached the maximum number of questions in this set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SLoad(int questionNo) 
        {
            try
            {
                var questionSet = manager.LoadQuestions("S");
                questionSet.Item1.TryGetValue(questionNo, out var question);

                panel1.Controls.Clear();
                UserControl = new ShortAnswerPlay.ShortAnswerPlay();
                panel1.Controls.Add(UserControl);

                ShortAnswerPlay.ShortAnswerPlay S = (ShortAnswerPlay.ShortAnswerPlay)UserControl;
                S.inputBox.Text = question.QuestionName;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("You have reached the maximum number of questions in this set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MCLoad(int questionNo) 
        {
            try
            {
                var questionSet = manager.LoadQuestions("MC");
                questionSet.Item1.TryGetValue(questionNo, out var question);

                panel1.Controls.Clear();
                UserControl = new MultiChoicePlay.MulitChoicePlay();
                panel1.Controls.Add(UserControl);

                MultiChoicePlay.MulitChoicePlay MC = (MultiChoicePlay.MulitChoicePlay)UserControl;
                MC.inputBox.Text = question.QuestionName;
                MC.option1Button.Text = question.QuestionAnswerMC1;
                MC.option2Button.Text = question.QuestionAnswerMC2;
                MC.option3Button.Text = question.QuestionAnswerMC3;
                MC.option4Button.Text = question.QuestionAnswerMC4;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("You have reached the maximum number of questions in this set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MALoad(int questionNo) 
        {
            try
            {
                var questionSet = manager.LoadQuestions("MA");
                questionSet.Item1.TryGetValue(questionNo, out var question);

                panel1.Controls.Clear();
                UserControl = new MultiAnswerPlay.MultiAnswerPlay();
                panel1.Controls.Add(UserControl);

                MultiAnswerPlay.MultiAnswerPlay MA = (MultiAnswerPlay.MultiAnswerPlay)UserControl;
                MA.inputBox.Text = question.QuestionName;
                MA.checkBox1.Text = question.QuestionAnswerMC1;
                MA.checkBox2.Text = question.QuestionAnswerMC2;
                MA.checkBox3.Text = question.QuestionAnswerMC3;
                MA.checkBox4.Text = question.QuestionAnswerMC4;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("You have reached the maximum number of questions in this set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
