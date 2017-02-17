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
            this.txtSpelling = new System.Windows.Forms.TextBox();
            this.lblSpelling = new System.Windows.Forms.Label();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.btnCheckSpelling = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.lblSentence = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWord.Location = new System.Drawing.Point(17, 18);
            this.pictureBoxWord.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(340, 143);
            this.pictureBoxWord.TabIndex = 2;
            this.pictureBoxWord.TabStop = false;
            this.pictureBoxWord.Click += new System.EventHandler(this.pictureBoxWord_Click);
            // 
            // txtSpelling
            // 
            this.txtSpelling.Location = new System.Drawing.Point(97, 210);
            this.txtSpelling.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpelling.Name = "txtSpelling";
            this.txtSpelling.Size = new System.Drawing.Size(173, 20);
            this.txtSpelling.TabIndex = 3;
            this.txtSpelling.TextChanged += new System.EventHandler(this.txtSpelling_TextChanged);
            // 
            // lblSpelling
            // 
            this.lblSpelling.Location = new System.Drawing.Point(18, 210);
            this.lblSpelling.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpelling.Name = "lblSpelling";
            this.lblSpelling.Size = new System.Drawing.Size(75, 17);
            this.lblSpelling.TabIndex = 4;
            this.lblSpelling.Text = "Enter Spelling:";
            // 
            // btnCheckSpelling
            // 
            this.btnCheckSpelling.Location = new System.Drawing.Point(97, 238);
            this.btnCheckSpelling.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckSpelling.Name = "btnCheckSpelling";
            this.btnCheckSpelling.Size = new System.Drawing.Size(105, 26);
            this.btnCheckSpelling.TabIndex = 5;
            this.btnCheckSpelling.Text = "Check Spelling";
            this.btnCheckSpelling.UseVisualStyleBackColor = true;
            this.btnCheckSpelling.Click += new System.EventHandler(this.btnCheckSpelling_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackgroundImage = global::SpellingGame.Properties.Resources.audio_icon;
            this.btnAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAudio.Location = new System.Drawing.Point(367, 18);
            this.btnAudio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(61, 51);
            this.btnAudio.TabIndex = 6;
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Location = new System.Drawing.Point(17, 170);
            this.lblSentence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(103, 13);
            this.lblSentence.TabIndex = 7;
            this.lblSentence.Text = "Sentence goes here";
            this.lblSentence.Click += new System.EventHandler(this.lblSentence_Click);
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(372, 89);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(0, 13);
            this.lblWordCount.TabIndex = 8;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(319, 219);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(108, 44);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Review Missed Items";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(337, 184);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "lblScore";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnCheckSpelling);
            this.Controls.Add(this.lblSpelling);
            this.Controls.Add(this.txtSpelling);
            this.Controls.Add(this.pictureBoxWord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestForm";
            this.Text = "Test in progress! - Time goes here maybe";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxWord;
        private System.Windows.Forms.TextBox txtSpelling;
        private System.Windows.Forms.Label lblSpelling;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Button btnCheckSpelling;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Label lblScore;
    }
}