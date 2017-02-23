namespace SpellingGame
{
    partial class TestResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.missedWordsLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // missedWordsLabel
            // 
            this.missedWordsLabel.AutoSize = true;
            this.missedWordsLabel.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedWordsLabel.Location = new System.Drawing.Point(232, 18);
            this.missedWordsLabel.Name = "missedWordsLabel";
            this.missedWordsLabel.Size = new System.Drawing.Size(271, 36);
            this.missedWordsLabel.TabIndex = 1;
            this.missedWordsLabel.Text = "Missed Words";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(36, 66);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(661, 432);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // TestResultsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 528);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.missedWordsLabel);
            this.Name = "TestResultsForm";
            this.Text = "TestResultsForm";
            this.Load += new System.EventHandler(this.TestResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label missedWordsLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}