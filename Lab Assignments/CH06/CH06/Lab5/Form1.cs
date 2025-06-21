using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string input = txtCCNumber.Text;
            char maskNumber = '#';
            int numbersKept = 4;
            string masked = MaskNumber(input, maskNumber, numbersKept);
            lblResult.Text = masked;

        }
        private string MaskNumber(string unmaskedCC, char replacementChar, int numDigitToPreserve)
        {
            int digitCount = 0;
            string result = "";

            //count through all the letters and digits
            for (int i = 0; i < unmaskedCC.Length; i++)
            {
                if (Char.IsLetterOrDigit(unmaskedCC[i]))
                {
                    digitCount++;
                }
            }
            int currentCount = 0;
            int reveal = digitCount - numDigitToPreserve;

            
            for (int i = 0; i < unmaskedCC.Length; i++)
            {

                char currentChar = unmaskedCC[i];
                if(Char.IsLetterOrDigit(currentChar))
                {
                    if (currentCount < reveal)
                    { 
                        result = result + replacementChar;
                    }
                    else
                    {
                        result = result + currentChar;

                    }
                    currentCount++;

                }
                else
                {
                    result = result + currentChar;
                }
            }
            return result;
        }
    }
}
