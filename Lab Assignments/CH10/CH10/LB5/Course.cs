using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{

        public class Course
        {
            private string _courseName;
            private List<Student> _students;

            public Course()
            {

            }
            public Course(string courseName, List<Student> students)
            {
                _courseName = courseName;
                _students = students;
            }

            public string CourseName
            {
                get { return _courseName; }
                set { _courseName = value; }
            }
            public List<Student> Students
            {
                get { return _students; }
                set { _students = value; }
            }
        }
    }



