namespace TmLms.UserForms
{
    partial class StudentForm
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
            this.menuBox = new System.Windows.Forms.GroupBox();
            this.moduleSelectorBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.courseSelectorBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moduleViewBox = new System.Windows.Forms.TextBox();
            this.courseViewBox = new System.Windows.Forms.TextBox();
            this.menuBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // menuBox
            // 
            this.menuBox.Controls.Add(this.moduleSelectorBox);
            this.menuBox.Controls.Add(this.label6);
            this.menuBox.Controls.Add(this.courseSelectorBox);
            this.menuBox.Controls.Add(this.label5);
            this.menuBox.Controls.Add(this.dateTimeBox);
            this.menuBox.Controls.Add(this.label2);
            this.menuBox.Location = new System.Drawing.Point(12, 22);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(423, 537);
            this.menuBox.TabIndex = 1;
            this.menuBox.TabStop = false;
            this.menuBox.Text = "Main Menu";
            // 
            // moduleSelectorBox
            // 
            this.moduleSelectorBox.FormattingEnabled = true;
            this.moduleSelectorBox.Location = new System.Drawing.Point(6, 275);
            this.moduleSelectorBox.Name = "moduleSelectorBox";
            this.moduleSelectorBox.Size = new System.Drawing.Size(411, 23);
            this.moduleSelectorBox.TabIndex = 5;
            this.moduleSelectorBox.SelectedIndexChanged += new System.EventHandler(this.moduleSelectorBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select Module (Will Load when you select a Course)";
            // 
            // courseSelectorBox
            // 
            this.courseSelectorBox.FormattingEnabled = true;
            this.courseSelectorBox.Location = new System.Drawing.Point(6, 190);
            this.courseSelectorBox.Name = "courseSelectorBox";
            this.courseSelectorBox.Size = new System.Drawing.Size(411, 23);
            this.courseSelectorBox.TabIndex = 3;
            this.courseSelectorBox.SelectedIndexChanged += new System.EventHandler(this.courseSelectorBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Course";
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Location = new System.Drawing.Point(6, 38);
            this.dateTimeBox.Multiline = true;
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.ReadOnly = true;
            this.dateTimeBox.Size = new System.Drawing.Size(411, 72);
            this.dateTimeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Today\'s Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.moduleViewBox);
            this.groupBox1.Controls.Add(this.courseViewBox);
            this.groupBox1.Location = new System.Drawing.Point(441, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 537);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Details";
            // 
            // moduleViewBox
            // 
            this.moduleViewBox.Location = new System.Drawing.Point(6, 284);
            this.moduleViewBox.Multiline = true;
            this.moduleViewBox.Name = "moduleViewBox";
            this.moduleViewBox.ReadOnly = true;
            this.moduleViewBox.Size = new System.Drawing.Size(411, 183);
            this.moduleViewBox.TabIndex = 1;
            // 
            // courseViewBox
            // 
            this.courseViewBox.Location = new System.Drawing.Point(6, 50);
            this.courseViewBox.Multiline = true;
            this.courseViewBox.Name = "courseViewBox";
            this.courseViewBox.ReadOnly = true;
            this.courseViewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.courseViewBox.Size = new System.Drawing.Size(411, 163);
            this.courseViewBox.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuBox.ResumeLayout(false);
            this.menuBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox menuBox;
        private ComboBox moduleSelectorBox;
        private Label label6;
        private ComboBox courseSelectorBox;
        private Label label5;
        private TextBox dateTimeBox;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox moduleViewBox;
        private TextBox courseViewBox;
    }
}