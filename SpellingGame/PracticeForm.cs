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
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();
            // Connect to database
            using (var db = new Data.Database())
            {
                // Get the list of categories as objects
                List<Data.Category> allCategories = db.Categories.ToList();
                // Get the list of categories names
                List<string> categoryNames = allCategories.Select(Rule => Rule.CategoryDescription).ToList();
                // Show the list of categories names
                categoryListBox.DataSource = categoryNames;

                               


            }
            categoryListBox.ClearSelected();

            //Show the posible numbers of words
            for (int x = 5; x <= 20; x += 5)
            {
                noWordsListBox.Items.Add(x.ToString());
            }
        }

        
        private void PracticeForm_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Checks to see if the user entered a category selection
            if (categoryListBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Please select a category";
            }
            // Checks to see if the user entered number of words selection
            else if (noWordsListBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Please select the number of words";
            }
            
            else
            {
                // Gets the user input
                string category = categoryListBox.SelectedValue.ToString();
                int numberOfWords = int.Parse(noWordsListBox.SelectedItem.ToString());

                // Create and show Practice Words Form
                PracticeWordsForm practiceWordsForm = new PracticeWordsForm(category,numberOfWords);
                practiceWordsForm.Show();


            }


        }
    }
}
