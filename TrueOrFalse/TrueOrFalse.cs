using System.Windows.Forms;

namespace TrueOrFalse
{
    public partial class TrueOrFalseControl: UserControl
    {
        public bool isTrue { get; set; }
        public bool isFalse { get; set; }
        public TrueOrFalseControl()
        {
            InitializeComponent();
        }

        public bool CheckAnswer() 
        {
            if(trueBox.Checked) 
            {
                isTrue = true;
                isFalse = false;
                return true;
            }
            else if (falseBox.Checked) 
            {
                isFalse = true;
                isTrue = false;
                return true;
            }
            else 
            {
                MessageBox.Show("Please select if your answer is true or false", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
