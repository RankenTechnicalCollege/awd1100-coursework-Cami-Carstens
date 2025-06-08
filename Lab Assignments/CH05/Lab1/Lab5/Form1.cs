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
        string inputPhrase = "txtPhraseInput.Text";
        int vowelCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inputPhrase = txtPhraseInput.Text;
            int vowelCount = 0;


            for (int i = 0; i < inputPhrase.Length; i++)
            {
                char currentChar = inputPhrase[i];

                if (char.ToLower(currentChar) == 'a' 
                    || char.ToLower(currentChar) == 'e'
                    || char.ToLower(currentChar) == 'i'
                    || char.ToLower(currentChar) == 'o'
                    || char.ToLower(currentChar) == 'u')
                {
                    vowelCount++;
                   
                }
            }
            lblResult.Text = $"Vowel Count: {vowelCount}";
        }
    }
}
