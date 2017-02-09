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
    /* This is the TestForm class! (Test Comment!)*/
    public partial class TestForm : Form
    {
        public TestForm()
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
