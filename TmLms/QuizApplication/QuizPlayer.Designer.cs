namespace TmLms.QuizApplication
{
    partial class QuizPlayer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadToFQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 238);
            this.panel1.TabIndex = 2;
            // 
            // loadToFQuestionButton
            // 
            this.loadToFQuestionButton.Location = new System.Drawing.Point(12, 256);
            this.loadToFQuestionButton.Name = "loadToFQuestionButton";
            this.loadToFQuestionButton.Size = new System.Drawing.Size(123, 49);
            this.loadToFQuestionButton.TabIndex = 3;
            this.loadToFQuestionButton.Text = "Generate Random Question";
            this.loadToFQuestionButton.UseVisualStyleBackColor = true;
            this.loadToFQuestionButton.Click += new System.EventHandler(this.loadQuestionButton_Click);
            // 
            // QuizPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadToFQuestionButton);
            this.Controls.Add(this.panel1);
            this.Name = "QuizPlayer";
            this.Text = "QuizPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button loadToFQuestionButton;
    }
}