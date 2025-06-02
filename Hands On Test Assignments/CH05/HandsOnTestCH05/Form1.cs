using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOnTestCH05
{
    public partial class Form1 : Form
    {
        const double CM_PER_IN = 2.54;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convert user text input into a numeric value
            //Gets text entered into the txtInput textbox 
            //Returns a string
            //Double.TryParse tries to convert that string into a double(floating point #)
            //if it returns true the if block will run
            //if it returns false the else block will run instead
            if (double.TryParse(txtInput.Text, out double inches))
            {
                double centimeters = inches * CM_PER_IN;
                lblResult.Text = $"{inches} inches is {centimeters:F2} centimeters";
            }
            else
            {
                lblResult.Text = "Please enter a valid number input for inches.";
            }

        }
    }
}
