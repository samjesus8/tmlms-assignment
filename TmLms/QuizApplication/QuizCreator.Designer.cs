namespace TmLms.QuizApplication
{
    partial class QuizCreator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToFButton = new System.Windows.Forms.Button();
            this.MultiChoiceButton = new System.Windows.Forms.Button();
            this.MultiAnswerButton = new System.Windows.Forms.Button();
            this.EssayButton = new System.Windows.Forms.Button();
            this.ShortAnswerButton = new System.Windows.Forms.Button();
            this.MatchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Creator";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 238);
            this.panel1.TabIndex = 1;
            // 
            // ToFButton
            // 
            this.ToFButton.Location = new System.Drawing.Point(6, 22);
            this.ToFButton.Name = "ToFButton";
            this.ToFButton.Size = new System.Drawing.Size(108, 56);
            this.ToFButton.TabIndex = 2;
            this.ToFButton.Text = "True Or False";
            this.ToFButton.UseVisualStyleBackColor = true;
            this.ToFButton.Click += new System.EventHandler(this.ToFButton_Click);
            // 
            // MultiChoiceButton
            // 
            this.MultiChoiceButton.Location = new System.Drawing.Point(6, 84);
            this.MultiChoiceButton.Name = "MultiChoiceButton";
            this.MultiChoiceButton.Size = new System.Drawing.Size(108, 56);
            this.MultiChoiceButton.TabIndex = 3;
            this.MultiChoiceButton.Text = "Multi-Choice";
            this.MultiChoiceButton.UseVisualStyleBackColor = true;
            this.MultiChoiceButton.Click += new System.EventHandler(this.MultiChoiceButton_Click);
            // 
            // MultiAnswerButton
            // 
            this.MultiAnswerButton.Location = new System.Drawing.Point(120, 22);
            this.MultiAnswerButton.Name = "MultiAnswerButton";
            this.MultiAnswerButton.Size = new System.Drawing.Size(108, 56);
            this.MultiAnswerButton.TabIndex = 4;
            this.MultiAnswerButton.Text = "Multi-Answer";
            this.MultiAnswerButton.UseVisualStyleBackColor = true;
            this.MultiAnswerButton.Click += new System.EventHandler(this.MultiAnswerButton_Click);
            // 
            // EssayButton
            // 
            this.EssayButton.Location = new System.Drawing.Point(120, 84);
            this.EssayButton.Name = "EssayButton";
            this.EssayButton.Size = new System.Drawing.Size(108, 56);
            this.EssayButton.TabIndex = 5;
            this.EssayButton.Text = "Essay";
            this.EssayButton.UseVisualStyleBackColor = true;
            this.EssayButton.Click += new System.EventHandler(this.EssayButton_Click);
            // 
            // ShortAnswerButton
            // 
            this.ShortAnswerButton.Location = new System.Drawing.Point(234, 22);
            this.ShortAnswerButton.Name = "ShortAnswerButton";
            this.ShortAnswerButton.Size = new System.Drawing.Size(108, 56);
            this.ShortAnswerButton.TabIndex = 6;
            this.ShortAnswerButton.Text = "Short Answer";
            this.ShortAnswerButton.UseVisualStyleBackColor = true;
            this.ShortAnswerButton.Click += new System.EventHandler(this.ShortAnswerButton_Click);
            // 
            // MatchButton
            // 
            this.MatchButton.Location = new System.Drawing.Point(234, 84);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(108, 56);
            this.MatchButton.TabIndex = 7;
            this.MatchButton.Text = "Match";
            this.MatchButton.UseVisualStyleBackColor = true;
            this.MatchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToFButton);
            this.groupBox1.Controls.Add(this.MatchButton);
            this.groupBox1.Controls.Add(this.MultiChoiceButton);
            this.groupBox1.Controls.Add(this.ShortAnswerButton);
            this.groupBox1.Controls.Add(this.MultiAnswerButton);
            this.groupBox1.Controls.Add(this.EssayButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Controls.Add(this.NextButton);
            this.groupBox2.Controls.Add(this.PreviousButton);
            this.groupBox2.Location = new System.Drawing.Point(369, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 151);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(305, 84);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 56);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(120, 22);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(108, 56);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(6, 22);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(108, 56);
            this.PreviousButton.TabIndex = 3;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // QuizCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "QuizCreator";
            this.Text = "QuizCreator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button ToFButton;
        private Button MultiChoiceButton;
        private Button MultiAnswerButton;
        private Button EssayButton;
        private Button ShortAnswerButton;
        private Button MatchButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button SaveButton;
        private Button NextButton;
        private Button PreviousButton;
    }
}