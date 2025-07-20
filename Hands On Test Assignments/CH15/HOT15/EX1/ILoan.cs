using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public interface ILoan
    {

        //PARENT CLASS

        // Properties
        string Name { get; }
        string Type { get; }
        double Balance { get; }
        // Methods
        void MakePayment();
        void ApplyInterest();
       
    }
}
