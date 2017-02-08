using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingGame
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LessonButton_Click(object sender, EventArgs e)
        {
            // Create and show Lesson Form
            LessonsForm lessonfrm = new LessonsForm();
            lessonfrm.Show();
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            // Create and show Practice Form
            PracticeForm practicefrm = new PracticeForm();
            practicefrm.Show();
        }

        private void Testbutton1_Click(object sender, EventArgs e)
        {
            // Create and show Test Form
            TestForm testfrm = new TestForm();
            testfrm.Show();
        }

        private void ViewScoresbutton1_Click(object sender, EventArgs e)
        {
            // Create and show View Scores Form
            ViewScoresForm viewscoresfrm = new ViewScoresForm();
            viewscoresfrm.Show();
        }
    }
}
