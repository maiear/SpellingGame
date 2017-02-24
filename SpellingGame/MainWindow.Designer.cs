namespace SpellingGame
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label2 = new System.Windows.Forms.Label();
            this.LessonButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.ViewScoresButton = new System.Windows.Forms.Button();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spelling Game";
            // 
            // LessonButton
            // 
            this.LessonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonButton.Location = new System.Drawing.Point(69, 192);
            this.LessonButton.Name = "LessonButton";
            this.LessonButton.Size = new System.Drawing.Size(146, 46);
            this.LessonButton.TabIndex = 1;
            this.LessonButton.Text = "Lesson";
            this.LessonButton.UseVisualStyleBackColor = true;
            this.LessonButton.Click += new System.EventHandler(this.LessonButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton.Location = new System.Drawing.Point(69, 275);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(146, 46);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.Testbutton1_Click);
            // 
            // ViewScoresButton
            // 
            this.ViewScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewScoresButton.Location = new System.Drawing.Point(271, 275);
            this.ViewScoresButton.Name = "ViewScoresButton";
            this.ViewScoresButton.Size = new System.Drawing.Size(146, 46);
            this.ViewScoresButton.TabIndex = 4;
            this.ViewScoresButton.Text = "View Scores";
            this.ViewScoresButton.UseVisualStyleBackColor = true;
            this.ViewScoresButton.Click += new System.EventHandler(this.ViewScoresbutton1_Click);
            // 
            // PracticeButton
            // 
            this.PracticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeButton.Location = new System.Drawing.Point(271, 192);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(146, 46);
            this.PracticeButton.TabIndex = 2;
            this.PracticeButton.Text = "Practice";
            this.PracticeButton.UseVisualStyleBackColor = true;
            this.PracticeButton.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(416, 229);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(503, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewScoresButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.LessonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainWindow";
            this.Text = "Spelling Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LessonButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button ViewScoresButton;
        private System.Windows.Forms.Button PracticeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

