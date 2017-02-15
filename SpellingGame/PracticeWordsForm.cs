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
        private Data.Word word;
        private string rulesHtml;
        private int counter = 1;
        private List<Data.Word> allWordsInACategory;

        private void PracticeWordsForm_Load(object sender, EventArgs e)
        {
            // Connect to database
            using (var db = new Data.Database())
            {
                // Get the category Id
                long categoryId = db.Categories.Single(c => c.CategoryDescription == this.category).CategoryId;
                // Get the list of words in a specific category as objects
                allWordsInACategory = db.Words.Include("Rules").Where(w => w.CategoryId == categoryId).ToList();


            }
            // Calls the function that displays the word information
            NewWord();

        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            // Speaks the word
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("The word is: " + word.Word1);

        }

        private void checkSpellingButton_Click(object sender, EventArgs e)
        {

            // Checks to see if the answer is correct
            if (wordTextBox.Text == word.Word1)
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
            // Displays the result label to the user
            resultLabel.Show();

            // Displays the rules of the word
            webBrowser1.Navigate("about:blank");


        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

            // Displays the short version of the rules
            webBrowser1.Document.Body.InnerHtml = rulesHtml;
            webBrowser1.Show();

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            // Hides the labels that have information that is displayed after checking the spelling
            webBrowser1.Hide();
            resultLabel.Hide();
            wordTextBox.Text = "";
            // Adds one to the counter of words
            counter++;

            // Checks if the counter has reached the number of words the user wants to practice with
            if (counter <= this.numberOfWords)
            {
                // Calls the method to display the new word information
                NewWord();
            }
            else
            {
                // Closes the windows form
                this.Close();
            }


        }
        private void NewWord()
        {
            // Select a random word object from the list, store it in an instance, and delete it from the list.
            Random rnd = new Random();
            int index = rnd.Next(allWordsInACategory.Count);
            word = allWordsInACategory[index];
            allWordsInACategory.RemoveAt(index);

            // Get the rules

            rulesHtml = "";
            foreach (Data.Rule rule in word.Rules)
            {
                // Gets the rules of the word
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
            else
            {
                // Hides the previous picture
                pictureBoxPractice.Image = null;
            }

            // Show sentence
            sentenceLabel.Text = word.Sentence;
            // Shows the counter and the number of pictures that the user requested
            numberOfWordsCounter.Text = counter + "/" + this.numberOfWords;
        }


    }
}
