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
    public partial class LessonsForm : Form
    {
        public LessonsForm()
        {
            InitializeComponent();

            using (var db = new Data.Database())
            {

                List<Data.Rule> allRules = db.Rules.ToList();

                List<string> allRuleNames = allRules.Select(Rule => Rule.RuleName).ToList();

                listBox1.DataSource = allRuleNames;


            }
        }

        
      

       

        
    }
}
