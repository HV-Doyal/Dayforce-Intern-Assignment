using CourseEnrolmentSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrolmentSystem.Business_Logic_Layer
{
    internal class DatabaseBll
    {
        public static List<string> GetAvailableCourses(List<Subject> subjects, int points)
        {
            return DatabaseDal.GetCourse(subjects, points);
        }

        public static void EnrollStudent(string firstName, string lastName, string email, string contactNumber, string address, string course, double fees)
        {
            DatabaseDal.InsertStudent(firstName, lastName, email, contactNumber, address, course, fees);
        }

        public static int GetFulltimeCourseCost(string course)
        {
            return DatabaseDal.GetFulltimeCost(course);
        }

        public static int GetParttimeCourseCost(string course)
        {
            return DatabaseDal.GetParttimeCost(course);
        }
    }
}
