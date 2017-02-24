namespace SpellingGame
{
    partial class PracticeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.noWordsListBox = new System.Windows.Forms.ListBox();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.NoWordsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practice";
            // 
            // noWordsListBox
            // 
            this.noWordsListBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noWordsListBox.FormattingEnabled = true;
            this.noWordsListBox.ItemHeight = 19;
            this.noWordsListBox.Location = new System.Drawing.Point(319, 153);
            this.noWordsListBox.Name = "noWordsListBox";
            this.noWordsListBox.Size = new System.Drawing.Size(196, 137);
            this.noWordsListBox.TabIndex = 1;
            // 
            // categoryListBox
            // 
            this.categoryListBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 19;
            this.categoryListBox.Location = new System.Drawing.Point(55, 153);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(199, 232);
            this.categoryListBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(62, 121);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(79, 19);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category";
            // 
            // NoWordsLabel
            // 
            this.NoWordsLabel.AutoSize = true;
            this.NoWordsLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoWordsLabel.Location = new System.Drawing.Point(325, 121);
            this.NoWordsLabel.Name = "NoWordsLabel";
            this.NoWordsLabel.Size = new System.Drawing.Size(141, 19);
            this.NoWordsLabel.TabIndex = 4;
            this.NoWordsLabel.Text = "Number of Words";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(359, 338);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(156, 47);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(315, 287);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 6;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 427);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.NoWordsLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.noWordsListBox);
            this.Controls.Add(this.label1);
            this.Name = "PracticeForm";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox noWordsListBox;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label NoWordsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label errorLabel;
    }
}