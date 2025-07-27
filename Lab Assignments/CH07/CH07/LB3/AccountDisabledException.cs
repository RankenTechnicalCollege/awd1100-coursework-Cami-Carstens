using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    internal class AccountDisabledException : Exception
    {
        public AccountDisabledException(string message) :base(message) { }
    }
}
