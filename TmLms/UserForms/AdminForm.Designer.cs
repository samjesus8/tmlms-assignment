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
            this.deleteModuleButton = new System.Windows.Forms.Button();
            this.createModuleButton = new System.Windows.Forms.Button();
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
            this.viewButton = new System.Windows.Forms.Button();
            this.courseDisplayBox = new System.Windows.Forms.TextBox();
            this.courseManager = new System.Windows.Forms.CheckedListBox();
            this.courseCreatorBox.SuspendLayout();
            this.courseListBox.SuspendLayout();
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
            this.createCourseButton.Size = new System.Drawing.Size(183, 48);
            this.createCourseButton.TabIndex = 1;
            this.createCourseButton.Text = "Create Course";
            this.createCourseButton.UseVisualStyleBackColor = true;
            this.createCourseButton.Click += new System.EventHandler(this.createCourseButton_Click);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Location = new System.Drawing.Point(195, 26);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(183, 48);
            this.deleteCourseButton.TabIndex = 2;
            this.deleteCourseButton.Text = "Delete Course";
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
            // 
            // courseCreatorBox
            // 
            this.courseCreatorBox.Controls.Add(this.instructorBox);
            this.courseCreatorBox.Controls.Add(this.deleteModuleButton);
            this.courseCreatorBox.Controls.Add(this.createModuleButton);
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
            this.courseCreatorBox.Location = new System.Drawing.Point(8, 57);
            this.courseCreatorBox.Name = "courseCreatorBox";
            this.courseCreatorBox.Size = new System.Drawing.Size(398, 531);
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
            // deleteModuleButton
            // 
            this.deleteModuleButton.Location = new System.Drawing.Point(195, 80);
            this.deleteModuleButton.Name = "deleteModuleButton";
            this.deleteModuleButton.Size = new System.Drawing.Size(183, 48);
            this.deleteModuleButton.TabIndex = 15;
            this.deleteModuleButton.Text = "Delete Module";
            this.deleteModuleButton.UseVisualStyleBackColor = true;
            this.deleteModuleButton.Click += new System.EventHandler(this.deleteModuleButton_Click);
            // 
            // createModuleButton
            // 
            this.createModuleButton.Location = new System.Drawing.Point(6, 80);
            this.createModuleButton.Name = "createModuleButton";
            this.createModuleButton.Size = new System.Drawing.Size(183, 48);
            this.createModuleButton.TabIndex = 14;
            this.createModuleButton.Text = "Create Module";
            this.createModuleButton.UseVisualStyleBackColor = true;
            this.createModuleButton.Click += new System.EventHandler(this.createModuleButton_Click);
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
            this.courseDescriptionBox.Size = new System.Drawing.Size(360, 80);
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
            this.courseListBox.Controls.Add(this.viewButton);
            this.courseListBox.Controls.Add(this.courseDisplayBox);
            this.courseListBox.Controls.Add(this.courseManager);
            this.courseListBox.Location = new System.Drawing.Point(456, 57);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(446, 531);
            this.courseListBox.TabIndex = 4;
            this.courseListBox.TabStop = false;
            this.courseListBox.Text = "List of Courses";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(6, 275);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(94, 29);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // courseDisplayBox
            // 
            this.courseDisplayBox.Location = new System.Drawing.Point(6, 310);
            this.courseDisplayBox.Multiline = true;
            this.courseDisplayBox.Name = "courseDisplayBox";
            this.courseDisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.courseDisplayBox.Size = new System.Drawing.Size(434, 215);
            this.courseDisplayBox.TabIndex = 1;
            // 
            // courseManager
            // 
            this.courseManager.FormattingEnabled = true;
            this.courseManager.Location = new System.Drawing.Point(6, 26);
            this.courseManager.Name = "courseManager";
            this.courseManager.Size = new System.Drawing.Size(434, 246);
            this.courseManager.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.courseCreatorBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminForm";
            this.Text = "Admin Menu";
            this.courseCreatorBox.ResumeLayout(false);
            this.courseCreatorBox.PerformLayout();
            this.courseListBox.ResumeLayout(false);
            this.courseListBox.PerformLayout();
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
        private Button deleteModuleButton;
        private Button createModuleButton;
        private ComboBox instructorBox;
        private Button viewButton;
        private TextBox courseDisplayBox;
    }
}