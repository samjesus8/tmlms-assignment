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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadSQuestionButton = new System.Windows.Forms.Button();
            this.loadMCQuestionButton = new System.Windows.Forms.Button();
            this.loadMAQuestionButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.loadToFQuestionButton.Location = new System.Drawing.Point(6, 22);
            this.loadToFQuestionButton.Name = "loadToFQuestionButton";
            this.loadToFQuestionButton.Size = new System.Drawing.Size(123, 49);
            this.loadToFQuestionButton.TabIndex = 3;
            this.loadToFQuestionButton.Text = "True or False Questions";
            this.loadToFQuestionButton.UseVisualStyleBackColor = true;
            this.loadToFQuestionButton.Click += new System.EventHandler(this.loadQuestionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadMAQuestionButton);
            this.groupBox1.Controls.Add(this.loadMCQuestionButton);
            this.groupBox1.Controls.Add(this.loadSQuestionButton);
            this.groupBox1.Controls.Add(this.loadToFQuestionButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Type";
            // 
            // loadSQuestionButton
            // 
            this.loadSQuestionButton.Location = new System.Drawing.Point(135, 22);
            this.loadSQuestionButton.Name = "loadSQuestionButton";
            this.loadSQuestionButton.Size = new System.Drawing.Size(123, 49);
            this.loadSQuestionButton.TabIndex = 4;
            this.loadSQuestionButton.Text = "Short Answer Questions";
            this.loadSQuestionButton.UseVisualStyleBackColor = true;
            this.loadSQuestionButton.Click += new System.EventHandler(this.loadSQuestionButton_Click);
            // 
            // loadMCQuestionButton
            // 
            this.loadMCQuestionButton.Location = new System.Drawing.Point(6, 77);
            this.loadMCQuestionButton.Name = "loadMCQuestionButton";
            this.loadMCQuestionButton.Size = new System.Drawing.Size(123, 49);
            this.loadMCQuestionButton.TabIndex = 5;
            this.loadMCQuestionButton.Text = "Multi Choice Questions";
            this.loadMCQuestionButton.UseVisualStyleBackColor = true;
            this.loadMCQuestionButton.Click += new System.EventHandler(this.loadMCQuestionButton_Click);
            // 
            // loadMAQuestionButton
            // 
            this.loadMAQuestionButton.Location = new System.Drawing.Point(135, 77);
            this.loadMAQuestionButton.Name = "loadMAQuestionButton";
            this.loadMAQuestionButton.Size = new System.Drawing.Size(123, 49);
            this.loadMAQuestionButton.TabIndex = 6;
            this.loadMAQuestionButton.Text = "Multi Answer Questions";
            this.loadMAQuestionButton.UseVisualStyleBackColor = true;
            this.loadMAQuestionButton.Click += new System.EventHandler(this.loadMAQuestionButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nextButton);
            this.groupBox2.Controls.Add(this.previousButton);
            this.groupBox2.Location = new System.Drawing.Point(288, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(6, 22);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(123, 49);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(135, 22);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(123, 49);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // QuizPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QuizPlayer";
            this.Text = "QuizPlayer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button loadToFQuestionButton;
        private GroupBox groupBox1;
        private Button loadMAQuestionButton;
        private Button loadMCQuestionButton;
        private Button loadSQuestionButton;
        private GroupBox groupBox2;
        private Button nextButton;
        private Button previousButton;
    }
}