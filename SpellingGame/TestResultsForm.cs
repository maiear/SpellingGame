using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpellingGame.Data;

namespace SpellingGame
{
    public partial class TestResultsForm : Form
    {
        private List<Word> missedWords;

       
        public TestResultsForm(List<Word> missedWords)
        {
            InitializeComponent();
            this.missedWords = missedWords;
        }

        private void TestResultsForm_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate("about:blank");
            
        }

        

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string html = "<div style=\"font-family:Rockwell\">";
            using (var db = new Data.Database())
            {
                foreach( Data.Word word in missedWords)
                {
                    List<Data.Rule> rules = db.Rules.Where(r => r.Words.Select(w => w.WordId).Contains(word.WordId)).ToList();

                    html += "<h2>" + word.Word1 + "</h2>";

                    foreach( Data.Rule rule in rules)
                    {
                        html += "<h3>" + rule.RuleName + "</h3>";
                        html += rule.RuleShortVersion;
                    }

                } 
            }
            html += "</div>";
            webBrowser1.Document.BackColor = Color.FromArgb(240, 240, 240);
            
            webBrowser1.Document.Body.InnerHtml = html;
        }
    }
}
