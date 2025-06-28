using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        //array that can accept 20 numbers
        int[] numbers = new int [20];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            grpResultStats.Visible = true;
            lblResult.Text = "";

            //error message for over 20 entries
            if(count >= 20)
            {
                lblResult.Text = $"You can only enter 20 numbers.";
                return;
            }
            //otherwise get input and convert to an integer
            int number;
            if(int.TryParse(txtIntegerInput.Text, out number))
            {
                numbers[count] = number;
                count++;

                //clear out number input so you dont have to delete it everytime 
                txtIntegerInput.Clear();

                //make array with new entered numbers
                int[] enteredNumbers = new int[count];
                for(int i = 0; i < count; i++)
                {
                    //make array and entered number array =
                    enteredNumbers[i] = numbers[i];
                }


                int min;
                int max;
                double sum;
                double avg;

                CalculateStats(out min, out max, out sum, out avg, enteredNumbers);

                lblResult.Text = $"Total entered numbers {count} \n Minimum: {min} \n Maximum: {max} \n Average: {avg:F2}";
                

            }
            else
            {
                lblResult.Text = $"Please enter valid integers.";
            }

        }

        private void CalculateStats(out int min, out int max, out double sum, out double avg, params int[] numbers)
        {

            min = numbers[0]; //minimun entered number at 1st index spot(0)
            max = numbers[0]; //max number entered at 0 index
            sum = 0;
            avg = 0;

            foreach (int num in numbers)
            {
                if(num < min) 
                    min = num;
                if(num > max)
                    max = num;
                sum = sum + num;
            }
            avg = sum / numbers.Length;
        }
    }
}
