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
            List<Subject> subjects = new List<Subject>();
            //ValidationProcessing.isDropdownEmpty(SubjectDropdownMenuOne.Text, "1st Subject");
            try
            {
                subjects.Add(new Subject(SubjectDropdownMenuOne.Text, Convert.ToChar(GradeDropdownMenuOne.Text)));
                subjects.Add(new Subject(SubjectDropdownMenuTwo.Text, Convert.ToChar(GradeDropdownMenuTwo.Text)));
                subjects.Add(new Subject(SubjectDropdownMenuThree.Text, Convert.ToChar(GradeDropdownMenuThree.Text)));
                subjects.Add(new Subject(SubjectDropdownMenuFour.Text, Convert.ToChar(GradeDropdownMenuFour.Text)));
                subjects.Add(new Subject(SubjectDropdownMenuFive.Text, Convert.ToChar(GradeDropdownMenuFive.Text)));

                MessageBox.Show($"{Points.CalculatePoints(subjects)}");
                //DatabaseDal.GetCourse(Points.CalculatePoints(subjects));
                //TESTING
                List<string> courseAvailable = DatabaseDal.GetCourse(Points.CalculatePoints(subjects));

                foreach (string course in courseAvailable)
                {
                    MessageBox.Show(course, "Tesing");
                }
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Rest Dropdown Menu for subjects
            SubjectDropdownMenuOne.ResetText();
            SubjectDropdownMenuTwo.ResetText();
            SubjectDropdownMenuThree.ResetText();
            SubjectDropdownMenuFour.ResetText();
            SubjectDropdownMenuFive.ResetText();


            //Rest Dropdown Menu for grades
            GradeDropdownMenuOne.ResetText();
            GradeDropdownMenuTwo.ResetText();
            GradeDropdownMenuThree.ResetText();
            GradeDropdownMenuFour.ResetText();
            GradeDropdownMenuFive.ResetText();
        }

        private void CourseEnrolmentSystem_Load(object sender, EventArgs e)
        {
       
        }
    }
}
