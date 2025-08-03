using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB6
{
    public partial class Form1 : Form
    {
        Course course1 = new Course("Student Dictionary");
        public Form1()
        {
            InitializeComponent();
            //Add students

            course1.AddStudent(new Student
            {
                StudentID = "123456",
                FirstName = "Mike",
                LastName = "Jones",
                Email = "Mike_Jones@insiderankin.org"
            });
            course1.AddStudent(new Student
            {
                StudentID = "899999",
                FirstName = "Michelle",
                LastName = "Gunner",
                Email = "Michelle_Gunnar@insideranken.org"
            });
            course1.AddStudent(new Student
            {
                StudentID = "555666",
                FirstName = "Tamika",
                LastName = "Jackson",
                Email = "Tamika_Jackson"
            });
            course1.AddStudent(new Student
            {
                StudentID = "878798",
                FirstName = "Michael",
                LastName = "Jordan",
                Email = "Michael_Jordan@insideranken.org"
            });
            course1.AddStudent(new Student
            {
                StudentID = "654321",
                FirstName = "Xavier",
                LastName = "Wren",
                Email = "X_Wren@insideranken.org"

            });

            //must use .Values to loop through since its a dictionary not a list
            foreach (Student student in course1.Students.Values)
            {
                rtbOutput.Text += student.ToString();
                cboStudentId.Items.Add(student.StudentID);

            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //make student object with input
            Student addStudent = new Student
            {
                StudentID = txtStudentId.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,

            };
            //add student to course
            course1.AddStudent(addStudent);
            UpdateDisplay();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            course1.RemoveStudent(cboStudentId.Text);
            UpdateDisplay();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //look for student with id input
            Student foundStudent = course1.GetStudentById(txtSearchById.Text);
            if (foundStudent != null)
            {
                lblSearchIDResult.Text = foundStudent.ToString();
            }
            else
            {
                lblSearchIDResult.Text = "Student not found.";
            }
        }


        //method for updating display
        private void UpdateDisplay()
        {
            rtbOutput.Clear();
            cboStudentId.Items.Clear();

            //Values in the dictionary
            foreach(Student student in course1.Students.Values)
            {
                rtbOutput.Text += student.ToString();
                cboStudentId.Items.Add(student.StudentID);
            }
        }
    }
}
