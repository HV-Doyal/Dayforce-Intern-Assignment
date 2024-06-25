using CourseEnrolmentSystem.Business_Layer;
using CourseEnrolmentSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                              ComboBox subjectDropdownMenuFive, ComboBox gradeDropdownMenuFive, 
                              TableLayoutPanel coursesAvailableTable, Label availability)
        {
            bool isValid = false;
            try
            {               
                for (int i = 1; i <= 5; i++)
                {
                    string subjectName = "";
                    char grade = ' ';
                    switch (i)
                    {
                        case 1:
                            subjectName = subjectDropdownMenuOne.Text;
                            grade = Convert.ToChar(gradeDropdownMenuOne.Text);
                            break;
                        case 2:
                            subjectName = subjectDropdownMenuTwo.Text;
                            grade = Convert.ToChar(gradeDropdownMenuTwo.Text);
                            break;
                        case 3:
                            subjectName = subjectDropdownMenuThree.Text;
                            grade = Convert.ToChar(gradeDropdownMenuThree.Text);
                            break;
                        case 4:
                            subjectName = subjectDropdownMenuFour.Text;
                            grade = Convert.ToChar(gradeDropdownMenuFour.Text);
                            break;
                        case 5:
                            subjectName = subjectDropdownMenuFive.Text;
                            grade = Convert.ToChar(gradeDropdownMenuFive.Text);
                            break;
                    }
                    // Check if subject already exists in the list
                    if (!subjects.Any(s => s.Name == subjectName))
                    {
                        subjects.Add(new Subject(subjectName, grade));
                        if (subjects.Count == 5) isValid = true;
                    }
                    else
                    {
                        MessageBox.Show($"Subject '{subjectName}' already exists. Please choose a different subject.\n Cleared duplicate field", "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        subjectName = "";
                        switch (i)
                        {
                            case 1:
                                subjectDropdownMenuOne.SelectedIndex = -1;
                                gradeDropdownMenuOne.SelectedIndex = -1;
                                break;
                            case 2:
                                subjectDropdownMenuTwo.SelectedIndex = -1;
                                gradeDropdownMenuTwo.SelectedIndex = -1;
                                break;
                            case 3:
                                subjectDropdownMenuThree.SelectedIndex = -1;
                                gradeDropdownMenuThree.SelectedIndex = -1;
                                break;
                            case 4:
                                subjectDropdownMenuFour.SelectedIndex = -1;
                                gradeDropdownMenuFour.SelectedIndex = -1;
                                break;
                            case 5:
                                subjectDropdownMenuFive.SelectedIndex = -1;
                                gradeDropdownMenuFive.SelectedIndex = -1;
                                break;
                        }
                    }
                }                
            }
            catch 
            {
                MessageBox.Show($"Incorrect inputs!!! \nCheck Subject and Grades Properly \nAll input required", "Error Validation");
                subjects.Clear();
            }
            if (isValid)
            {
                List<string> courseAvailable = DatabaseBll.GetAvailableCourses(subjects, TotalPoints());
                DisplayCourses(courseAvailable, coursesAvailableTable, availability, form);
            }
            else
            {
                subjects.Clear();
            }
        }
        public static void DisplayCourses(List<string> courseAvailable, TableLayoutPanel coursesAvailableTable, Label availability, Form form)
        {
            coursesAvailableTable.Controls.Clear();
            availability.Text = "Courses Available";
            int rowNumber = courseAvailable.Count;

            coursesAvailableTable.ColumnCount = 2;
            coursesAvailableTable.RowCount = rowNumber;

            if (courseAvailable.Count > 0)
            {
                for (int i = 0; i < courseAvailable.Count; i++)
                {
                    string course = courseAvailable[i];

                    //label forcourse name
                    Label courseLabel = new Label();
                    courseLabel.Text = course;
                    courseLabel.AutoSize = true;
                    coursesAvailableTable.Controls.Add(courseLabel, 0, i);

                    //button for each course
                    Button registerButton = new Button();
                    registerButton.Text = "Register";
                    registerButton.AutoSize = true;
                    registerButton.Click += (sender, e) =>
                    {
                        // Open Form2 and pass course as a parameter
                        CourseEnrolmentSystemTwo courseEnrolmentSystemTwo = new CourseEnrolmentSystemTwo(course);
                        courseEnrolmentSystemTwo.Show();
                        form.Hide();
                    };
                    coursesAvailableTable.Controls.Add(registerButton, 1, i);
                }
                //seting styles of table
                coursesAvailableTable.ColumnStyles[0].SizeType = SizeType.AutoSize;
                coursesAvailableTable.ColumnStyles[1].SizeType = SizeType.Absolute;
                coursesAvailableTable.ColumnStyles[1].Width = 150;
                coursesAvailableTable.ColumnStyles[2].SizeType = SizeType.AutoSize;
            }
            else
            {
                availability.Text = "No Course Available";
            }
        }

        public static int TotalPoints()
        {
            return Points.CalculatePoints(subjects);
        }
    }
}
