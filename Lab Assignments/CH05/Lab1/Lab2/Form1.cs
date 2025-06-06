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

namespace Lab2
{
    public partial class Form1 : Form
    {
        List <int> scoresInput = new List <int> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int sum = 0;
            const int highestCount = 999;
            int min = int.MaxValue;
            int max = int.MinValue;
            

            string input = txtScoreInput.Text;
            if (int.TryParse(txtScoreInput.Text, out int score))
            {
                if (score == 999)
                {
                    lblMessage.Text = "999 was entered. Entries stopped.";
                    return;
                }
                else if (score >= 0 && score <= 100)
                {
                    scoresInput.Add(score);
                    lblResult.Text = ""; //clear result
                }
                else
                {
                    lblMessage.Text = "Invalid entry. Please enter a number between 0-100. Or enter 999 to end entries.";
                }
            }
            else
            {
                lblMessage.Text = $"Invalid entry. Please enter a whole number.";

            }
            txtScoreInput.Focus();
            txtScoreInput.Clear();
        

            foreach (int i in scoresInput)
            {
                sum += i;
                if (i < min)
                    min = i;
                if (i > max) 
                    max = i;

            }
            double averageScore = (double) sum / scoresInput.Count;


            lblResult.Text = $"Scores: {scoresInput.Count}\n" +
                            $"Sum: {sum}\n" +
                            $"Average: {averageScore:F2} \n" +
                            $"Minimum: {min} \n" +
                            $"Maximum: {max} \n";





        }
    }
}
