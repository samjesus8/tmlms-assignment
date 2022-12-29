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

        }
    }
}
