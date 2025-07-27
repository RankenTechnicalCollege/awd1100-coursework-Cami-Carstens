using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    internal class InvalidQuantityException : ArgumentException
    {
        public InvalidQuantityException(string message) :base(message) { }
    }
}
