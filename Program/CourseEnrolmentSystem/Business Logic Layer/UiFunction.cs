using CourseEnrolmentSystem.Business_Layer;
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
        public static List<Subject> subjects = new List<Subject>();
        public static void GetCourses(Form form, ComboBox subjectDropdownMenuOne, ComboBox gradeDropdownMenuOne,
                              ComboBox subjectDropdownMenuTwo, ComboBox gradeDropdownMenuTwo,
                              ComboBox subjectDropdownMenuThree, ComboBox gradeDropdownMenuThree,
                              ComboBox subjectDropdownMenuFour, ComboBox gradeDropdownMenuFour,
                              ComboBox subjectDropdownMenuFive, ComboBox gradeDropdownMenuFive, TableLayoutPanel coursesAvailableTable)
        {
            try
            {
                subjects.Add(new Subject(subjectDropdownMenuOne.Text, Convert.ToChar(gradeDropdownMenuOne.Text)));
                subjects.Add(new Subject(subjectDropdownMenuTwo.Text, Convert.ToChar(gradeDropdownMenuTwo.Text)));
                subjects.Add(new Subject(subjectDropdownMenuThree.Text, Convert.ToChar(gradeDropdownMenuThree.Text)));
                subjects.Add(new Subject(subjectDropdownMenuFour.Text, Convert.ToChar(gradeDropdownMenuFour.Text)));
                subjects.Add(new Subject(subjectDropdownMenuFive.Text, Convert.ToChar(gradeDropdownMenuFive.Text)));

                List<string> courseAvailable = DatabaseDal.GetCourse(Points.CalculatePoints(subjects));

                coursesAvailableTable.Controls.Clear();
                int rowNumber = courseAvailable.Count;

                coursesAvailableTable.ColumnCount = 3;
                coursesAvailableTable.RowCount = rowNumber;

                coursesAvailableTable.RowCount = rowNumber;
                foreach (string course in courseAvailable)
                {
                    coursesAvailableTable.Controls.Add(new Label() { Text = $"{course}" }, 0, rowNumber - 1 );
                    coursesAvailableTable.Controls.Add(new Button() { Text = "Register"}, 1, rowNumber - 1 ); 
                    rowNumber--;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Incorrect inputs!!! \nCheck Subject and Grades Properly \nAll input required \n{ex.Message}", "Error Validation");
            }
        }

        public static int TotalPoints()
        {
            int totalPoints = Points.CalculatePoints(subjects);
            return totalPoints;
        }
    }
}
