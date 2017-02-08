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
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }       

        private void btnCheckSpelling_Click(object sender, EventArgs e)
        {

        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            playAudioForCurrentWord();
        }

        private void playAudioForCurrentWord()
        {
            
        }
    }
}
