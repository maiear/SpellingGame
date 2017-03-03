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
    public partial class HighScoreForm : Form
    {
        private long score;
        private Data.Score minScoreObject;


        public HighScoreForm(long score, Data.Score minScoreObject = null)
        {
            InitializeComponent();
            this.score = score;
            this.minScoreObject = minScoreObject;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "")
            {
                errorLabel.Text = "Please enter your name";
            }
            else
            {
                using (var db = new Data.Database())
                {
                    if (minScoreObject != null)
                    {
                        db.Scores.Attach(minScoreObject);
                        db.Scores.Remove(minScoreObject);
                    }

                    Data.Score scoreData = new Data.Score();

                    scoreData.Username = nameTextBox.Text;
                    scoreData.Points = score;
                    scoreData.Date = DateTime.Now.ToShortDateString();
                    db.Scores.Add(scoreData);
                    db.SaveChanges();


                }

                // Create and show View Scores Form
                ViewScoresForm viewscoresfrm = new ViewScoresForm();
                viewscoresfrm.ShowDialog();

                this.Hide();
            }
        }
    }
}
