using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            //users phrase input
            string phrase = txtPhraseInput.Text;
                     //.Split breaks a string into pieces. Break every time there is a space
//results of the split into a variable called words         //new char is creating a character array.
            string[] words = phrase.Split(new char[] { ' ' });

            //call method to sort words input
            SortWords(words);

            string results = "";

            foreach (string word in words)
            {
                              //Needs a space between result words
                results += word + " ";
            }

          txtResult.Text = results;

            lblResult.Visible = true;
            txtResult.Visible = true;
            btnClear.Visible = true;
        }
        private void SortWords(string[] unsortedWords)
        {
            Array.Sort(unsortedWords);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear inputs back to start
            txtPhraseInput.Text = "";
            txtResult.Text = "";

            lblResult.Visible=false;
            txtResult.Visible = false;
            btnClear.Visible = false;
            txtPhraseInput.Focus();
        }
    }
}
