namespace SpellingGame
{
    partial class LessonsForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Selectbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spelling Rules";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(63, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(511, 277);
            this.listBox1.TabIndex = 1;
            // 
            // Selectbutton
            // 
            this.Selectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectbutton.Location = new System.Drawing.Point(391, 467);
            this.Selectbutton.Name = "Selectbutton";
            this.Selectbutton.Size = new System.Drawing.Size(151, 40);
            this.Selectbutton.TabIndex = 2;
            this.Selectbutton.Text = "Select";
            this.Selectbutton.UseVisualStyleBackColor = true;
            // 
            // LessonsForm
            // 
            this.ClientSize = new System.Drawing.Size(633, 552);
            this.Controls.Add(this.Selectbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "LessonsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Selectbutton;
    }
}