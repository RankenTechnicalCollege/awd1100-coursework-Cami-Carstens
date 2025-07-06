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
        Job currentJob = null;
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            grpValueBox.Visible = true;

            //check for errors or invalid data
            if (!float.TryParse(txtHours.Text, out float hours)
                || hours < 0)
            {
                lblResult.Text = "Invalid entry.";
                return;
            }

            if (!float.TryParse(txtHourlyRate.Text, out float rate)
                || rate < 0)
            {
                lblResult.Text = "Invalid Entry";
                return;
            }
            else
            {
                currentJob = new Job(description, hours, rate);
                currentJob.Description = description;
                currentJob.HoursToComplete = hours;
                currentJob.HourlyFee = rate;
                currentJob.CalculateTotal();
            }
            lblResult.Text = $"Description:\n{currentJob.Description} \n\n Hours:\n {currentJob.HoursToComplete} \n\n Hourly Rate: \n{currentJob.HourlyFee:C}\n\n";
            txtTotalFee.Text = $"{currentJob.TotalFee:C}";

        }
    }
}
