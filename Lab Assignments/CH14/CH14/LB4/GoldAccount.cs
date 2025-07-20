using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class GoldAccount : Account
    {

        public GoldAccount(string name, string pin, decimal balance) : base(name, pin, balance)
        {
        }

        public override decimal MinimumBalance()
        {
            return 5000.00m; // Minimum balance for Gold Account
        }
        public override decimal TransactionFee()
        {
 
            return 0.00m; //no fee for gold
        }

        public override string GetStatement()
        {
            return  $"Account Name: {Name}\n" +
                     $"Account Type: -----<><><>Gold Account<><><>-----\n" +
                    $"Balance: {Balance:C}\n";                                   
        }
        
        
    }
}
