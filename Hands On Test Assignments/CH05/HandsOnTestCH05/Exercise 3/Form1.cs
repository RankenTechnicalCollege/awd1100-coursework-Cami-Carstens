using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLengthInput.Text, out double length)
             && double.TryParse(txtWidthInput.Text, out double width))
            {
                if (length <= 0 || width <= 0)
                {
                    lblResult.Text = "Length and width must be entered in positive numbers.";
                    return;
                }


                double area = length * width;
                double weeklyFee = 0;
     

                if (area >= 600)
                {
                    weeklyFee = 50;
                }
                else if (area >= 400)
                {
                    weeklyFee = 35;
                }
                else if (area < 400)
                {
                    weeklyFee = 25;
                }
                else
                {
                    lblResult.Text = "Please enter a valid numeric length for length and width";
                }

             double seasonFee = weeklyFee * 20;

            //Printed Fees Chart
                lblResult.Text = $"Lawn Area: {area} square ft \n" + 
                                 $"Weekly Fee: {weeklyFee:C}\n" + 
                                 $"Total Fee for a 20 week season:{seasonFee:C}";


            }
        }
    }
}
