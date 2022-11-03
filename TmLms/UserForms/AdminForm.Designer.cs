namespace TmLms.UserForms
{
    partial class AdminForm
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
            this.createCourseButton = new System.Windows.Forms.Button();
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.courseCreatorBox = new System.Windows.Forms.GroupBox();
            this.instructorBox = new System.Windows.Forms.ComboBox();
            this.creditsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseDescriptionBox = new System.Windows.Forms.TextBox();
            this.courseDescriptionLabel = new System.Windows.Forms.Label();
            this.courseLevelBox = new System.Windows.Forms.ComboBox();
            this.courseLengthLabel = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.courseDisplayBox = new System.Windows.Forms.TextBox();
            this.courseManager = new System.Windows.Forms.CheckedListBox();
            this.adminTabInterface = new System.Windows.Forms.TabControl();
            this.courseTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moduleNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.courseSelectorBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.instructorBox1 = new System.Windows.Forms.ComboBox();
            this.adminBox = new System.Windows.Forms.ComboBox();
            this.creditsBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moduleDescriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createModuleButton = new System.Windows.Forms.Button();
            this.deleteModuleButton = new System.Windows.Forms.Button();
            this.courseCreatorBox.SuspendLayout();
            this.courseListBox.SuspendLayout();
            this.adminTabInterface.SuspendLayout();
            this.courseTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Interface";
            // 
            // createCourseButton
            // 
            this.createCourseButton.Location = new System.Drawing.Point(6, 26);
            this.createCourseButton.Name = "createCourseButton";
            this.createCourseButton.Size = new System.Drawing.Size(183, 109);
            this.createCourseButton.TabIndex = 1;
            this.createCourseButton.Text = "Create Course";
            this.createCourseButton.UseVisualStyleBackColor = true;
            this.createCourseButton.Click += new System.EventHandler(this.createCourseButton_Click);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Location = new System.Drawing.Point(195, 26);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(183, 109);
            this.deleteCourseButton.TabIndex = 2;
            this.deleteCourseButton.Text = "Delete Course";
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
            // 
            // courseCreatorBox
            // 
            this.courseCreatorBox.Controls.Add(this.instructorBox);
            this.courseCreatorBox.Controls.Add(this.creditsBox);
            this.courseCreatorBox.Controls.Add(this.label2);
            this.courseCreatorBox.Controls.Add(this.courseDescriptionBox);
            this.courseCreatorBox.Controls.Add(this.courseDescriptionLabel);
            this.courseCreatorBox.Controls.Add(this.courseLevelBox);
            this.courseCreatorBox.Controls.Add(this.courseLengthLabel);
            this.courseCreatorBox.Controls.Add(this.courseNameBox);
            this.courseCreatorBox.Controls.Add(this.courseNameLabel);
            this.courseCreatorBox.Controls.Add(this.instructorLabel);
            this.courseCreatorBox.Controls.Add(this.createCourseButton);
            this.courseCreatorBox.Controls.Add(this.deleteCourseButton);
            this.courseCreatorBox.Location = new System.Drawing.Point(6, 6);
            this.courseCreatorBox.Name = "courseCreatorBox";
            this.courseCreatorBox.Size = new System.Drawing.Size(508, 701);
            this.courseCreatorBox.TabIndex = 3;
            this.courseCreatorBox.TabStop = false;
            this.courseCreatorBox.Text = "Course Creator";
            // 
            // instructorBox
            // 
            this.instructorBox.FormattingEnabled = true;
            this.instructorBox.Location = new System.Drawing.Point(4, 179);
            this.instructorBox.Name = "instructorBox";
            this.instructorBox.Size = new System.Drawing.Size(362, 28);
            this.instructorBox.TabIndex = 16;
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(176, 310);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.ReadOnly = true;
            this.creditsBox.Size = new System.Drawing.Size(125, 27);
            this.creditsBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Credits";
            // 
            // courseDescriptionBox
            // 
            this.courseDescriptionBox.Location = new System.Drawing.Point(6, 375);
            this.courseDescriptionBox.Multiline = true;
            this.courseDescriptionBox.Name = "courseDescriptionBox";
            this.courseDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.courseDescriptionBox.Size = new System.Drawing.Size(475, 171);
            this.courseDescriptionBox.TabIndex = 10;
            // 
            // courseDescriptionLabel
            // 
            this.courseDescriptionLabel.AutoSize = true;
            this.courseDescriptionLabel.Location = new System.Drawing.Point(6, 352);
            this.courseDescriptionLabel.Name = "courseDescriptionLabel";
            this.courseDescriptionLabel.Size = new System.Drawing.Size(134, 20);
            this.courseDescriptionLabel.TabIndex = 9;
            this.courseDescriptionLabel.Text = "Course Description";
            // 
            // courseLevelBox
            // 
            this.courseLevelBox.FormattingEnabled = true;
            this.courseLevelBox.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.courseLevelBox.Location = new System.Drawing.Point(6, 309);
            this.courseLevelBox.Name = "courseLevelBox";
            this.courseLevelBox.Size = new System.Drawing.Size(151, 28);
            this.courseLevelBox.TabIndex = 8;
            // 
            // courseLengthLabel
            // 
            this.courseLengthLabel.AutoSize = true;
            this.courseLengthLabel.Location = new System.Drawing.Point(6, 286);
            this.courseLengthLabel.Name = "courseLengthLabel";
            this.courseLengthLabel.Size = new System.Drawing.Size(92, 20);
            this.courseLengthLabel.TabIndex = 7;
            this.courseLengthLabel.Text = "Course Level";
            // 
            // courseNameBox
            // 
            this.courseNameBox.Location = new System.Drawing.Point(6, 243);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(360, 27);
            this.courseNameBox.TabIndex = 6;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(6, 220);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(98, 20);
            this.courseNameLabel.TabIndex = 5;
            this.courseNameLabel.Text = "Course Name";
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Location = new System.Drawing.Point(6, 156);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(115, 20);
            this.instructorLabel.TabIndex = 4;
            this.instructorLabel.Text = "Instructor Name";
            // 
            // courseListBox
            // 
            this.courseListBox.Controls.Add(this.label9);
            this.courseListBox.Controls.Add(this.viewButton);
            this.courseListBox.Controls.Add(this.courseDisplayBox);
            this.courseListBox.Controls.Add(this.courseManager);
            this.courseListBox.Location = new System.Drawing.Point(520, 6);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(484, 701);
            this.courseListBox.TabIndex = 4;
            this.courseListBox.TabStop = false;
            this.courseListBox.Text = "List of Courses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Course Details";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(346, 277);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(132, 44);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "View Course";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // courseDisplayBox
            // 
            this.courseDisplayBox.Location = new System.Drawing.Point(6, 375);
            this.courseDisplayBox.Multiline = true;
            this.courseDisplayBox.Name = "courseDisplayBox";
            this.courseDisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.courseDisplayBox.Size = new System.Drawing.Size(472, 295);
            this.courseDisplayBox.TabIndex = 1;
            // 
            // courseManager
            // 
            this.courseManager.FormattingEnabled = true;
            this.courseManager.Location = new System.Drawing.Point(6, 26);
            this.courseManager.Name = "courseManager";
            this.courseManager.Size = new System.Drawing.Size(472, 246);
            this.courseManager.TabIndex = 0;
            // 
            // adminTabInterface
            // 
            this.adminTabInterface.Controls.Add(this.courseTab);
            this.adminTabInterface.Controls.Add(this.tabPage2);
            this.adminTabInterface.Location = new System.Drawing.Point(12, 35);
            this.adminTabInterface.Name = "adminTabInterface";
            this.adminTabInterface.SelectedIndex = 0;
            this.adminTabInterface.Size = new System.Drawing.Size(1018, 746);
            this.adminTabInterface.TabIndex = 5;
            // 
            // courseTab
            // 
            this.courseTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseTab.Controls.Add(this.courseCreatorBox);
            this.courseTab.Controls.Add(this.courseListBox);
            this.courseTab.Location = new System.Drawing.Point(4, 29);
            this.courseTab.Name = "courseTab";
            this.courseTab.Padding = new System.Windows.Forms.Padding(3);
            this.courseTab.Size = new System.Drawing.Size(1010, 713);
            this.courseTab.TabIndex = 0;
            this.courseTab.Text = "Course";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1010, 713);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Module";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputBox1);
            this.groupBox2.Location = new System.Drawing.Point(480, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 704);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // outputBox1
            // 
            this.outputBox1.Location = new System.Drawing.Point(6, 26);
            this.outputBox1.Multiline = true;
            this.outputBox1.Name = "outputBox1";
            this.outputBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox1.Size = new System.Drawing.Size(512, 420);
            this.outputBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moduleNameBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.courseSelectorBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.studentListBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.instructorBox1);
            this.groupBox1.Controls.Add(this.adminBox);
            this.groupBox1.Controls.Add(this.creditsBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.moduleDescriptionBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.createModuleButton);
            this.groupBox1.Controls.Add(this.deleteModuleButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 704);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Creator";
            // 
            // moduleNameBox
            // 
            this.moduleNameBox.Location = new System.Drawing.Point(8, 361);
            this.moduleNameBox.Name = "moduleNameBox";
            this.moduleNameBox.Size = new System.Drawing.Size(244, 27);
            this.moduleNameBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Module Name";
            // 
            // courseSelectorBox
            // 
            this.courseSelectorBox.FormattingEnabled = true;
            this.courseSelectorBox.Location = new System.Drawing.Point(6, 172);
            this.courseSelectorBox.Name = "courseSelectorBox";
            this.courseSelectorBox.Size = new System.Drawing.Size(424, 28);
            this.courseSelectorBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Select Course";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(9, 531);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(421, 158);
            this.studentListBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Students";
            // 
            // instructorBox1
            // 
            this.instructorBox1.FormattingEnabled = true;
            this.instructorBox1.Location = new System.Drawing.Point(6, 294);
            this.instructorBox1.Name = "instructorBox1";
            this.instructorBox1.Size = new System.Drawing.Size(424, 28);
            this.instructorBox1.TabIndex = 17;
            // 
            // adminBox
            // 
            this.adminBox.FormattingEnabled = true;
            this.adminBox.Location = new System.Drawing.Point(6, 230);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(424, 28);
            this.adminBox.TabIndex = 16;
            // 
            // creditsBox1
            // 
            this.creditsBox1.Location = new System.Drawing.Point(305, 361);
            this.creditsBox1.Name = "creditsBox1";
            this.creditsBox1.Size = new System.Drawing.Size(125, 27);
            this.creditsBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Credits";
            // 
            // moduleDescriptionBox
            // 
            this.moduleDescriptionBox.Location = new System.Drawing.Point(8, 426);
            this.moduleDescriptionBox.Multiline = true;
            this.moduleDescriptionBox.Name = "moduleDescriptionBox";
            this.moduleDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.moduleDescriptionBox.Size = new System.Drawing.Size(422, 80);
            this.moduleDescriptionBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Module Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Instructor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Administrator";
            // 
            // createModuleButton
            // 
            this.createModuleButton.Location = new System.Drawing.Point(7, 26);
            this.createModuleButton.Name = "createModuleButton";
            this.createModuleButton.Size = new System.Drawing.Size(183, 109);
            this.createModuleButton.TabIndex = 1;
            this.createModuleButton.Text = "Create Module";
            this.createModuleButton.UseVisualStyleBackColor = true;
            this.createModuleButton.Click += new System.EventHandler(this.createModuleButton_Click);
            // 
            // deleteModuleButton
            // 
            this.deleteModuleButton.Location = new System.Drawing.Point(205, 26);
            this.deleteModuleButton.Name = "deleteModuleButton";
            this.deleteModuleButton.Size = new System.Drawing.Size(183, 109);
            this.deleteModuleButton.TabIndex = 2;
            this.deleteModuleButton.Text = "Delete Module";
            this.deleteModuleButton.UseVisualStyleBackColor = true;
            this.deleteModuleButton.Click += new System.EventHandler(this.deleteModuleButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 793);
            this.Controls.Add(this.adminTabInterface);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminForm";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.courseCreatorBox.ResumeLayout(false);
            this.courseCreatorBox.PerformLayout();
            this.courseListBox.ResumeLayout(false);
            this.courseListBox.PerformLayout();
            this.adminTabInterface.ResumeLayout(false);
            this.courseTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button createCourseButton;
        private Button deleteCourseButton;
        private GroupBox courseCreatorBox;
        private ComboBox courseLevelBox;
        private Label courseLengthLabel;
        private TextBox courseNameBox;
        private Label courseNameLabel;
        private Label instructorLabel;
        private GroupBox courseListBox;
        private TextBox courseDescriptionBox;
        private Label courseDescriptionLabel;
        private TextBox creditsBox;
        private Label label2;
        private CheckedListBox courseManager;
        private ComboBox instructorBox;
        private Button viewButton;
        private TextBox courseDisplayBox;
        private TabControl adminTabInterface;
        private TabPage courseTab;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private ComboBox instructorBox1;
        private ComboBox adminBox;
        private TextBox creditsBox1;
        private Label label3;
        private TextBox moduleDescriptionBox;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button createModuleButton;
        private Button deleteModuleButton;
        private Label label9;
        private ComboBox courseSelectorBox;
        private Label label8;
        private CheckedListBox studentListBox;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox outputBox1;
        private TextBox moduleNameBox;
        private Label label10;
    }
}