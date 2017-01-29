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
    public partial class ViewRuleForm : Form
            {
        private int _ruleNumber;
        public ViewRuleForm(int ruleNumber)
        {
            InitializeComponent();
            _ruleNumber = ruleNumber;

            
        }

        private void ViewRuleForm_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("about:blank");
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            

            using (var db = new Data.Database())
            {

                string lesson = db.Rules.Single(r => r.RuleId == _ruleNumber).RuleDescription;

                webBrowser.Document.Body.InnerHtml = lesson;



            }
        }
    }
}
