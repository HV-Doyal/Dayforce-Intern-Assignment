namespace CourseEnrolmentSystem
{
    partial class CourseEnrolmentSystem
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
            this.DropdownMenubackground = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelGrade = new System.Windows.Forms.Label();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.GradeDropdownMenuFive = new System.Windows.Forms.ComboBox();
            this.GradeDropdownMenuThree = new System.Windows.Forms.ComboBox();
            this.GradeDropdownMenuTwo = new System.Windows.Forms.ComboBox();
            this.GradeDropdownMenuFour = new System.Windows.Forms.ComboBox();
            this.GradeDropdownMenuOne = new System.Windows.Forms.ComboBox();
            this.SubjectDropdownMenuFive = new System.Windows.Forms.ComboBox();
            this.SubjectDropdownMenuThree = new System.Windows.Forms.ComboBox();
            this.SubjectDropdownMenuTwo = new System.Windows.Forms.ComboBox();
            this.SubjectDropdownMenuFour = new System.Windows.Forms.ComboBox();
            this.SubjectDropdownMenuOne = new System.Windows.Forms.ComboBox();
            this.LabelAvailability = new System.Windows.Forms.Label();
            this.GetCourseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AvailableCourses = new System.Windows.Forms.TableLayoutPanel();
            this.DropdownMenubackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // DropdownMenubackground
            // 
            this.DropdownMenubackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.DropdownMenubackground.Controls.Add(this.LabelTitle);
            this.DropdownMenubackground.Controls.Add(this.LabelGrade);
            this.DropdownMenubackground.Controls.Add(this.LabelSubject);
            this.DropdownMenubackground.Controls.Add(this.GradeDropdownMenuFive);
            this.DropdownMenubackground.Controls.Add(this.GradeDropdownMenuThree);
            this.DropdownMenubackground.Controls.Add(this.GradeDropdownMenuTwo);
            this.DropdownMenubackground.Controls.Add(this.GradeDropdownMenuFour);
            this.DropdownMenubackground.Controls.Add(this.GradeDropdownMenuOne);
            this.DropdownMenubackground.Controls.Add(this.SubjectDropdownMenuFive);
            this.DropdownMenubackground.Controls.Add(this.SubjectDropdownMenuThree);
            this.DropdownMenubackground.Controls.Add(this.SubjectDropdownMenuTwo);
            this.DropdownMenubackground.Controls.Add(this.SubjectDropdownMenuFour);
            this.DropdownMenubackground.Controls.Add(this.SubjectDropdownMenuOne);
            this.DropdownMenubackground.Location = new System.Drawing.Point(2, 0);
            this.DropdownMenubackground.Name = "DropdownMenubackground";
            this.DropdownMenubackground.Padding = new System.Windows.Forms.Padding(5);
            this.DropdownMenubackground.Size = new System.Drawing.Size(498, 608);
            this.DropdownMenubackground.TabIndex = 0;
            this.DropdownMenubackground.Paint += new System.Windows.Forms.PaintEventHandler(this.DropdownMenubackground_Paint);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(58, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(391, 41);
            this.LabelTitle.TabIndex = 13;
            this.LabelTitle.Text = "Course Enrolment System";
            this.LabelTitle.Click += new System.EventHandler(this.LabelTitle_Click);
            // 
            // LabelGrade
            // 
            this.LabelGrade.AutoSize = true;
            this.LabelGrade.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGrade.ForeColor = System.Drawing.Color.White;
            this.LabelGrade.Location = new System.Drawing.Point(299, 89);
            this.LabelGrade.Name = "LabelGrade";
            this.LabelGrade.Size = new System.Drawing.Size(104, 41);
            this.LabelGrade.TabIndex = 12;
            this.LabelGrade.Text = "Grade";
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubject.ForeColor = System.Drawing.Color.White;
            this.LabelSubject.Location = new System.Drawing.Point(44, 89);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(131, 41);
            this.LabelSubject.TabIndex = 11;
            this.LabelSubject.Text = "Subject";
            // 
            // GradeDropdownMenuFive
            // 
            this.GradeDropdownMenuFive.FormattingEnabled = true;
            this.GradeDropdownMenuFive.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.GradeDropdownMenuFive.Location = new System.Drawing.Point(273, 531);
            this.GradeDropdownMenuFive.Name = "GradeDropdownMenuFive";
            this.GradeDropdownMenuFive.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuFive.TabIndex = 10;
            // 
            // GradeDropdownMenuThree
            // 
            this.GradeDropdownMenuThree.FormattingEnabled = true;
            this.GradeDropdownMenuThree.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.GradeDropdownMenuThree.Location = new System.Drawing.Point(273, 347);
            this.GradeDropdownMenuThree.Name = "GradeDropdownMenuThree";
            this.GradeDropdownMenuThree.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuThree.TabIndex = 9;
            // 
            // GradeDropdownMenuTwo
            // 
            this.GradeDropdownMenuTwo.FormattingEnabled = true;
            this.GradeDropdownMenuTwo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.GradeDropdownMenuTwo.Location = new System.Drawing.Point(273, 255);
            this.GradeDropdownMenuTwo.Name = "GradeDropdownMenuTwo";
            this.GradeDropdownMenuTwo.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuTwo.TabIndex = 8;
            // 
            // GradeDropdownMenuFour
            // 
            this.GradeDropdownMenuFour.FormattingEnabled = true;
            this.GradeDropdownMenuFour.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.GradeDropdownMenuFour.Location = new System.Drawing.Point(273, 439);
            this.GradeDropdownMenuFour.Name = "GradeDropdownMenuFour";
            this.GradeDropdownMenuFour.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuFour.TabIndex = 7;
            // 
            // GradeDropdownMenuOne
            // 
            this.GradeDropdownMenuOne.FormattingEnabled = true;
            this.GradeDropdownMenuOne.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.GradeDropdownMenuOne.Location = new System.Drawing.Point(273, 163);
            this.GradeDropdownMenuOne.Name = "GradeDropdownMenuOne";
            this.GradeDropdownMenuOne.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuOne.TabIndex = 6;
            this.GradeDropdownMenuOne.SelectedIndexChanged += new System.EventHandler(this.GradeDropdownMenuOne_SelectedIndexChanged);
            // 
            // SubjectDropdownMenuFive
            // 
            this.SubjectDropdownMenuFive.FormattingEnabled = true;
            this.SubjectDropdownMenuFive.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.SubjectDropdownMenuFive.Location = new System.Drawing.Point(21, 531);
            this.SubjectDropdownMenuFive.Name = "SubjectDropdownMenuFive";
            this.SubjectDropdownMenuFive.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuFive.TabIndex = 5;
            // 
            // SubjectDropdownMenuThree
            // 
            this.SubjectDropdownMenuThree.FormattingEnabled = true;
            this.SubjectDropdownMenuThree.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.SubjectDropdownMenuThree.Location = new System.Drawing.Point(21, 347);
            this.SubjectDropdownMenuThree.Name = "SubjectDropdownMenuThree";
            this.SubjectDropdownMenuThree.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuThree.TabIndex = 4;
            // 
            // SubjectDropdownMenuTwo
            // 
            this.SubjectDropdownMenuTwo.FormattingEnabled = true;
            this.SubjectDropdownMenuTwo.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.SubjectDropdownMenuTwo.Location = new System.Drawing.Point(21, 255);
            this.SubjectDropdownMenuTwo.Name = "SubjectDropdownMenuTwo";
            this.SubjectDropdownMenuTwo.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuTwo.TabIndex = 2;
            // 
            // SubjectDropdownMenuFour
            // 
            this.SubjectDropdownMenuFour.FormattingEnabled = true;
            this.SubjectDropdownMenuFour.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.SubjectDropdownMenuFour.Location = new System.Drawing.Point(21, 439);
            this.SubjectDropdownMenuFour.Name = "SubjectDropdownMenuFour";
            this.SubjectDropdownMenuFour.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuFour.TabIndex = 1;
            // 
            // SubjectDropdownMenuOne
            // 
            this.SubjectDropdownMenuOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectDropdownMenuOne.FormattingEnabled = true;
            this.SubjectDropdownMenuOne.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.SubjectDropdownMenuOne.Location = new System.Drawing.Point(21, 163);
            this.SubjectDropdownMenuOne.Name = "SubjectDropdownMenuOne";
            this.SubjectDropdownMenuOne.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuOne.TabIndex = 0;
            this.SubjectDropdownMenuOne.SelectedIndexChanged += new System.EventHandler(this.SubjectDropdownMenuOne_SelectedIndexChanged);
            // 
            // LabelAvailability
            // 
            this.LabelAvailability.AutoSize = true;
            this.LabelAvailability.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAvailability.ForeColor = System.Drawing.Color.White;
            this.LabelAvailability.Location = new System.Drawing.Point(641, 33);
            this.LabelAvailability.Name = "LabelAvailability";
            this.LabelAvailability.Size = new System.Drawing.Size(258, 41);
            this.LabelAvailability.TabIndex = 14;
            this.LabelAvailability.Text = "Available Course";
            this.LabelAvailability.Click += new System.EventHandler(this.LabelAvailability_Click);
            // 
            // GetCourseButton
            // 
            this.GetCourseButton.BackColor = System.Drawing.Color.Lime;
            this.GetCourseButton.Location = new System.Drawing.Point(648, 521);
            this.GetCourseButton.Name = "GetCourseButton";
            this.GetCourseButton.Size = new System.Drawing.Size(157, 50);
            this.GetCourseButton.TabIndex = 15;
            this.GetCourseButton.Text = "Get Course";
            this.GetCourseButton.UseVisualStyleBackColor = false;
            this.GetCourseButton.Click += new System.EventHandler(this.GetCourseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(873, 521);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 50);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AvailableCourses
            // 
            this.AvailableCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.AvailableCourses.ColumnCount = 4;
            this.AvailableCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AvailableCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AvailableCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 570F));
            this.AvailableCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.AvailableCourses.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableCourses.ForeColor = System.Drawing.Color.White;
            this.AvailableCourses.Location = new System.Drawing.Point(546, 89);
            this.AvailableCourses.Name = "AvailableCourses";
            this.AvailableCourses.RowCount = 1;
            this.AvailableCourses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AvailableCourses.Size = new System.Drawing.Size(444, 398);
            this.AvailableCourses.TabIndex = 18;
            this.AvailableCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.AvailableCourses_Paint);
            // 
            // CourseEnrolmentSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1023, 601);
            this.Controls.Add(this.AvailableCourses);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GetCourseButton);
            this.Controls.Add(this.LabelAvailability);
            this.Controls.Add(this.DropdownMenubackground);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CourseEnrolmentSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Enrolment System";
            this.Load += new System.EventHandler(this.CourseEnrolmentSystem_Load);
            this.DropdownMenubackground.ResumeLayout(false);
            this.DropdownMenubackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DropdownMenubackground;
        private System.Windows.Forms.ComboBox SubjectDropdownMenuFive;
        private System.Windows.Forms.ComboBox SubjectDropdownMenuThree;
        private System.Windows.Forms.ComboBox SubjectDropdownMenuTwo;
        private System.Windows.Forms.ComboBox SubjectDropdownMenuFour;
        private System.Windows.Forms.ComboBox SubjectDropdownMenuOne;
        private System.Windows.Forms.ComboBox GradeDropdownMenuFive;
        private System.Windows.Forms.ComboBox GradeDropdownMenuThree;
        private System.Windows.Forms.ComboBox GradeDropdownMenuTwo;
        private System.Windows.Forms.ComboBox GradeDropdownMenuFour;
        private System.Windows.Forms.ComboBox GradeDropdownMenuOne;
        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.Label LabelGrade;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelAvailability;
        private System.Windows.Forms.Button GetCourseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TableLayoutPanel AvailableCourses;
    }
}

