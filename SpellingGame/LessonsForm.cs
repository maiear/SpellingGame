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

            // Connect to database
            using (var db = new Data.Database())
            {
                // Get the list of rules as objects
                List<Data.Rule> allRules = db.Rules.ToList();
                // Get the list of rule names
                List<string> allRuleNames = allRules.Select(Rule => Rule.RuleName).ToList();
                // Show the list of rule names
                listBox1.DataSource = allRuleNames;


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        
        private void Selectbutton_Click(object sender, EventArgs e)
        {
            // Create and show View Rule Form (The index of the rule is passed to the next Form, whish is the id of the rule in the database)
            ViewRuleForm F2 = new ViewRuleForm(listBox1.SelectedIndex + 1);
            F2.ShowDialog();
        }
    }
}
