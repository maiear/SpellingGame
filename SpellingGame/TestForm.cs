﻿using System;
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
using System.Threading;

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
        private long score = 0;
        private string nameUser = "";
        private int testWordIndex = 0;
        private static int numberOfTries = 3;
        private bool lockScore;
        private long[] wordIdentList;
        private List<Data.Word> missedWords = new List<Data.Word>();
        private List<Data.Rule> wordsandRules = new List<Data.Rule>();
        private DateTime time = DateTime.MinValue.AddMinutes(3);

        private void TestWordsForm_Load()
        {
            // Get the id numbers randomized in an array
            Random rnd = new Random();
            wordIdentList = Enumerable.Range(1, 562).OrderBy(r => rnd.Next(100000)).Select(i=>(long) i).ToArray();
            
               
            
            txtSpelling.Enabled = false;
            btnAudio.Enabled = false;
            btnFeedback.Enabled = false;
            lblSentence.Text = "Click Start Test to begin.";
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
                    // Hides the previous picture
                    pictureBoxWord.Image = null;
                }
                else
                {
                    // Show picture
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(word.Image))
                    {
                        pictureBoxWord.Image = Image.FromStream(ms);
                        pictureBoxWord.BackColor = Color.FromArgb(240, 240, 240);

                    }

                }
                // Show sentence
                lblSentence.Text = word.Sentence;
               
                lblResult.Hide();
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
                        correctLabel.Hide();

                        spellCheckResult = spellCheck(txtSpelling.Text, word.Word1);

                        if (spellCheckResult == false && numberOfTries > 0)
                        {
                            lblResult.ForeColor = Color.Red;
                            lblResult.Text = "Incorrect! " + (numberOfTries -1) + " tries left!";
                            lblResult.Show();
                            numberOfTries--;
                        }
                        if (spellCheckResult == false && numberOfTries == 0)
                        {
                            lblResult.Text = "No tries left, sorry!";
                            lblResult.Show();
                            testWordIndex++;
                            numberOfTries = 3;
                            missedWords.Add(word);
                            loadNextTestWord();
                        }
                        if (spellCheckResult == true && lockScore == false)
                        {
                            correctLabel.ForeColor = Color.Green;
                            string correct = "Correct!";
                            correctLabel.Text = string.Format("{0}", correct.PadLeft(18,' '));
                            correctLabel.Show();
                            testWordIndex++;
                            score++;
                            lblScore.Text = "Score: " + score;
                            numberOfTries = 3;
                            lockScore = true;
                            loadNextTestWord();
                        }
                    }
                }
                else
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
            // Start new thread
            Task.Run(() =>
            {
                // Speaks the word
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak("The word is: " + word.Word1);
            });
        }

        private void checkForReturnKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                errorLabel.Hide();


                if (txtSpelling.Text.Equals(""))
                {

                    errorLabel.Text = "You did not enter anything.";
                    errorLabel.Show();
                }
                else
                {
                    checkSpelling();
                }
            }
        }

        //private void checkForUserInfo(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        e.Handled = true;

        //        if (txtUsername.Text.Equals(""))
        //        {
        //            System.Windows.Forms.MessageBox.Show("Enter your username");
        //        }

        //        if (txtDate.Text.Equals(""))
        //        {
        //            System.Windows.Forms.MessageBox.Show("Enter the date");
        //        }
                
        //        if (!txtDate.Text.Equals("") && !txtUsername.Equals(""))
        //        {
        //            this.nameUser = txtUsername.Text;
        //            this.dateTest = txtDate.Text;
        //            txtUsername.Enabled = false;
        //            txtDate.Enabled = false;
        //            btnStartTest.Enabled = true;
        //        }  
        //    }
        //}

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

            // Create and show View Scores Form
            TestResultsForm viewresultsfrm = new TestResultsForm(missedWords);
            viewresultsfrm.Show();
        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                time = time.AddSeconds(-1);
                lbltimerDisplay.Text = time.ToString("mm:ss");

                if (time.Minute == 0 && time.Second == 59)
                {
                    lbltimerDisplay.ForeColor = Color.Red;
                }

                if (time.Minute == 0 && time.Second == 0)
                {
                    timer1.Stop();
                    endTest();
                }
            }));
        }

        private void endTest()
        {
            txtSpelling.Enabled = false;
            btnStartTest.Enabled = false;
            txtSpelling.Text = "";
            btnAudio.Enabled = false;
            lblSentence.Text = "Your test is over. Review your missed items. >>";
            btnFeedback.Enabled = true;

            //scoreData = new Data.Score();

            //using (var dbase = new Data.Database())
            //{
            //    scoreData.Username = nameUser;
            //    scoreData.Points = score;
            //    scoreData.Date = dateTest;
            //    dbase.Scores.Add(scoreData);
            //}

            //using (var db = new Data.Database())
            //{
            //    int count = db.Scores.Count();

            //    if (count == 10)
            //    {
            //        long min = db.Scores.Min(s => s.Points);
            //        long newScore;
            //        if (min < newScore)
            //        {
            //            db.
            //        }
            //    }
            //    else
            //    {

            //    }
            //}
        }

        
    }
}
