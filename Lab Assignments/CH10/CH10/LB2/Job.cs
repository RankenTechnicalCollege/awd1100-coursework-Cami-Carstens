using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public class Job
    {
        public string JobTitle { get; set; }
        public LinkLabel.Link Link { get; set; }

        public Job(string jobTitle, LinkLabel.Link link) 
        {
            JobTitle = jobTitle;
            Link = link;
        }

      
        
        public override string ToString()
        {
            return JobTitle;
        }
    }
}
