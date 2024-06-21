using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int point = 0 ;
            char grade = subject.Grade;
            switch (grade)
            {
                case 'A':
                    point += (int)GradePoint.A; 
                    break;
                case 'B':
                    point += (int)GradePoint.B;
                    break;
                case 'C':
                    point += (int)GradePoint.C;
                    break;
                case 'D':
                    point += (int)GradePoint.D;
                    break;
                case 'E':
                    point += (int)GradePoint.E;
                    break;
                case 'F':
                    point += (int)GradePoint.F;
                    break;
            }
            return point;
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
