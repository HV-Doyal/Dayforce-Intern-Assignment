namespace CourseEnrolmentSystem
{
    partial class Form1
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelAvailability = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
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
            this.GradeDropdownMenuFive.Location = new System.Drawing.Point(273, 531);
            this.GradeDropdownMenuFive.Name = "GradeDropdownMenuFive";
            this.GradeDropdownMenuFive.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuFive.TabIndex = 10;
            // 
            // GradeDropdownMenuThree
            // 
            this.GradeDropdownMenuThree.FormattingEnabled = true;
            this.GradeDropdownMenuThree.Location = new System.Drawing.Point(273, 347);
            this.GradeDropdownMenuThree.Name = "GradeDropdownMenuThree";
            this.GradeDropdownMenuThree.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuThree.TabIndex = 9;
            // 
            // GradeDropdownMenuTwo
            // 
            this.GradeDropdownMenuTwo.FormattingEnabled = true;
            this.GradeDropdownMenuTwo.Location = new System.Drawing.Point(273, 255);
            this.GradeDropdownMenuTwo.Name = "GradeDropdownMenuTwo";
            this.GradeDropdownMenuTwo.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuTwo.TabIndex = 8;
            // 
            // GradeDropdownMenuFour
            // 
            this.GradeDropdownMenuFour.FormattingEnabled = true;
            this.GradeDropdownMenuFour.Location = new System.Drawing.Point(273, 439);
            this.GradeDropdownMenuFour.Name = "GradeDropdownMenuFour";
            this.GradeDropdownMenuFour.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuFour.TabIndex = 7;
            // 
            // GradeDropdownMenuOne
            // 
            this.GradeDropdownMenuOne.FormattingEnabled = true;
            this.GradeDropdownMenuOne.Location = new System.Drawing.Point(273, 163);
            this.GradeDropdownMenuOne.Name = "GradeDropdownMenuOne";
            this.GradeDropdownMenuOne.Size = new System.Drawing.Size(176, 40);
            this.GradeDropdownMenuOne.TabIndex = 6;
            // 
            // SubjectDropdownMenuFive
            // 
            this.SubjectDropdownMenuFive.FormattingEnabled = true;
            this.SubjectDropdownMenuFive.Location = new System.Drawing.Point(21, 531);
            this.SubjectDropdownMenuFive.Name = "SubjectDropdownMenuFive";
            this.SubjectDropdownMenuFive.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuFive.TabIndex = 5;
            // 
            // SubjectDropdownMenuThree
            // 
            this.SubjectDropdownMenuThree.FormattingEnabled = true;
            this.SubjectDropdownMenuThree.Location = new System.Drawing.Point(21, 347);
            this.SubjectDropdownMenuThree.Name = "SubjectDropdownMenuThree";
            this.SubjectDropdownMenuThree.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuThree.TabIndex = 4;
            // 
            // SubjectDropdownMenuTwo
            // 
            this.SubjectDropdownMenuTwo.FormattingEnabled = true;
            this.SubjectDropdownMenuTwo.Location = new System.Drawing.Point(21, 255);
            this.SubjectDropdownMenuTwo.Name = "SubjectDropdownMenuTwo";
            this.SubjectDropdownMenuTwo.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuTwo.TabIndex = 2;
            // 
            // SubjectDropdownMenuFour
            // 
            this.SubjectDropdownMenuFour.FormattingEnabled = true;
            this.SubjectDropdownMenuFour.Location = new System.Drawing.Point(21, 439);
            this.SubjectDropdownMenuFour.Name = "SubjectDropdownMenuFour";
            this.SubjectDropdownMenuFour.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuFour.TabIndex = 1;
            // 
            // SubjectDropdownMenuOne
            // 
            this.SubjectDropdownMenuOne.FormattingEnabled = true;
            this.SubjectDropdownMenuOne.Location = new System.Drawing.Point(21, 163);
            this.SubjectDropdownMenuOne.Name = "SubjectDropdownMenuOne";
            this.SubjectDropdownMenuOne.Size = new System.Drawing.Size(176, 40);
            this.SubjectDropdownMenuOne.TabIndex = 0;
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
            // LabelAvailability
            // 
            this.LabelAvailability.AutoSize = true;
            this.LabelAvailability.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAvailability.ForeColor = System.Drawing.Color.White;
            this.LabelAvailability.Location = new System.Drawing.Point(645, 64);
            this.LabelAvailability.Name = "LabelAvailability";
            this.LabelAvailability.Size = new System.Drawing.Size(258, 41);
            this.LabelAvailability.TabIndex = 14;
            this.LabelAvailability.Text = "Available Course";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Lime;
            this.SaveButton.Location = new System.Drawing.Point(652, 521);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 50);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(856, 521);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 50);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1052, 607);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LabelAvailability);
            this.Controls.Add(this.DropdownMenubackground);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Enrolment System";
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
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

