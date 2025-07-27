using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
 public class InvalidCharacterException: Exception
    {
        public InvalidCharacterException(string message) :base (message) { }
    }
}
