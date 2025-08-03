using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    public class Student
    {
        public Student()
        {

        }

        public Student(int id, string firstName, string lastName, string email)
        {
            StudentID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public int StudentID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}'s email is {Email} and has a student ID of {StudentID} \n";
        }

    }
}

