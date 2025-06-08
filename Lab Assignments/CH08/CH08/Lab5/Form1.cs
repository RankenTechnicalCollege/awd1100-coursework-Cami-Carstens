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

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            string input = txtNumberInput.Text;
            int letterDigit = 0;

            for (int i = 0; i < input.Length; i++) 
            {
                if (Char.IsLetterOrDigit(input[i]))
                {
                    letterDigit++;
                }

                int revealChar = letterDigit - 4;
                int countSoFar = 0;
                string maskedCount = "";
                

                for (int j = 0; j < input.Length; j++)
                {
                    char currentChar = input[j];
                    if (Char.IsLetterOrDigit(currentChar))
                    {
                        if (countSoFar < revealChar)
                        {
                            maskedCount += "#";
                        }
                        else
                        {
                            maskedCount += currentChar;
                        }
                       countSoFar++;
                    }
                    else
                    {
                        maskedCount += currentChar;
                    }
                }
                lblResult.Text = maskedCount;
            }
        }
    }
}
