using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Conference
    {
        //auto implented instance fields 
        public string Display()
        {
            //get rid of the time display
            return $"({Attendees} attendees) For-- {GroupName.ToUpper()} Conference \n on {StartingDate.ToShortDateString()} in {Room} ";
        }
        public string GroupName { get; set; }

        
        public DateTime StartingDate { get; set; }
        

        public int Attendees { get; set; }

        public Room Room { get; set; }

    }
}
