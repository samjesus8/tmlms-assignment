namespace TmLms.QuizApplication
{
    partial class QuizBuilderMenu
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
            this.createButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Builder";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(145, 196);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(167, 94);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Quiz";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(318, 196);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(167, 94);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play Quiz";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(491, 196);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(167, 94);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View Quizzes";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // QuizBuilderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label1);
            this.Name = "QuizBuilderMenu";
            this.Text = "Quiz Builder - Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button createButton;
        private Button playButton;
        private Button viewButton;
    }
}