using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    public class Course
    {
        public string CourseName { get; set; }
        public Dictionary<string, Student> Students { get; set; }

        public Course(string name)
        {
            CourseName = name;
            Students = new Dictionary<string, Student>();
        }


        //method for adding student using student id key into dictionary
        public void AddStudent(Student student)
        {
            //checks if key exist in dictionary
            if (!Students.ContainsKey(student.StudentID))
            //key     
            {
                Students[student.StudentID] = student;
            }
        }
        //method to remove student 
        public void RemoveStudent(string studentID)
        {
            //remove from dictionary
            Students.Remove(studentID);
        }
        public Student GetStudentById(string studentID)
        {
            //true or false, value associated with the key. does it exist? if so get value.
            //student object will be stored here if key is found 
            if (Students.TryGetValue(studentID, out Student student))
            {
                //key
                return student;
            }
            else
            {
                return null;
            }

        }
    }
}
