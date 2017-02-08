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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWord.Location = new System.Drawing.Point(26, 27);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(509, 219);
            this.pictureBoxWord.TabIndex = 2;
            this.pictureBoxWord.TabStop = false;
            // 
            // txtSpelling
            // 
            this.txtSpelling.Location = new System.Drawing.Point(146, 323);
            this.txtSpelling.Name = "txtSpelling";
            this.txtSpelling.Size = new System.Drawing.Size(258, 26);
            this.txtSpelling.TabIndex = 3;
            // 
            // lblSpelling
            // 
            this.lblSpelling.Location = new System.Drawing.Point(27, 323);
            this.lblSpelling.Name = "lblSpelling";
            this.lblSpelling.Size = new System.Drawing.Size(113, 26);
            this.lblSpelling.TabIndex = 4;
            this.lblSpelling.Text = "Enter Spelling:";
            // 
            // btnCheckSpelling
            // 
            this.btnCheckSpelling.Location = new System.Drawing.Point(146, 366);
            this.btnCheckSpelling.Name = "btnCheckSpelling";
            this.btnCheckSpelling.Size = new System.Drawing.Size(158, 40);
            this.btnCheckSpelling.TabIndex = 5;
            this.btnCheckSpelling.Text = "Check Spelling";
            this.btnCheckSpelling.UseVisualStyleBackColor = true;
            this.btnCheckSpelling.Click += new System.EventHandler(this.btnCheckSpelling_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackgroundImage = global::SpellingGame.Properties.Resources.audio_icon;
            this.btnAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAudio.Location = new System.Drawing.Point(551, 27);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(91, 79);
            this.btnAudio.TabIndex = 6;
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Location = new System.Drawing.Point(26, 261);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(153, 20);
            this.lblSentence.TabIndex = 7;
            this.lblSentence.Text = "Sentence goes here";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 433);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnCheckSpelling);
            this.Controls.Add(this.lblSpelling);
            this.Controls.Add(this.txtSpelling);
            this.Controls.Add(this.pictureBoxWord);
            this.Name = "TestForm";
            this.Text = "Test in progress! - Time goes here maybe";
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
    }
}