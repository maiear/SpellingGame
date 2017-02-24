namespace SpellingGame
{
    partial class PracticeWordsForm
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
            this.pictureBoxPractice = new System.Windows.Forms.PictureBox();
            this.btnAudio = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.checkSpellingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.nextbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfWordsCounter = new System.Windows.Forms.Label();
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPractice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPractice
            // 
            this.pictureBoxPractice.Location = new System.Drawing.Point(42, 50);
            this.pictureBoxPractice.Name = "pictureBoxPractice";
            this.pictureBoxPractice.Size = new System.Drawing.Size(241, 163);
            this.pictureBoxPractice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPractice.TabIndex = 0;
            this.pictureBoxPractice.TabStop = false;
            // 
            // btnAudio
            // 
            this.btnAudio.BackgroundImage = global::SpellingGame.Properties.Resources.audio_icon;
            this.btnAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAudio.Location = new System.Drawing.Point(337, 50);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(63, 46);
            this.btnAudio.TabIndex = 7;
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(228, 256);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(239, 26);
            this.wordTextBox.TabIndex = 8;
            // 
            // checkSpellingButton
            // 
            this.checkSpellingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSpellingButton.Location = new System.Drawing.Point(504, 256);
            this.checkSpellingButton.Name = "checkSpellingButton";
            this.checkSpellingButton.Size = new System.Drawing.Size(108, 66);
            this.checkSpellingButton.TabIndex = 9;
            this.checkSpellingButton.Text = "Check Spelling";
            this.checkSpellingButton.UseVisualStyleBackColor = true;
            this.checkSpellingButton.Click += new System.EventHandler(this.checkSpellingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the spelling:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(42, 353);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(570, 130);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.Visible = false;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(513, 507);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(99, 32);
            this.nextbutton.TabIndex = 14;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of Words:";
            // 
            // numberOfWordsCounter
            // 
            this.numberOfWordsCounter.AutoSize = true;
            this.numberOfWordsCounter.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfWordsCounter.Location = new System.Drawing.Point(542, 90);
            this.numberOfWordsCounter.Name = "numberOfWordsCounter";
            this.numberOfWordsCounter.Size = new System.Drawing.Size(0, 21);
            this.numberOfWordsCounter.TabIndex = 16;
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.AutoSize = true;
            this.sentenceLabel.Location = new System.Drawing.Point(333, 129);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(0, 20);
            this.sentenceLabel.TabIndex = 17;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(417, 213);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 21);
            this.resultLabel.TabIndex = 18;
            // 
            // PracticeWordsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(655, 561);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.sentenceLabel);
            this.Controls.Add(this.numberOfWordsCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSpellingButton);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.pictureBoxPractice);
            this.Name = "PracticeWordsForm";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.PracticeWordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPractice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPractice;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button checkSpellingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberOfWordsCounter;
        private System.Windows.Forms.Label sentenceLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}