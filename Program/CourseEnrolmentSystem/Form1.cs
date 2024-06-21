using Assignment.Business_Layer;
using CourseEnrolmentSystem.Business_Layer;
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
            ValidationProcessing.isDropdownEmpty(SubjectDropdownMenuOne.Text, "1st Subject");
            //MessageBox.Show($"Worked {SubjectDropdownMenuOne.Text}", "Test");
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
