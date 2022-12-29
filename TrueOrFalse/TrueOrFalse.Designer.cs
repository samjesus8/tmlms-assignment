namespace TrueOrFalse
{
    partial class TrueOrFalseControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trueBox = new System.Windows.Forms.CheckBox();
            this.falseBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "True Or False Question";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(16, 55);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(740, 49);
            this.inputBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your question here";
            // 
            // trueBox
            // 
            this.trueBox.AutoSize = true;
            this.trueBox.Location = new System.Drawing.Point(16, 134);
            this.trueBox.Name = "trueBox";
            this.trueBox.Size = new System.Drawing.Size(48, 17);
            this.trueBox.TabIndex = 3;
            this.trueBox.Text = "True";
            this.trueBox.UseVisualStyleBackColor = true;
            // 
            // falseBox
            // 
            this.falseBox.AutoSize = true;
            this.falseBox.Location = new System.Drawing.Point(71, 134);
            this.falseBox.Name = "falseBox";
            this.falseBox.Size = new System.Drawing.Size(51, 17);
            this.falseBox.TabIndex = 4;
            this.falseBox.Text = "False";
            this.falseBox.UseVisualStyleBackColor = true;
            // 
            // TrueOrFalseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.falseBox);
            this.Controls.Add(this.trueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "TrueOrFalseControl";
            this.Size = new System.Drawing.Size(770, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox trueBox;
        private System.Windows.Forms.CheckBox falseBox;
        public System.Windows.Forms.TextBox inputBox;
    }
}
