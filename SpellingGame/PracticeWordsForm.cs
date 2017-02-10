using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpellingGame
{
    public partial class PracticeWordsForm : Form
    {
        private string category;
        private int numberOfWords;

        public PracticeWordsForm()
        {
            InitializeComponent();
        }

        public PracticeWordsForm(string category, int numberOfWords)
        {
            InitializeComponent();
            this.category = category;
            this.numberOfWords = numberOfWords;
        }
        Data.Word word;
        string rulesHtml = "";

        private void PracticeWordsForm_Load(object sender, EventArgs e)
        {
            // Connect to database
            using (var db = new Data.Database())
            {
                // Get the category Id
                long categoryId = db.Categories.Single(c => c.CategoryDescription == this.category).CategoryId;
                // Get the list of words in a specific category as objects
                List<Data.Word> allWordsInACategory = db.Words.Where(w => w.CategoryId == categoryId).ToList();


                // Select a random word object from the list, store it in an instance, and delete it from the list.
                Random rnd = new Random();
                int index = rnd.Next(allWordsInACategory.Count);
                word = allWordsInACategory[index];
                allWordsInACategory.RemoveAt(index);

                // Get the rules

                foreach (Data.Rule rule in word.Rules)
                {
                    rulesHtml += rule.RuleShortVersion;
                }

                // Show picture
                if (word.Image != null)
                {

                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(word.Image))
                    {
                        pictureBoxPractice.Image = Image.FromStream(ms);

                    }
                }
                
                // Show sentence
                sentenceLabel.Text = word.Sentence;

                
            }

        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak(word.Word1);

        }

        private void checkSpellingButton_Click(object sender, EventArgs e)
        {
            // Checks to see if the answer is correct
            if(wordTextBox.Text == word.Word1)
            {
                // Change the color of the font
                resultLabel.ForeColor = Color.Green;
                // Displays "Correct!"
                resultLabel.Text = "Correct!";
            }
            else
            {
                // Changes the color of the font
                resultLabel.ForeColor = Color.Red;
                // Displays "incorrect!"
                resultLabel.Text = "Incorrect";

            }

            webBrowser1.Navigate("about:blank");

            
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

            // Displays the show version of the rules
            webBrowser1.Document.Body.InnerHtml = rulesHtml;

        }
    }
}
