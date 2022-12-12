namespace TmLms.UserForms
{
    partial class InstructorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creditsBox1 = new System.Windows.Forms.ComboBox();
            this.adminListBox = new System.Windows.Forms.CheckedListBox();
            this.instructorListBox1 = new System.Windows.Forms.CheckedListBox();
            this.moduleNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.courseSelectorBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moduleDescriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createModuleButton = new System.Windows.Forms.Button();
            this.deleteModuleButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditsBox1);
            this.groupBox1.Controls.Add(this.adminListBox);
            this.groupBox1.Controls.Add(this.instructorListBox1);
            this.groupBox1.Controls.Add(this.moduleNameBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.courseSelectorBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.studentListBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.moduleDescriptionBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.createModuleButton);
            this.groupBox1.Controls.Add(this.deleteModuleButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(400, 651);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Creator";
            // 
            // creditsBox1
            // 
            this.creditsBox1.FormattingEnabled = true;
            this.creditsBox1.Items.AddRange(new object[] {
            "20",
            "40",
            "60"});
            this.creditsBox1.Location = new System.Drawing.Point(266, 395);
            this.creditsBox1.Name = "creditsBox1";
            this.creditsBox1.Size = new System.Drawing.Size(110, 23);
            this.creditsBox1.TabIndex = 26;
            // 
            // adminListBox
            // 
            this.adminListBox.FormattingEnabled = true;
            this.adminListBox.Location = new System.Drawing.Point(7, 171);
            this.adminListBox.Name = "adminListBox";
            this.adminListBox.Size = new System.Drawing.Size(370, 76);
            this.adminListBox.TabIndex = 25;
            // 
            // instructorListBox1
            // 
            this.instructorListBox1.FormattingEnabled = true;
            this.instructorListBox1.Location = new System.Drawing.Point(7, 271);
            this.instructorListBox1.Name = "instructorListBox1";
            this.instructorListBox1.Size = new System.Drawing.Size(369, 94);
            this.instructorListBox1.TabIndex = 24;
            // 
            // moduleNameBox
            // 
            this.moduleNameBox.Location = new System.Drawing.Point(6, 394);
            this.moduleNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moduleNameBox.Name = "moduleNameBox";
            this.moduleNameBox.Size = new System.Drawing.Size(214, 23);
            this.moduleNameBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Module Name";
            // 
            // courseSelectorBox
            // 
            this.courseSelectorBox.FormattingEnabled = true;
            this.courseSelectorBox.Location = new System.Drawing.Point(5, 129);
            this.courseSelectorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseSelectorBox.Name = "courseSelectorBox";
            this.courseSelectorBox.Size = new System.Drawing.Size(372, 23);
            this.courseSelectorBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Select Course";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(7, 521);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(369, 112);
            this.studentListBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Credits";
            // 
            // moduleDescriptionBox
            // 
            this.moduleDescriptionBox.Location = new System.Drawing.Point(6, 443);
            this.moduleDescriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moduleDescriptionBox.Multiline = true;
            this.moduleDescriptionBox.Name = "moduleDescriptionBox";
            this.moduleDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.moduleDescriptionBox.Size = new System.Drawing.Size(370, 61);
            this.moduleDescriptionBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Module Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Instructor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Administrator";
            // 
            // createModuleButton
            // 
            this.createModuleButton.Location = new System.Drawing.Point(6, 20);
            this.createModuleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createModuleButton.Name = "createModuleButton";
            this.createModuleButton.Size = new System.Drawing.Size(160, 82);
            this.createModuleButton.TabIndex = 1;
            this.createModuleButton.Text = "Create Module";
            this.createModuleButton.UseVisualStyleBackColor = true;
            this.createModuleButton.Click += new System.EventHandler(this.createModuleButton_Click_1);
            // 
            // deleteModuleButton
            // 
            this.deleteModuleButton.Location = new System.Drawing.Point(179, 20);
            this.deleteModuleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteModuleButton.Name = "deleteModuleButton";
            this.deleteModuleButton.Size = new System.Drawing.Size(160, 82);
            this.deleteModuleButton.TabIndex = 2;
            this.deleteModuleButton.Text = "Delete Module";
            this.deleteModuleButton.UseVisualStyleBackColor = true;
            this.deleteModuleButton.Click += new System.EventHandler(this.deleteModuleButton_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputBox1);
            this.groupBox2.Location = new System.Drawing.Point(412, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(458, 651);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // outputBox1
            // 
            this.outputBox1.Location = new System.Drawing.Point(5, 20);
            this.outputBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputBox1.Multiline = true;
            this.outputBox1.Name = "outputBox1";
            this.outputBox1.ReadOnly = true;
            this.outputBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox1.Size = new System.Drawing.Size(448, 627);
            this.outputBox1.TabIndex = 0;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox creditsBox1;
        private CheckedListBox adminListBox;
        private CheckedListBox instructorListBox1;
        private TextBox moduleNameBox;
        private Label label10;
        private ComboBox courseSelectorBox;
        private Label label8;
        private CheckedListBox studentListBox;
        private Label label5;
        private Label label3;
        private TextBox moduleDescriptionBox;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button createModuleButton;
        private Button deleteModuleButton;
        private GroupBox groupBox2;
        private TextBox outputBox1;
    }
}