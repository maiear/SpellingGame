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
        private List<Data.Score> orderedHighScores;

        public ViewScoresForm()
        {
            InitializeComponent();
        }

        private void ViewScoresForm_Load(object sender, EventArgs e)
        {
            initializeHighScoreLabels();
            initialzeHighScoreDataStructure();
            displayHighScores();
        }

        private void initialzeHighScoreDataStructure()
        {
            orderedHighScores = getOrderedHighScores();
        }

        /* This method initializes each score label to display, "Empty"
         * Since it might be possible that there are currently no high scores
         * we initialize each label to contain a short message indicating that
         * there are no scores present */
        private void initializeHighScoreLabels()
        {
            for(int i = 1; i <= 10; i++)
            {
                this.Controls["lblName" + i].Text = " - - EMPTY - -";
                this.Controls["lblScore" + i].Text = " - - EMPTY - -";
                this.Controls["lblDate" + i].Text = " - - EMPTY - -";
            }
        }

        /* This method updates each label containing the user's
         * name, user's high score and the date the score was achieved */
        private void displayHighScores()
        {
            /* Loop through each label and update the name, score and date */
            for (int i = 0; i < orderedHighScores.Count; i++)
            {
                Data.Score currentScore = orderedHighScores[i];
                Control labelNameToUpdate = this.Controls["lblName" + (i + 1)];
                Control labelScoreToUpdate = this.Controls["lblScore" + (i + 1)];
                Control labelDateToUpdate = this.Controls["lblDate" + (i + 1)];
                labelNameToUpdate.Text = currentScore.Username;
                labelScoreToUpdate.Text = currentScore.Points.ToString();
                labelDateToUpdate.Text = currentScore.Date;

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
         * the user's name, user's current high score and the date
         * the high score was achieved */
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
    }
}
