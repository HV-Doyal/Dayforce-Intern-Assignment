using Assignment.Business_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem.Business_Layer
{
    internal class ValidationProcessing
    {
        public static void ValidateSubjectDropdown(ComboBox subjectDropdownMenuOne,
                              ComboBox subjectDropdownMenuTwo, ComboBox subjectDropdownMenuThree, 
                              ComboBox subjectDropdownMenuFour, ComboBox subjectDropdownMenuFive)
        {
            if (subjectDropdownMenuOne.SelectedIndex < 0 && subjectDropdownMenuTwo.SelectedIndex < 0
                 && subjectDropdownMenuThree.SelectedIndex < 0 && subjectDropdownMenuFour.SelectedIndex < 0
                && subjectDropdownMenuFive.SelectedIndex < 0)
            {
                MessageBox.Show("All subjects required", "Error Validation");
                return;
            }

        }
        public static bool isUserInputValid(string firstName, string lastName, string email, string contactNumber, string address, string course)
        {
            bool isValid = false;

            if (Validation.isNullOrEmpty(firstName) || Validation.isNullOrEmpty(lastName)
                || Validation.isNullOrEmpty(email) || Validation.isNullOrEmpty(contactNumber)
                || Validation.isNullOrEmpty(address) || Validation.isNullOrEmpty(course))
            {
                MessageBox.Show("Error, Required fields left empty", "Error");
            }
            else if (!Validation.isEmailValid(email))
            {
                MessageBox.Show("Error Invalid Email", "Error");
            }
            else
            {
                try
                {
                    int contactNum = int.Parse(contactNumber);
                    isValid = true;
                    MessageBox.Show($"{firstName} {lastName} \n{email} \n{contactNumber} \n{address}", "Success");
                }
                catch
                {
                    MessageBox.Show("Error Invalid Contact Number", "Error");
                }
            }
            return isValid;
        }
    }
}
