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
        //not using, try and catch worked better REMOVE BEFORE SUBMISSION
        public static string isDropdownEmpty(string subject, string fieldName)
        {
            if (Validation.isNullOrEmpty(subject))
            {
                MessageBox.Show($"The field {fieldName} should not be empty", "Error");
                return subject;
            }
            else
            {
                return subject;
            }
        }
    }
}
