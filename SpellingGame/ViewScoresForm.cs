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
    public partial class ViewScoresForm : Form
    {
        public ViewScoresForm()
        {
            InitializeComponent();
        }

        private void ViewScoresForm_Load(object sender, EventArgs e)
        {
            displayHighScores();
        }

        private void displayHighScores()
        {
            
        }
    }
}
