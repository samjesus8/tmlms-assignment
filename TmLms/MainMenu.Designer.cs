namespace TmLms
{
    partial class MainMenu
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
            this.smsButton = new System.Windows.Forms.Button();
            this.quizButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // smsButton
            // 
            this.smsButton.Location = new System.Drawing.Point(210, 196);
            this.smsButton.Name = "smsButton";
            this.smsButton.Size = new System.Drawing.Size(182, 84);
            this.smsButton.TabIndex = 1;
            this.smsButton.Text = "Student Management System";
            this.smsButton.UseVisualStyleBackColor = true;
            this.smsButton.Click += new System.EventHandler(this.smsButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.Location = new System.Drawing.Point(419, 196);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(182, 84);
            this.quizButton.TabIndex = 2;
            this.quizButton.Text = "Quiz Generator";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(241, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "SamuelJesuthas V1.0 ALPHA BETA GAMMA OMEGA";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.smsButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button smsButton;
        private Button quizButton;
        private Label label2;
    }
}