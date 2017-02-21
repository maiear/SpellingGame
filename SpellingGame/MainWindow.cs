using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {

            using (var db = new Data.Database())
            {
                // Get the list of words as objects
                List<Data.Word> allWords = db.Words.ToList();

                foreach (string line in File.ReadAllLines(@"C:\Users\Maie\OneDrive\Spelling Game\Pictures\Path.txt"))
                {
                    string[] columns = line.Split(',');
                    Data.Word word = allWords.Single(w => w.WordId == int.Parse(columns[0]));
                    word.Image = File.ReadAllBytes(@"C:\Users\Maie\OneDrive\Spelling Game\Pictures\" + columns[1]);
                    db.SaveChanges();
                }
            }
        }
    }

}
