using Assignment.Business_Layer;
using CourseEnrolmentSystem.Business_Layer;
using CourseEnrolmentSystem.Business_Logic_Layer;
using CourseEnrolmentSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem
{
    public partial class CourseEnrolmentSystem : Form
    {
        public CourseEnrolmentSystem()
        {
            InitializeComponent();
        }

        private void DropdownMenubackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }

        private void GradeDropdownMenuOne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetCourseButton_Click(object sender, EventArgs e)
        {
            ValidationProcessing.ValidateSubjectDropdown(SubjectDropdownMenuOne, SubjectDropdownMenuTwo, SubjectDropdownMenuThree,
                                                                SubjectDropdownMenuFour, SubjectDropdownMenuFive);

            UiFunction.GetCourses(this, SubjectDropdownMenuOne, GradeDropdownMenuOne,
                                   SubjectDropdownMenuTwo, GradeDropdownMenuTwo,
                                   SubjectDropdownMenuThree, GradeDropdownMenuThree,
                                   SubjectDropdownMenuFour, GradeDropdownMenuFour,
                                   SubjectDropdownMenuFive, GradeDropdownMenuFive, AvailableCourses, LabelAvailability);
        }

        private void CourseAvailableFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadCourses()
        {
            
        }

        private void SubjectDropdownMenuOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LabelAvailability_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SubjectDropdownMenuOne.SelectedIndex = -1;
            SubjectDropdownMenuOne.ResetText();
            SubjectDropdownMenuTwo.ResetText();
            SubjectDropdownMenuThree.ResetText();
            SubjectDropdownMenuFour.ResetText();
            SubjectDropdownMenuFive.ResetText();

            GradeDropdownMenuOne.ResetText();
            GradeDropdownMenuTwo.ResetText();
            GradeDropdownMenuThree.ResetText();
            GradeDropdownMenuFour.ResetText();
            GradeDropdownMenuFive.ResetText();

            AvailableCourses.Controls.Clear();
        }

        private void CourseEnrolmentSystem_Load(object sender, EventArgs e)
        {

        }

        private void CourseAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coursesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CoursesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            CourseEnrolmentSystemTwo courseEnrolmentSystemTwo = new CourseEnrolmentSystemTwo();
            courseEnrolmentSystemTwo.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AvailableCourses_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
