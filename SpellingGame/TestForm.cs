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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }       

        private void btnCheckSpelling_Click(object sender, EventArgs e)
        {

        }
        private Boolean spellCheck(String s1, String s2)
        {
            return s1.Equals(s2);
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
