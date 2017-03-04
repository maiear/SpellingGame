namespace SpellingGame
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxWord = new System.Windows.Forms.PictureBox();
            this.lblSpelling = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.lblSentence = new System.Windows.Forms.Label();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtSpelling = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimerDisplay = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWord.Location = new System.Drawing.Point(123, 28);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(572, 354);
            this.pictureBoxWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWord.TabIndex = 2;
            this.pictureBoxWord.TabStop = false;
            // 
            // lblSpelling
            // 
            this.lblSpelling.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblSpelling.Location = new System.Drawing.Point(26, 497);
            this.lblSpelling.Name = "lblSpelling";
            this.lblSpelling.Size = new System.Drawing.Size(220, 29);
            this.lblSpelling.TabIndex = 4;
            this.lblSpelling.Text = "Enter Spelling:";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartTest.Location = new System.Drawing.Point(358, 562);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(168, 117);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackgroundImage = global::SpellingGame.Properties.Resources.audio_icon;
            this.btnAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAudio.Location = new System.Drawing.Point(902, 28);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(122, 94);
            this.btnAudio.TabIndex = 6;
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Font = new System.Drawing.Font("Rockwell", 13.25F);
            this.lblSentence.Location = new System.Drawing.Point(26, 405);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(170, 20);
            this.lblSentence.TabIndex = 7;
            this.lblSentence.Text = "Sentence goes here";
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFeedback.Location = new System.Drawing.Point(923, 554);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(219, 125);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Review Missed Items";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblScore.Location = new System.Drawing.Point(1019, 404);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(84, 21);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "lblScore";
            // 
            // txtSpelling
            // 
            this.txtSpelling.Location = new System.Drawing.Point(260, 495);
            this.txtSpelling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpelling.Name = "txtSpelling";
            this.txtSpelling.Size = new System.Drawing.Size(379, 26);
            this.txtSpelling.TabIndex = 11;
            this.txtSpelling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForReturnKey);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblTimer.Location = new System.Drawing.Point(878, 151);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(60, 21);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "Time:";
            // 
            // lbltimerDisplay
            // 
            this.lbltimerDisplay.AutoSize = true;
            this.lbltimerDisplay.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lbltimerDisplay.Location = new System.Drawing.Point(960, 152);
            this.lbltimerDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltimerDisplay.Name = "lbltimerDisplay";
            this.lbltimerDisplay.Size = new System.Drawing.Size(56, 21);
            this.lbltimerDisplay.TabIndex = 14;
            this.lbltimerDisplay.Text = "00:00";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblResult.Location = new System.Drawing.Point(840, 256);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(88, 21);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "lblResult";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(265, 457);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 19);
            this.errorLabel.TabIndex = 16;
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.Location = new System.Drawing.Point(840, 257);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(0, 21);
            this.correctLabel.TabIndex = 17;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 705);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbltimerDisplay);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtSpelling);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.lblSpelling);
            this.Controls.Add(this.pictureBoxWord);
            this.Name = "TestForm";
            this.Text = "Test in progress!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxWord;
        private System.Windows.Forms.Label lblSpelling;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtSpelling;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimerDisplay;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label correctLabel;
    }
}