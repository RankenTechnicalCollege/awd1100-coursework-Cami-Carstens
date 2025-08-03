using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string LetterGrade { get; set; }
        public decimal GPA { get; set; }



        public Student(string firstName, string lastName, string course, string letterGrade, decimal gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            LetterGrade = letterGrade;
            GPA = gpa;
        }
      public override string ToString()
        {

            return
                $"Course: {Course} \n" +
                $"Letter Grade: {LetterGrade}\n" +
                $"GPA: {GPA}";

        }
    }
}
