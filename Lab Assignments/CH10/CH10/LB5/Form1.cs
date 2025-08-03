using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    public partial class Form1 : Form
    {
        List<Student> currentStudents = new List<Student> ();
        Course awd1100 = new Course ();
        public Form1()
        {
            InitializeComponent();
            //Adding students to the List
            currentStudents.Add(new Student (12345678, "Timothy", "Wesland", "TWEsland@insideranken.org"));
            currentStudents.Add(new Student(23456789, "Aaron", "Parkins", "A_Parkins@insideranken.org"));
            currentStudents.Add(new Student(34567890, "Bradon", "Simms", "Bradon_Simms@insideranke.org"));
            currentStudents.Add(new Student(45678901, "Carla", "Smith", "C_Smith@insideranken.org"));

            

            //Setting course name and add the student list to the course
            awd1100.CourseName = "Programming Fundamentals with C#";
            awd1100.Students = currentStudents;


            //populate the Rich TextBox 
            //populate the cbo with Id's
            foreach(Student s in awd1100.Students)
            {
                rtbOutput.Text += s.ToString();
                cboStudentId.Items.Add(s.StudentID);
            }
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add
            //Update
            //Output update

            currentStudents.Add(new Student(int.Parse(txtStudentId.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text));
            awd1100.Students = currentStudents;
            //clear rich textbox
            rtbOutput.Text = "";

            //add id to list
            cboStudentId.Items.Add(int.Parse(txtStudentId.Text));

            //output updated list
            foreach(Student student in awd1100.Students)
            {
                rtbOutput.Text += student.ToString();
             
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //read student id
            int searchId = int.Parse(cboStudentId.Text);

        //    //search for id
            
        //    foreach(Student student in awd1100.Students)
        //    {
        //        if(searchId == student.StudentID)
        //        {
                    
        //            awd1100.Students.Remove(student);

        //        }
        //    }
        for(int i = 0; i < awd1100.Students.Count; i++)
            {
                if(searchId == awd1100.Students[i].StudentID)
                {
                    awd1100.Students.Remove(awd1100.Students[i]);

                }
            }

            //update the rich textbox
            //update the cbo box
            rtbOutput.Text = "";
            cboStudentId.Items.Clear();
            
            foreach(Student student1 in awd1100.Students)
            {
                rtbOutput.Text += student1.ToString();
                cboStudentId.Items.Add(student1.StudentID);
            }  
        }
    }
}
