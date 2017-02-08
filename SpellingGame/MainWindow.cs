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
            LessonsForm lessonfrm = new LessonsForm();
            lessonfrm.Show();
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            PracticeForm practicefrm = new PracticeForm();
            practicefrm.Show();
        }

        private void Testbutton1_Click(object sender, EventArgs e)
        {
            TestForm testfrm = new TestForm();
            testfrm.Show();
        }

        private void ViewScoresbutton1_Click(object sender, EventArgs e)
        {
            ViewScoresForm viewscoresfrm = new ViewScoresForm();
            viewscoresfrm.Show();
        }
    }
}
