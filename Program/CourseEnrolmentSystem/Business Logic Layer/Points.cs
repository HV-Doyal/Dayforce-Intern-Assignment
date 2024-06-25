using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem.Data_Access_Layer
{
    enum GradePoint
    {
        A = 10,
        B = 8,
        C = 6,
        D = 4,
        E = 2,
        F = 0
    }
    internal class Points
    {
        public static int SubjectPoint(Subject subject)
        {
            char grade = subject.Grade;

            // Try to parse the grade character into a GradePoint enum
            if (Enum.TryParse<GradePoint>(grade.ToString(), out GradePoint gradePoint))
            {
                return (int)gradePoint;
            }
            else
            {
                MessageBox.Show("Invalid Grade");
                return 0;
            }
        }

        public static int CalculatePoints(List<Subject> subjects)
        {
            int totalPoints = 0;
            
            foreach (Subject subject in subjects)
            {
                totalPoints += SubjectPoint(subject);
            }
            return totalPoints;
        }
    }
}
