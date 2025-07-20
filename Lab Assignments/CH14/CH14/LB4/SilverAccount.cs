using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class SilverAccount : Account
    {
        public SilverAccount(string name, string pin, decimal balance) : base(name, pin, balance)
        {
        } 
        
        public override decimal MinimumBalance()
        {
            return 1000.00m; // Minimum balance for Silver Account
        }
    }
}
