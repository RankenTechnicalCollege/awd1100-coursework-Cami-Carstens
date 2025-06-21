using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        string[] vowels = new string[5];
        public Form1()
        {
            InitializeComponent();
            vowels[0] = "a";
            vowels[1] = "e";
            vowels[2] = "i";
            vowels[3] = "o";
            vowels[4] = "u";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputPhrase = txtPhrase.Text;
                                //call on method
            int vowelCount = CountVowels(inputPhrase);
            lblResult.Text = $"Your phrase entered has {vowelCount} vowels";

        }
        private int CountVowels(string phrase)
        {
            int count = 0;
            string upperOrLowerPhrase = phrase.ToLower();


            //loop through phrase 
            for (int i = 0; i < upperOrLowerPhrase.Length; i++)
            {
                for (int  j = 0; j < vowels.Length; j++)
                {
                    //char          //Convert char to string  //string
                    if (upperOrLowerPhrase[i].ToString() == vowels[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;

        }
    }
}
