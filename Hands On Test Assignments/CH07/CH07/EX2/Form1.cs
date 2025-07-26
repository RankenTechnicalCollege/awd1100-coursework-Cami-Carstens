using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            //Arithemetic Exception: exception that occurs during arithmetic operations,casting, or conversion operations.
            //try to divide by zero

            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Error: Cannot divide by zero.");
            }
        }



        private void btnFormat_Click(object sender, EventArgs e)
        {
            //Format Exception: exception that occurs when the format of an argument is invalid or does not meet the expected string format.
            //try to parse a letter string to an int number.
            try
            {
                string userInput = "abc";
                int number = int.Parse(userInput);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Invalid format.");
            }

        }


        private void btnInvalidCast_Click(object sender, EventArgs e)
        {
            //InvalidCastException: exception that occurs when an invalid cast is attempted, such as trying to convert an object to a type it cannot be converted to.
            //try to cast a double-object to an int
            try
            {
              List<object> objects = new List<object>();
              objects.Add(5.75);

              int number = (int)objects[0]; // Attempting to cast a string to an int
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error: Invalid cast. Cannot convert the object to the specified type.");
            }
        }



        private void btnNullReference_Click(object sender, EventArgs e)
        {
            // NullReferenceException: exception that occurs when trying to access a member of an object that is null.
            try
            {
                string exampleInput = null;
                int length = exampleInput.Length; 
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: You can not use a null object that was not ititialized.");
            }
        }
    }
}
