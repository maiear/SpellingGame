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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWord.Location = new System.Drawing.Point(82, 72);
            this.pictureBoxWord.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(382, 231);
            this.pictureBoxWord.TabIndex = 2;
            this.pictureBoxWord.TabStop = false;
            this.pictureBoxWord.Click += new System.EventHandler(this.pictureBoxWord_Click);
            // 
            // lblSpelling
            // 
            this.lblSpelling.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblSpelling.Location = new System.Drawing.Point(18, 360);
            this.lblSpelling.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpelling.Name = "lblSpelling";
            this.lblSpelling.Size = new System.Drawing.Size(147, 19);
            this.lblSpelling.TabIndex = 4;
            this.lblSpelling.Text = "Enter Spelling:";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartTest.Location = new System.Drawing.Point(239, 401);
            this.btnStartTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(112, 76);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackgroundImage = global::SpellingGame.Properties.Resources.audio_icon;
            this.btnAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAudio.Location = new System.Drawing.Point(601, 60);
            this.btnAudio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(81, 61);
            this.btnAudio.TabIndex = 6;
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Font = new System.Drawing.Font("Rockwell", 13.25F);
            this.lblSentence.Location = new System.Drawing.Point(17, 318);
            this.lblSentence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(170, 20);
            this.lblSentence.TabIndex = 7;
            this.lblSentence.Text = "Sentence goes here";
            this.lblSentence.Click += new System.EventHandler(this.lblSentence_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFeedback.Location = new System.Drawing.Point(572, 394);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(146, 81);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Review Missed Items";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblScore.Location = new System.Drawing.Point(598, 318);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(84, 21);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "lblScore";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // txtSpelling
            // 
            this.txtSpelling.Location = new System.Drawing.Point(173, 362);
            this.txtSpelling.Name = "txtSpelling";
            this.txtSpelling.Size = new System.Drawing.Size(254, 20);
            this.txtSpelling.TabIndex = 11;
            this.txtSpelling.TextChanged += new System.EventHandler(this.txtSpelling_TextChanged);
            this.txtSpelling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForReturnKey);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblTimer.Location = new System.Drawing.Point(585, 141);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(60, 21);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "Time:";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lbltimerDisplay
            // 
            this.lbltimerDisplay.AutoSize = true;
            this.lbltimerDisplay.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lbltimerDisplay.Location = new System.Drawing.Point(640, 141);
            this.lbltimerDisplay.Name = "lbltimerDisplay";
            this.lbltimerDisplay.Size = new System.Drawing.Size(56, 21);
            this.lbltimerDisplay.TabIndex = 14;
            this.lbltimerDisplay.Text = "00:00";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblResult.Location = new System.Drawing.Point(548, 221);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(88, 21);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "lblResult";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblUsername.Location = new System.Drawing.Point(29, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 21);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(137, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForUserInfo);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.lblDate.Location = new System.Drawing.Point(324, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 21);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(387, 22);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(115, 20);
            this.txtDate.TabIndex = 19;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForUserInfo);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 503);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestForm";
            this.Text = "Test in progress!";
            this.Load += new System.EventHandler(this.TestForm_Load);
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
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
    }
}