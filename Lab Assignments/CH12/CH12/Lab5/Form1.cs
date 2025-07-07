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
        List<Job> jobList = new List<Job>();
        Job currentJob = null;
        public Form1()
        {
            InitializeComponent();
            jobList.Add(new Job("House cleaning", 10f, 25.00f));
            jobList.Add(new Job("Gutter cleaning", 5f, 30.00f));
            jobList.Add(new Job("Laundry", 3f, 15.00f));
            jobList.Add(new Job("Mowing the yard", 2f,40.00f));
            jobList.Add(new Job("Painting", 10f, 75.00f));
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

            Job existingJob = null;
            foreach (Job job in jobList)
            {
                if (job.Description.ToLower() == description.ToLower())
                {
                    existingJob = job;
                    break;
                }
            }
            if (existingJob != null)
            {
                existingJob.HoursToComplete = hours;
                existingJob.HourlyFee = rate;
                existingJob.CalculateTotal();
                currentJob = existingJob;
            }

            else
            {
                currentJob = new Job(description, hours, rate);
                currentJob.CalculateTotal();
                jobList.Add(currentJob);
               
            }
            lblResult.Text = $"Description:\n{currentJob.Description} \n\n Hours:\n {currentJob.HoursToComplete} \n\n Hourly Rate: \n{currentJob.HourlyFee:C}\n\n";
            txtTotalFee.Text = $"{currentJob.TotalFee:C}";

        }
    }
}
