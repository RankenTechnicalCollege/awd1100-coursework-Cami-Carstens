using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    //child to inherit from ILoan
    public class LongTermLoan : ILoan
    {
       
        //instance fields

        private string _name;
        private string _type;
        private double _balance;
        const double INTEREST_RATE = 0.05;
        const double PAYMENT_AMOUNT = 200;

        //Constructor
        public LongTermLoan(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }

        //Methods
        public void MakePayment()
        {
            _balance -= PAYMENT_AMOUNT; 

        }

        public void ApplyInterest()
        {
            _balance += _balance * INTEREST_RATE;
        }
        public double AccumulatedInterest()
        {
            double startingBalance = _balance / (1 + INTEREST_RATE);
            return _balance - startingBalance;
        }


        //Properties--Read only
        public string Name 
        {   
            get { return _name; }
        }
        public string Type 
        {   
            get { return _type; }
        }
        public double Balance
        {
            get { return _balance; }
        }


    }
}
