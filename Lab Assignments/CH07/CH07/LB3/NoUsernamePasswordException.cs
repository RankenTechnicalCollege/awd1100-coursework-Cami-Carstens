using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    internal class NoUsernamePasswordException : Exception
    {
        public NoUsernamePasswordException(string message) : base (message) { }
    }
}
