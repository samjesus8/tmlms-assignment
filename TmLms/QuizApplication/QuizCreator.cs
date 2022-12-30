using TmLms.QuizAnswerManager;

namespace TmLms.QuizApplication
{
    public partial class QuizCreator : Form
    {
        public UserControl UserControl = new UserControl();
        public string QuestionType = "";
        public QuizCreator()
        {
            InitializeComponent();
            NextButton.Enabled = false;
        }

        private void ToFButton_Click(object sender, EventArgs e)
        {
            QuestionType = "TOF";
            panel1.Controls.Clear();
            UserControl = new TrueOrFalse.TrueOrFalseControl();
            panel1.Controls.Add(UserControl);
        }

        private void MultiAnswerButton_Click(object sender, EventArgs e)
        {
            QuestionType = "MA";
            panel1.Controls.Clear();
            UserControl = new MultiAnswerControl.MultiAnswer();
            panel1.Controls.Add(UserControl);
        }

        private void ShortAnswerButton_Click(object sender, EventArgs e)
        {
            QuestionType = "S";
            panel1.Controls.Clear();
            UserControl = new ShortAnswerControl.ShortAnswer();
            panel1.Controls.Add(UserControl);
        }

        private void MultiChoiceButton_Click(object sender, EventArgs e)
        {
            QuestionType = "MC";
            panel1.Controls.Clear();
            UserControl = new MultiChoiceControl.MultiChoice();
            panel1.Controls.Add(UserControl);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var quizManager = new QuizManager();

            if (QuestionType == "TOF") //True or False Saving
            {
                TrueOrFalse.TrueOrFalseControl TOF = (TrueOrFalse.TrueOrFalseControl)UserControl;

                quizManager.QuestionName = TOF.inputBox.Text;

                TOF.CheckAnswer();

                quizManager.isTrue = TOF.isTrue;
                quizManager.isFalse = TOF.isFalse;

                bool errorCheck = quizManager.StoreQuestion(quizManager);
                if (errorCheck == true) 
                {
                    MessageBox.Show("Successfully Stored Question!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    string error = "Something went wrong storing this question \r\n" +
                                   "Error message: " + quizManager.Error;
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (QuestionType == "MA") //Multi-Answer Saving
            {
                bool option1 = false;
                bool option2 = false;
                bool option3 = false;
                bool option4 = false;

                MultiAnswerControl.MultiAnswer MA = (MultiAnswerControl.MultiAnswer)UserControl;

                quizManager.QuestionName = MA.inputBox.Text;
                quizManager.QuestionAnswerMC1 = MA.option1Box.Text;
                quizManager.QuestionAnswerMC2 = MA.option2Box.Text;
                quizManager.QuestionAnswerMC3 = MA.option3Box.Text;
                quizManager.QuestionAnswerMC4 = MA.option4Box.Text;

                if (MA.checkBox1.Checked == true)
                {
                    option1 = true;
                }
                if (MA.checkBox2.Checked == true)
                {
                    option2 = true;
                }
                if (MA.checkBox3.Checked == true)
                {
                    option3 = true;
                }
                if (MA.checkBox4.Checked == true)
                {
                    option4 = true;
                }

                bool[] correctAnswers = { option1, option2, option3, option4 };
                quizManager.MultiAnswers = correctAnswers;

                bool errorCheck = quizManager.StoreQuestion(quizManager);
                if (errorCheck == true)
                {
                    MessageBox.Show("Successfully Stored Question!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string error = "Something went wrong storing this question \r\n" +
                                   "Error message: " + quizManager.Error;
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (QuestionType == "S") 
            {
                ShortAnswerControl.ShortAnswer S = (ShortAnswerControl.ShortAnswer)UserControl;

                quizManager.QuestionName = S.inputBox.Text;
                quizManager.QuestionAnswerS = S.answerBox.Text;

                bool errorCheck = quizManager.StoreQuestion(quizManager);
                if (errorCheck == true)
                {
                    MessageBox.Show("Successfully Stored Question!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string error = "Something went wrong storing this question \r\n" +
                                   "Error message: " + quizManager.Error;
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
