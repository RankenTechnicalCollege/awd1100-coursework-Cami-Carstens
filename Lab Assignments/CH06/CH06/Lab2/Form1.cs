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

namespace Lab2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtGpa.Text, out float gpa)
              && int.TryParse(txtTestScore.Text, out int testScore))
            {
                bool accepted = IsStudentAccepted(gpa, testScore);

                if (accepted)
                {
                    lblResult.Text = "Accept";
                }
                else
                {
                    lblResult.Text = "Reject";
                }
            }
            else
            {
                lblResult.Text = "Error. Please enter valid numbers.";
            }
        }


        private bool IsStudentAccepted(float gpa, int testScore)
                {
             if (gpa >= 3.0 && testScore >= 60)
             {
                 return true;
              }
            else if (gpa < 3.0 && testScore >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }


           }
        }

    }

