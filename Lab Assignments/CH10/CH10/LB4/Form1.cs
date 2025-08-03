using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        studentList.Add(new Student("Quinn", "Terreno", "AWD 2022 L04", "B", 2.8m));
          studentList.Add( new Student("Alicia", "Lucas", "ACCT 202", "A", 3.6m));
          studentList.Add(new Student("Regina", "Brown", "CHEM 131 L", "C", 2.1m));
           studentList.Add(new Student("Emma", "Burnes", "AWD 1000 M04", "A", 3.9m));
           studentList.Add(new Student("Micah", "Elias", "CALC 101", "D", 1.2m));
          studentList.Add(new Student("Jerome", "Davis", "CMST 230", "A", 3.6m));
            studentList.Add(new Student("John", "Hughes", "ECON 201 LL7","F", 0.6m));

        }

        private void btnFirstName_Click(object sender, EventArgs e)
        {
            lblNameResult.Text = "";
            txtLastName.Text = "";
            string firstName = txtFirstName.Text;
            bool found = false;

            foreach (Student student in studentList)
            {
                if (student.FirstName.ToLower() == txtFirstName.Text.ToLower()) 
                {
                    lblNameResult.Text = student.FirstName + " " + student.LastName;
                    DisplayStudent(student);
                    found = true;
                    break;
                }
            }
            if(!found)
            {
               lblNameResult.Text = "Student Not Found";
            }
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            lblNameResult.Text = "";
            txtFirstName.Text = "";
            string lastName = txtLastName.Text;
            bool found = false;

            foreach (Student student in studentList)
            {
                if (student.LastName.ToLower() == txtLastName.Text)
                {
                    lblNameResult.Text = student.FirstName + " " + student.LastName;
                    DisplayStudent( student );
                    found = true;
                    break;
                }
                if (!found)
                {
                    lblNameResult.Text= "Student Not Found";
                }
            }
        }

        //events for pressing Enter
        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnFirstName.PerformClick();
            }

        }
        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLastName.PerformClick();
            }
        }
        private void DisplayStudent(Student student)
        {
           lblStudentInfo.Text = student.ToString();
        }
    }

}
