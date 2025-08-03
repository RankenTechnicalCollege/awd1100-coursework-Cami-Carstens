using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB7
{

    public partial class Form1 : Form
    {
        //Need to make a list of students

        List<Student> engStudents = new List<Student>();
        List<Student> psychStudents = new List<Student>();
       

        //Make a course collection 

        Course ENGL101 = new Course();
        Course PSYCH202 = new Course();

        public Form1()
        {
            InitializeComponent();

            //ENGLISH COURSE
            engStudents.Add(new Student(12345678, "Andre", "Timmons", "Andre_T@insideranken.org"));
            engStudents.Add(new Student(98765432, "Jackie", "Hall", "Jackie_Hall@insideranken.org"));
            engStudents.Add(new Student(87654321, "Thomas", "Jeffers", "T_Jeffers@insideranken.org"));
            engStudents.Add(new Student(65432100, "Tarynn", "Thompson", "Tarynn_Thompson@insideranken.org"));
            engStudents.Add(new Student(789101112, "Josiah", "Jones", "Josiah_Jones@insideranken.org"));
            ENGL101.CourseName = "ENGLISH COMPOSITION 101";
            ENGL101.Students = engStudents;

            //PSYCH COURSE
            psychStudents.Add(new Student(12345678, "Timothy", "Wesland", "TWEsland@insideranken.org"));
            psychStudents.Add(new Student(23456789, "Aaron", "Parkins", "A_Parkins@insideranken.org"));
            psychStudents.Add(new Student(34567890, "Bradon", "Simms", "Bradon_Simms@insideranke.org"));
            psychStudents.Add(new Student(45678901, "Carla", "Smith", "C_Smith@insideranken.org"));
            psychStudents.Add(new Student(45678939, "Isaac", "Johnson", "Isaac_Johnson@insideranken.org"));

            PSYCH202.CourseName = "ADVANCED PSYCHOLOGY 202";
            PSYCH202.Students = psychStudents;

            //populate both courses in the cbo on form load

            cboCourseSelection.Items.Add(ENGL101.CourseName);
            cboCourseSelection.Items.Add(PSYCH202.CourseName);

            //populate the cboRemove on form load
            cboRemoveCourseSelection.Items.Add(ENGL101.CourseName);
            cboRemoveCourseSelection.Items.Add(PSYCH202.CourseName);



            //foreach (Student s1 in PSYCH202.Students)
            //{
            //    rtbPsychOutput.Text += s1.ToString();
            //    cboStudentId.Items.Add(s1.StudentID);

            //}
            //foreach(Student s2 in ENGL101.Students)
            //
            //    rtbEngOutput.Text += s2.ToString();
            //    cboStudentId.Items.Add(s2.StudentID);
            //}
            //cboCourseSelection.Items.Add(ENGL101.CourseName);
            //cboCourseSelection.Items.Add(PSYCH202.CourseName);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //read student id, first, last, email
            //populate course cbo

          int id = int.Parse(txtStudentId.Text);
          string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;

         //add new student  
        Student newStudent = new Student(id, firstName, lastName, email);

            //find out which course from cbo
            if(cboCourseSelection.SelectedItem != null)
            {
                string selectedCourse = cboCourseSelection.SelectedItem.ToString();

                //which did they select?
                if(selectedCourse == ENGL101.CourseName)
                {
                    //if selected add student to the class
                    ENGL101.Students.Add(newStudent);
                    //display
                    rtbEngOutput.Text += newStudent.ToString();
                }
                else if (selectedCourse == PSYCH202.CourseName)
                {
                    PSYCH202.Students.Add(newStudent);
                    rtbPsychOutput.Text += newStudent.ToString();
                }

                // add new student id to the cbo box for student ids
                cboStudentId.Items.Add(newStudent.StudentID);
            }  
          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            int searchId = int.Parse(cboStudentId.Text);
            string selectedCourse = cboRemoveCourseSelection.SelectedItem.ToString();

            if(selectedCourse == ENGL101.CourseName)
            {
                Student removeStudent = null;
                foreach(Student s1 in ENGL101.Students)
                {
                    if(s1.StudentID == searchId)
                    {
                        removeStudent = s1;
                        break;
                    }
                }
                if(removeStudent != null)
                {
                    ENGL101.Students.Remove(removeStudent);
                }
                rtbPsychOutput.Clear();

                rtbEngOutput.Clear();

                cboStudentId.Items.Clear();

                //repopulate 
                foreach (Student s2 in ENGL101.Students)
                {
                    rtbEngOutput.AppendText(s2.ToString());
                    cboStudentId.Items.Add(s2.StudentID);
                }
            }

            //psych class selected 
            else if (selectedCourse == PSYCH202.CourseName)
            {
                Student removeStudent2 = null;
                foreach(Student s2 in PSYCH202.Students)
                {
                    if (s2.StudentID == searchId)
                    {
                        removeStudent2 = s2;
                        break;
                    }
                }
                if(removeStudent2 != null)
                {
                    PSYCH202.Students.Remove(removeStudent2);
                }

                rtbPsychOutput.Clear();

                rtbEngOutput.Clear();

                cboStudentId.Items.Clear();

                //repopulate 
                foreach (Student s1 in PSYCH202.Students)
                {
                    //add back psych students to a tostring()
                    rtbPsychOutput.AppendText(s1.ToString());
                    cboStudentId.Items.Add(s1.StudentID);
                }

            }

            //    for (int i = 0; i < PSYCH202.Students.Count; i++)
            //    {
            //        if (PSYCH202.Students[i].StudentID == searchId)
            //        {
            //            PSYCH202.Students.RemoveAt(i);
            //            break;

            //        }
            //    }

            //for (int i = 0; i < ENGL101.Students.Count; i++)
            //{
            //    if (ENGL101.Students[i].StudentID == searchId)
            //    {
            //        ENGL101.Students.RemoveAt(i);
            //        break;

            //    }
            //}
            //rtbPsychOutput.Clear(); 

            //rtbEngOutput.Clear();

            //cboStudentId.Items.Clear();


            ////repopulate 
            //foreach ( Student s1 in PSYCH202.Students )
            //{
            //    //add back psych students to a tostring()
            //    rtbPsychOutput.AppendText(s1.ToString());
            //    cboStudentId.Items.Add(s1.StudentID);
            //}
            //foreach(Student s2 in ENGL101.Students )
            //{
            //    rtbEngOutput.AppendText(s2.ToString());
            //    cboStudentId.Items.Add(s2.StudentID);
            //}
           
           
        }

        private void cboCourseSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = cboCourseSelection.Text;

            rtbEngOutput.Clear();
            rtbPsychOutput.Clear();
            cboStudentId.Items.Clear(); 

            if (selectedCourse == ENGL101.CourseName) 
            {
                foreach (Student student in ENGL101.Students)
                {
                    rtbEngOutput.Text += student.ToString();
                    cboStudentId.Items.Add(student.StudentID);
                }
                   
            }
            else if (selectedCourse == PSYCH202.CourseName)
            {
                rtbPsychOutput.Clear();
                foreach(Student student in PSYCH202.Students)
                {
                    rtbPsychOutput.Text += student.ToString();
                    cboStudentId.Items.Add(student.StudentID);
                }
            }
        }

        private void cboRemoveCourseSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStudentId.Items.Clear();
            string selectedCourse = cboRemoveCourseSelection.SelectedItem.ToString();

            if(selectedCourse == ENGL101.CourseName)
            {
                foreach(Student student in ENGL101.Students)
                {
                    cboStudentId.Items.Add(student.StudentID);
                }
            }
            else if (selectedCourse== PSYCH202.CourseName)
            {
                foreach(Student student in PSYCH202.Students)
                {
                    cboStudentId.Items.Add((student.StudentID));
                }
            }
        }
    }
}