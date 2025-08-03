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
    public partial class FrmJobList : Form
    {
        Industry[] _industries;

        public FrmJobList(Industry[] industries)
        {
            InitializeComponent();
            _industries = industries;
        }

        private void FrmJobList_Load(object sender, EventArgs e)
        {
            int ylocation = 10;
            foreach( Industry industryItem in _industries )
            {
                foreach(Job jobItem in industryItem.Jobs )
                {
                    //generate link lbl dynamically from code
                    LinkLabel label = new LinkLabel
                    {
                        Text = jobItem.JobTitle,
                        //location of label
                        Location = new Point( 10, ylocation ),
                        AutoSize = true
                    };
                    //add the label
                    label.Links.Add(jobItem.Link);

                    //wiring event handler
                    label.LinkClicked += Label_LinkClicked;

                    
                    ylocation += 20;
                    //add to collection of controls on form
                    this.Controls.Add(label);
                }
            }

        }

        private void Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //clicking link
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
