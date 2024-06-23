using CourseEnrolmentSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem.Business_Logic_Layer
{
    internal class UiFunction
    {
        public static void GetCourses(Form form, ComboBox subjectDropdownMenuOne, ComboBox gradeDropdownMenuOne,
                              ComboBox subjectDropdownMenuTwo, ComboBox gradeDropdownMenuTwo,
                              ComboBox subjectDropdownMenuThree, ComboBox gradeDropdownMenuThree,
                              ComboBox subjectDropdownMenuFour, ComboBox gradeDropdownMenuFour,
                              ComboBox subjectDropdownMenuFive, ComboBox gradeDropdownMenuFive,
                              ListBox CoursesListBox)
        {
            List<Subject> subjects = new List<Subject>();
            try
            {
                subjects.Add(new Subject(subjectDropdownMenuOne.Text, Convert.ToChar(gradeDropdownMenuOne.Text)));
                subjects.Add(new Subject(subjectDropdownMenuTwo.Text, Convert.ToChar(gradeDropdownMenuTwo.Text)));
                subjects.Add(new Subject(subjectDropdownMenuThree.Text, Convert.ToChar(gradeDropdownMenuThree.Text)));
                subjects.Add(new Subject(subjectDropdownMenuFour.Text, Convert.ToChar(gradeDropdownMenuFour.Text)));
                subjects.Add(new Subject(subjectDropdownMenuFive.Text, Convert.ToChar(gradeDropdownMenuFive.Text)));

                //Messa+geBox.Show($"{Points.CalculatePoints(subjects)}");

                List<string> courseAvailable = DatabaseDal.GetCourse(Points.CalculatePoints(subjects));

                CoursesListBox.Items.Clear();
                foreach (string course in courseAvailable)
                {
                    CoursesListBox.Items.Add(course);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Incorrect inputs!!! \nCheck Subject and Grades Properly \nAll input required \n{ex.Message}", "Error");
            }
        }
    }
}
