using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //get txt inputs into ints
            if (int.TryParse(txtNumInput1.Text, out int input1)
              && int.TryParse(txtNumInput2.Text, out int input2)
              && int.TryParse(txtNumInput3.Text, out int input3)
              && int.TryParse(txtNumInput4.Text, out int input4))
            {

                //call on method
                Reverse4(ref input1, ref input2, ref input3, ref input4);


                txtNumInput1.Text = input1.ToString();
                txtNumInput2.Text = input2.ToString();
                txtNumInput3.Text = input3.ToString();
                txtNumInput4.Text = input4.ToString();
                lblResult.Text = "";
               

            }
            else
            {
                lblResult.Text = $"Please enter valid whole numbers in all input fields.";
            }
        }
                //passing by reference
                public void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
                {

                    //keep the original values without immediately just reassigning
                    int tempNum1 = num1;
                    int tempNum2 = num2;
                    int tempNum3 = num3;
                    int tempNum4 = num4;

                    //reverse order
                    num1 = tempNum4;
                    num2 = tempNum3;
                    num3 = tempNum2;
                    num4 = tempNum1;
                }
    }
}
