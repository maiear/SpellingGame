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
            this.Testbutton1 = new System.Windows.Forms.Button();
            this.ViewScoresbutton1 = new System.Windows.Forms.Button();
            this.Practicebutton1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 56);
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
            // Testbutton1
            // 
            this.Testbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testbutton1.Location = new System.Drawing.Point(69, 275);
            this.Testbutton1.Name = "Testbutton1";
            this.Testbutton1.Size = new System.Drawing.Size(146, 46);
            this.Testbutton1.TabIndex = 3;
            this.Testbutton1.Text = "Test";
            this.Testbutton1.UseVisualStyleBackColor = true;
            this.Testbutton1.Click += new System.EventHandler(this.Testbutton1_Click);
            // 
            // ViewScoresbutton1
            // 
            this.ViewScoresbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewScoresbutton1.Location = new System.Drawing.Point(271, 275);
            this.ViewScoresbutton1.Name = "ViewScoresbutton1";
            this.ViewScoresbutton1.Size = new System.Drawing.Size(146, 46);
            this.ViewScoresbutton1.TabIndex = 4;
            this.ViewScoresbutton1.Text = "View Scores";
            this.ViewScoresbutton1.UseVisualStyleBackColor = true;
            this.ViewScoresbutton1.Click += new System.EventHandler(this.ViewScoresbutton1_Click);
            // 
            // Practicebutton1
            // 
            this.Practicebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practicebutton1.Location = new System.Drawing.Point(271, 192);
            this.Practicebutton1.Name = "Practicebutton1";
            this.Practicebutton1.Size = new System.Drawing.Size(146, 46);
            this.Practicebutton1.TabIndex = 2;
            this.Practicebutton1.Text = "Practice";
            this.Practicebutton1.UseVisualStyleBackColor = true;
            this.Practicebutton1.Click += new System.EventHandler(this.Practicebutton1_Click);
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
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(503, 414);
            this.Controls.Add(this.ViewScoresbutton1);
            this.Controls.Add(this.Testbutton1);
            this.Controls.Add(this.Practicebutton1);
            this.Controls.Add(this.LessonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LessonButton;
        private System.Windows.Forms.Button Testbutton1;
        private System.Windows.Forms.Button ViewScoresbutton1;
        private System.Windows.Forms.Button Practicebutton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

