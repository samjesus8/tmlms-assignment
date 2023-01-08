namespace TrueOrFalse_Play_
{
    partial class ToF
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
            this.trueButton = new System.Windows.Forms.Button();
            this.falseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "True or False";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(15, 26);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(740, 49);
            this.inputBox.TabIndex = 3;
            // 
            // trueButton
            // 
            this.trueButton.Location = new System.Drawing.Point(18, 120);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(75, 45);
            this.trueButton.TabIndex = 5;
            this.trueButton.Text = "True";
            this.trueButton.UseVisualStyleBackColor = true;
            // 
            // falseButton
            // 
            this.falseButton.Location = new System.Drawing.Point(99, 120);
            this.falseButton.Name = "falseButton";
            this.falseButton.Size = new System.Drawing.Size(75, 45);
            this.falseButton.TabIndex = 6;
            this.falseButton.Text = "False";
            this.falseButton.UseVisualStyleBackColor = true;
            // 
            // ToF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.falseButton);
            this.Controls.Add(this.trueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Name = "ToF";
            this.Size = new System.Drawing.Size(770, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button trueButton;
        private System.Windows.Forms.Button falseButton;
    }
}
