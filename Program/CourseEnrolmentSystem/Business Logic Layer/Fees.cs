using CourseEnrolmentSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem.Business_Logic_Layer
{
    public class Fees
    {
        public static double Calculate(string course, CheckBox isFulltimeCheckBox)
        {
            double finalFees = DatabaseDal.GetFulltimeCost(course);
            var points = MainFunction.TotalPoints();


            if (isFulltimeCheckBox.Checked == true && (points > 45))
            {
                finalFees *= 0.9;
            }

            if (isFulltimeCheckBox.Checked == false)
            {
                finalFees = DatabaseDal.GetParttimeCost(course);
            }
            return finalFees;
        }
    }
}