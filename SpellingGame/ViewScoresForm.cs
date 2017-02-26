using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SpellingGame
{
    public partial class ViewScoresForm : Form
    {
        public ViewScoresForm()
        {
            InitializeComponent();
        }

        private void ViewScoresForm_Load(object sender, EventArgs e)
        {
            initializeHighScores();
            displayHighScores();
        }

        /* This method initializes each score label to display, "Empty"
         * Since it might be possible that there are currently no high scores
         * we initialize each label to contain a short message indicating that
         * there are no scores present */
        private void initializeHighScores()
        {
            for(int i = 1; i <= 10; i++)
            {
                Control myScoreLabel = this.Controls["lblHighScore" + i];
                myScoreLabel.Text = "- - - Empty - - -";
            }
        }

        /* This method updates each control containing the user's
         * name and the user's high score */
        private void displayHighScores()
        {            
            List<Data.Score> orderedHighScores = getOrderedHighScores();

            /* Loop through each label and update the score */
            for (int i = 0; i < orderedHighScores.Count; i++)
            {
                Data.Score currentScore = orderedHighScores[i];
                Control labelToUpdate = this.Controls["lblHighScore" + (i + 1)];
                labelToUpdate.Text = currentScore.Username + " - " + currentScore.Points;

                /* There are only 10 labels in our User Interface; however, 
                 * there might be an instance where our database could have
                 * more than 10 scores stored in it. If our loop varialbe
                 * has reached 9, this means that we have updated all our 10
                 * labels and we can break out of the loop  */
                if (i == 9)
                    break;
            }
        }

        /* This method queries the database and creates an ordered list
         * containing Score objects. These objects contain the
         * the user's name and the user's current high score */
        private List<Data.Score> getOrderedHighScores()
        {
            List <Data.Score> orderedHighScores = new List<Data.Score>();

            using (var db = new Data.Database())
            {
                foreach (Data.Score score in db.Scores.OrderByDescending(x => x.Points))
                {
                    orderedHighScores.Add(score);
                }
            }               

            return orderedHighScores;
        }

        private void lblHighScore3_Click(object sender, EventArgs e)
        {

        }

        private void s2_Click(object sender, EventArgs e)
        {

        }
    }
}
