using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if TryParse is successful(true) the result is stored in the variable gpa
            //if TryParse fails(false) then the if block is skipped
            if (double.TryParse(txtGradeInput.Text, out double gpa))
            {
                if (gpa < 0.0 || gpa > 4.0)
                {
                    lblResult.Text = "Please enter a valid GPA between 0.0 and 4.0";
                    return;
                }

                //if input was valid this next line will declare a variable to store the letter grade
                //Its an empty string to fill based on gpa from the next(coming up) if-else statements
                string letterGrade = "";

                if (gpa > 3.0 && gpa <= 4.0)
                {
                    letterGrade = "A";

                }
                else if (gpa <= 3.0 && gpa > 2.0)
                {
                    letterGrade = "B";
                }
                else if (gpa <= 2.0 && gpa > 1.0)
                {
                    letterGrade = "C";
                }
                else if (gpa <= 1.0 && gpa > 0.0)
                {
                    letterGrade = "D";
                }
                else if (gpa <= 0.0)
                {
                    letterGrade = "F";
                }
                lblResult.Text = $"A GPA of {gpa:F2} is a grade of {letterGrade}";
            }
            else
            {
                lblResult.Text = "Please enter a valid numeric GPA";
            
            }
        }
    }
}
