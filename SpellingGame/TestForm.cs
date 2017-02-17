using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpellingGame
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            TestWordsForm_Load();
        }

        private Data.Word word;
        private int bankFillCount = 0;
        private int score = 0;
        private int testWordIndex = 4;
        private static int numberOfTries = 3;
        private List<long> wordIdentList = new List<long>();
        private List<Data.Word> incorrectWords = new List<Data.Word>();
        private List<Data.Word> testWordBank = new List<Data.Word>();

        private void TestWordsForm_Load()
        {
            // Connect to database
            using (var db = new Data.Database())
            {
                while(bankFillCount < 5){
                    // Get 5 words randomly chosen form the entire list
                    Random rnd = new Random();
                    long wordIdent = rnd.Next(562);
                    if (wordIdentList.Contains(wordIdent)){
                        continue;
                    }
                    wordIdentList.Add(wordIdent);
                    testWordBank.Add(db.Words.Find(wordIdent));
                    bankFillCount++;
                }
            }
            txtSpelling.Enabled = false;
            btnCheckSpelling.Enabled = false;
            btnFeedback.Enabled = false;
            lblSentence.Text = "Click on the play audio button to start the test.";
            lblScore.Text = "Score: " + score;
        }

        private void loadTestWord()
        {
            // Cycle through each word chosen from the word bank. testWordIndex is initialized to 0
            if (testWordIndex >= 0)
            {
                word = testWordBank[testWordIndex];
                lblWordCount.Text = "Words left:" + testWordIndex;
                // Show picture
                if (word.Image != null)
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(word.Image))
                    {
                        pictureBoxWord.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Hides the previous picture
                    pictureBoxWord.Image = null;
                }
                // Show sentence
                lblSentence.ForeColor = Color.Black;
                lblSentence.Text = word.Sentence;
            }

            if (testWordIndex < 0)
            {

                lblSentence.Text = "You have finished the test. Click on Review Missed Items.";
                btnFeedback.Enabled = true;
                btnAudio.Enabled = false;
                txtSpelling.Enabled = false;
            }
        }

        private void btnCheckSpelling_Click(object sender, EventArgs e)
        {
            Boolean spellCheckResult;

            if (testWordIndex >= 0)
            {
                if (word != null)
                {
                   
                    if (!txtSpelling.Text.Equals(""))
                    {

                        spellCheckResult = spellCheck(txtSpelling.Text, word.Word1);

                        if (spellCheckResult == false && numberOfTries > 0)
                        {
                            lblSentence.ForeColor = Color.Red;
                            lblSentence.Text = "Incorrect!  Number of tries left: " + (numberOfTries - 1);
                            incorrectWords.Add(word);
                            numberOfTries--;
                        }
                        if (spellCheckResult == false && numberOfTries == 0)
                        {
                            lblSentence.Text = "That was your last chance!  Click on the audio button for the next word";
                            testWordIndex--;
                            btnCheckSpelling.Enabled = false;
                        }
                        if (spellCheckResult == true)
                        {
                            lblSentence.ForeColor = Color.Green;
                            lblSentence.Text = "Correct!  Click on the audio button for the next word";
                            testWordIndex--;
                            score++;
                            lblScore.Text = "Score: " + score;
                            numberOfTries = 3;
                        }
                    }
                }

                if (word == null)
                {
                    lblSentence.Text = "Press the play audio button to load a new word.";
                }

                if (txtSpelling.Text.Equals(""))
                {
                    lblSentence.Text = "You did not type an answer.  At least try!";
                }
            }
        }

        private Boolean spellCheck(String s1, String s2)
        {
            return s1.Equals(s2);
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            txtSpelling.Enabled = true;
            btnCheckSpelling.Enabled = true;
            txtSpelling.Text = "";
            loadTestWord();
            playAudioForCurrentWord();
        }

        private void playAudioForCurrentWord()
        {
            // Speaks the word
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("The word is: " + word.Word1);
        }

        private void lblSentence_Click(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxWord_Click(object sender, EventArgs e)
        {

        }

        private void txtSpelling_TextChanged(object sender, EventArgs e)
        {

        }

        private void wordCountdown()
        {
            
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("test");
        }
    }
}
