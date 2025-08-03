using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Order
    {
        public Occasion SelectedOccasion { get; set; }
        public Style SelectedStyle { get; set; }
        public bool AddEnvelope { get; set; }
        public bool AddStamp { get; set; }
        public bool AddCustomMessage { get; set; }
        public string CustomMessage { get; set; }

        public decimal CalculateTotal()
        {
            decimal total;
            if (SelectedStyle != null)
            {
                total = SelectedStyle.Price;
            }
            else
            {
                total = 0;
            }
            if (AddEnvelope)
            { 
                total = total + 0.25m;
            }
            if(AddStamp)
            {
                total += 0.50m;
            }
            if(AddCustomMessage)
            {
                total += 0.25m;
            }
            return total;

        }

    }
}
