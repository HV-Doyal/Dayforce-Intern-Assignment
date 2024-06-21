using Assignment.Business_Layer;
using CourseEnrolmentSystem.Business_Layer;
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
            //ValidationProcessing.isDropdownEmpty(SubjectDropdownMenuOne.Text, "1st Subject");
            try
            {
                Subject subjectOne = new Subject(SubjectDropdownMenuOne.Text, Convert.ToChar(GradeDropdownMenuOne.Text));
                Subject subjectTwo = new Subject(SubjectDropdownMenuTwo.Text, Convert.ToChar(GradeDropdownMenuTwo.Text));
                Subject subjectThree = new Subject(SubjectDropdownMenuThree.Text, Convert.ToChar(GradeDropdownMenuThree.Text));
                Subject subjectFour = new Subject(SubjectDropdownMenuFour.Text, Convert.ToChar(GradeDropdownMenuFour.Text));
                Subject subjectFive = new Subject(SubjectDropdownMenuFive.Text, Convert.ToChar(GradeDropdownMenuFive.Text));


                MessageBox.Show($"isWorking? \n {subjectOne.Name}, {subjectOne.Grade} \n {subjectTwo.Name}, {subjectTwo.Grade}" +
                    $"\n{subjectThree.Name}, {subjectThree.Grade} \n {subjectFour.Name}, {subjectFour.Grade}" +
                    $"\n{subjectFive.Name}, {subjectFive.Grade}", "Testing");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Incorrect inputs!!! \nCheck Subject and Grades Properly \nAll input required \n{ex.Message}", "Error");
            }                                   
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
    }
}
