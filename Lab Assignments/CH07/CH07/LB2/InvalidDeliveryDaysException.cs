using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    internal class InvalidDeliveryDaysException : ArgumentException
    {
        public InvalidDeliveryDaysException(string message) :base(message) { }
    }
}
