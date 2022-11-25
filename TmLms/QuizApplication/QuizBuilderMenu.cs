using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
