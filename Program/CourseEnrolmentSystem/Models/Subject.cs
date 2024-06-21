using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrolmentSystem.Data_Access_Layer
{
    internal class Subject
    {
        private string _name;
        private Char _grade;

        public Subject(string name, char grade)
        {
            _name = name;
            _grade = grade;
        }
        public String Name { get { return _name; } }
        public Char Grade { get { return _grade; } }
    }
}
