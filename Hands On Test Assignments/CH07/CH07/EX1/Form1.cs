using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {

        //statistics object
        TestStatistics scoreStatistics = new TestStatistics();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int count = 0;
            float sum = 0;
            float avg = sum/count;
            float min = float.MinValue;
            float max = float.MaxValue;

            // Validate input
            if(float.TryParse(txtScore.Text, out float score))
            {
                try
                {
                    scoreStatistics.AddScore(score);
                    lblResult.Text = scoreStatistics.ToString();
                }
                catch (ArgumentException ex)
                {
                    lblError.Text = ex.Message;
                }
            }
            else
            {
                lblError.Text = "Please enter a valid score.";
            }
            





        }

    }
}
