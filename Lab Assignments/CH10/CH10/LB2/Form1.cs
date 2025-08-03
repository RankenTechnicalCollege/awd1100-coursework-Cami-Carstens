using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        Industry[] selectedIndustries;

        Job[] itJobs =
        {
            new Job("Junior Software Engineer", new LinkLabel.Link() {LinkData="https://www.glassdoor.com/Job/software-engineer-jobs-SRCH_KO0,17.htm?utm_source=google&utm_medium=cpc&utm_campaign=search_rau_nonbrand_job_specific&gad_source=1&gad_campaignid=22739696554&gbraid=0AAAAApDj--fDuLSFvSDKZk0ums9kpfbt6&gclid=Cj0KCQjwhafEBhCcARIsAEGZEKL1vOmXXv3VdhrN4z4WpvaoIUaHbBp_SYOGsbd4ZIoXquh_bbpk9XIaAqBPEALw_wcB"}),
            new Job("Junior Web Developer", new LinkLabel.Link(){LinkData="https://www.ziprecruiter.com/Jobs/Junior-Software-Developer-No-Experience/-in-St-Louis,MO?tsid=101050095&utm_source=dgljs"}),
            new Job("Quality Assurance Specialist", new LinkLabel.Link() {LinkData="https://www.ziprecruiter.com/Jobs/Quality-Assurance-Specialist/--in-Missouri"})

        };
        Job[] autoJobs =
        {
            new Job("Automotive Mechanic", new LinkLabel.Link(){LinkData="https://jobs-bear.com/jobs?geo=us&utm_source=google&utm_campaign=jobListWithKeyword10KUS&keyword=mechanic%20jobs&campaignid=12289988543&adgroupid=116097690183&feeditemid=&targetid=kwd-11137181&locinterest=&locpysical=9022817&matchtype=b&gad_source=1&gad_campaignid=12289988543&gbraid=0AAAAAC0JyllP1nTVNBH-d43z8OZVasJT0&gclid=Cj0KCQjwhafEBhCcARIsAEGZEKLtW-OCP8epDBwQLkpb0swra8cC6egTnYEhJsoSsGNxgt7PICDtxFUaAuqNEALw_wcB#finishLoadignJobs"}),
            new Job("Automotive Technician", new LinkLabel.Link() {LinkData="https://www.ziprecruiter.com/Jobs/Automotive-Technician"}),
          
        };
        Job[] hvacJobs =
        {
            //new creates the object. instaniates it
            new Job("Hvac Installer", new LinkLabel.Link() {LinkData="https://www.joblist.com/j/hvac-installer-jobs?utm_source=test&msclkid=2ed59a333b51171ab017f2b9a3a1e440"})
        };
        public Form1()
        {
            InitializeComponent();
            lstIndustries.Items.AddRange(new Industry[]
            {
                new Industry("Information Technology", itJobs),
                new Industry("Automotive", autoJobs),
                new Industry("HVAC", hvacJobs)

            });

        }

        private void lstIndustries_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dimension selected industries array to the number of selections
            selectedIndustries = new Industry[lstIndustries.SelectedItems.Count]; 

            for (int i = 0; i < lstIndustries.SelectedItems.Count; i++)
            {
                selectedIndustries[i] = (Industry)lstIndustries.SelectedItems[i]; 
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmJobList jobList = new FrmJobList(selectedIndustries);
            jobList.ShowDialog();
        }
    }
}
