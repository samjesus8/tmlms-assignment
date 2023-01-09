namespace MultiChoicePlay
{
    partial class MulitChoicePlay
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Question";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(17, 43);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(740, 49);
            this.inputBox.TabIndex = 6;
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(17, 98);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(98, 53);
            this.option1Button.TabIndex = 8;
            this.option1Button.UseVisualStyleBackColor = true;
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(136, 98);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(98, 53);
            this.option2Button.TabIndex = 9;
            this.option2Button.UseVisualStyleBackColor = true;
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(250, 98);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(98, 53);
            this.option3Button.TabIndex = 10;
            this.option3Button.UseVisualStyleBackColor = true;
            // 
            // option4Button
            // 
            this.option4Button.Location = new System.Drawing.Point(368, 98);
            this.option4Button.Name = "option4Button";
            this.option4Button.Size = new System.Drawing.Size(98, 53);
            this.option4Button.TabIndex = 11;
            this.option4Button.UseVisualStyleBackColor = true;
            // 
            // MulitChoicePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.option4Button);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Name = "MulitChoicePlay";
            this.Size = new System.Drawing.Size(770, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox inputBox;
        public System.Windows.Forms.Button option1Button;
        public System.Windows.Forms.Button option2Button;
        public System.Windows.Forms.Button option3Button;
        public System.Windows.Forms.Button option4Button;
    }
}
