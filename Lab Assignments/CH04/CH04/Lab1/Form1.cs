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
        const double KM_PER_MILE = 1.6;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToKm_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (double.TryParse(txtBoxMiles.Text, out double miles))
            {
                double kilometers = KM_PER_MILE * miles;
                lblResult.Text = $"{miles} miles is {kilometers} kilometers";
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";

            }
        }

        private void btnToMiles_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxKm.Text, out double kilometers))
            {
                double miles = kilometers / KM_PER_MILE;
                lblResult.Text = $"{kilometers} kilometers is {miles} miles";
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";
            }
        }
    }
}




       