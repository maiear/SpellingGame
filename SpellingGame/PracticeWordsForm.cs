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
            this.category = category;
            this.numberOfWords = numberOfWords;
        }

        private void PracticeWordsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
