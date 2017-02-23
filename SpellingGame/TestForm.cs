using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        private Data.Score scoreData;
        private int bankFillCount = 0;
        private long score = 0;
        private string nameUser = "";
        private string dateTest = "";
        private int testWordIndex = 0;
        private static int numberOfTries = 3;
        private bool lockScore;
        private int timerMin = 2;
        private int timerSec = 59;
        private bool minuteFlag = false;
        private List<long> wordIdentList = new List<long>();
        private List<Data.Word> missedWords = new List<Data.Word>();
        private List<Data.Word> testWordBank = new List<Data.Word>();
        private List<Data.Rule> wordsandRules = new List<Data.Rule>();

        private void TestWordsForm_Load()
        {
            // Load all of the word IDs into wordIdentList in random order
            Random rnd = new Random();
            while (bankFillCount < 562){
                    long wordIdent = rnd.Next(562);
                    if (wordIdentList.Contains(wordIdent)){
                        continue; //doesn't add a repeated ID to the list
                    }
                    wordIdentList.Add(wordIdent);
                    bankFillCount++;
                }
            
            txtSpelling.Enabled = false;
            btnAudio.Enabled = false;
            btnStartTest.Enabled = false;
            btnFeedback.Enabled = false;
            lblSentence.Text = "Enter Username and Date above. Click Start Test to begin.";
            lblScore.Text = "Score: " + score;
            lblResult.Text = "";
            timer1.Interval = 1000;//this equals a 1 second interval
            timer1.Tick += OnTimeEvent;//
        }

        private void loadTestWord()
        {
            // Cycle back through the word IDs chosen from the word bank. testWordIndex is initialized to 562
            long currentTestWordID = wordIdentList.ElementAt(testWordIndex);

            //Open a DB connection and pull the word with the matching wordID as the next test item
            using (var db = new Data.Database())
            {
                word = db.Words.Find(currentTestWordID);
            }

            if (testWordIndex >= 0) { 
                
                    if (word.Image == null)
                    {
                    pictureBoxWord.BackColor = Color.Beige;
                    }
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
                    lblSentence.Text = "";
                    lblSentence.Text = word.Sentence;
                }

            if (testWordIndex < 0)
            {

                lblSentence.Text = "You have finished the test. Click on review missed words >";
                btnFeedback.Enabled = true;
                btnAudio.Enabled = false;
                txtSpelling.Enabled = false;
            }
        }

        private void checkSpelling()
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
                            lblResult.ForeColor = Color.Red;
                            lblResult.Text = "Incorrect! " + (numberOfTries -1) + " tries left!";
                            numberOfTries--;
                        }
                        if (spellCheckResult == false && numberOfTries == 0)
                        {
                            lblResult.Text = "No tries left, sorry!";
                            testWordIndex++;
                            numberOfTries = 3;
                            missedWords.Add(word);
                            loadNextTestWord();
                            lblResult.Text = "";
                        }
                        if (spellCheckResult == true && lockScore == false)
                        {
                            lblResult.ForeColor = Color.Green;
                            string correct = "Correct!";
                            lblResult.Text = string.Format("{0}", correct.PadLeft(18,' '));
                            testWordIndex++;
                            score++;
                            lblScore.Text = "Score: " + score;
                            numberOfTries = 3;
                            lockScore = true;
                            loadNextTestWord();
                            lblResult.Text = "";
                        }
                    }
                }

                if (word == null)
                {
                    lblSentence.Text = "Press return to load a new word.";
                }
            }
        }

        private Boolean spellCheck(String s1, String s2)
        {
            return s1.Equals(s2);
        }

        private void loadNextTestWord()
        {
            txtSpelling.Enabled = true;
            btnStartTest.Enabled = false;
            txtSpelling.Text = "";
            loadTestWord();
            playAudioForCurrentWord();
            lockScore = false;
            checkSpelling();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            lblTimer.ForeColor = Color.Black;
            timer1.Start();
            loadNextTestWord();
            btnAudio.Enabled = true;
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
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

        private void checkForReturnKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
               
                if (txtSpelling.Text.Equals(""))
                {
                    lblSentence.Text = "You did not enter anything.";
                }

                checkSpelling();
            }
        }

        private void checkForUserInfo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;

                if (txtUsername.Text.Equals(""))
                {
                    System.Windows.Forms.MessageBox.Show("Enter your username");
                }

                if (txtDate.Text.Equals(""))
                {
                    System.Windows.Forms.MessageBox.Show("Enter the date");
                }
                
                if (!txtDate.Text.Equals("") && !txtUsername.Equals(""))
                {
                    this.nameUser = txtUsername.Text;
                    this.dateTest = txtDate.Text;
                    txtUsername.Enabled = false;
                    txtDate.Enabled = false;
                    btnStartTest.Enabled = true;
                }  
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            displayFeedback();
        }

        private void displayFeedback()
        {
            string missedWordList = "";

            for (int i = 0; i < missedWords.Count(); i++) {

                missedWordList += missedWords.ElementAt(i).Word1.ToString() + "\n";
            }

            System.Windows.Forms.MessageBox.Show(missedWordList);
        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                timerSec -= 1;
                if (timerSec == 0 && minuteFlag == false)
                {
                    timerSec = 59;
                    timerMin -= 1;
                }
                if (timerSec == 0 && minuteFlag == true)
                {
                    timerSec = 0;
                }
                if (timerMin < 1)
                {
                    lbltimerDisplay.ForeColor = Color.Red;
                    minuteFlag = true;
                }
                if (timerMin == 0 && timerSec == 0)
                {
                    timer1.Stop();
                    endTest();
                }
                lbltimerDisplay.Text = string.Format("{0}:{1}", timerMin.ToString().PadLeft(2, '0'),
                    timerSec.ToString().PadLeft(2, '0'));
            }));
        }

        private void endTest()
        {
            timerSec = 0;
            txtSpelling.Enabled = false;
            btnStartTest.Enabled = false;
            txtSpelling.Text = "";
            btnAudio.Enabled = false;
            lblSentence.Text = "Your test is over. Review your missed items. >>";
            btnFeedback.Enabled = true;

            scoreData = new Data.Score();

            using (var dbase = new Data.Database())
            {
                scoreData.Username = nameUser;
                scoreData.Points = score;
                scoreData.Date = dateTest;
                dbase.Scores.Add(scoreData);
            }
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void txtSpelling_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
