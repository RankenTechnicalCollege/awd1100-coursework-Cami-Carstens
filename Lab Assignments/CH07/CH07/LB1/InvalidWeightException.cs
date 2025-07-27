using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    internal class InvalidWeightException : ArgumentException
    {
        public InvalidWeightException(string message) :base(message) 
        {
        }
    }
}
