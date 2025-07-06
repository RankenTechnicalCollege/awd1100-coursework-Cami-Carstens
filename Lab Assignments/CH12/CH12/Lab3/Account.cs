using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Account
    {
        //instance fields
        private string _accountNumber;
        private string _pin;
        private string _name;
        private decimal _balance;

        //constructor
        public Account(string accountNumber, string pin, string name, decimal balance)
        {
            _accountNumber = accountNumber;
            _pin = pin;
            _name = name;
            _balance = balance;
        }
        //accessors
        public string GetAccountNumber()
        {
            return _accountNumber;
        }
        public string GetPin()
        {
            return _pin;
        }
        public string GetName()
        {
            return _name;
        }
        public decimal GetBalance()
        {
            return _balance;
        }

        //Methods
        public decimal MakeDeposit(decimal amount)
        {
            _balance = _balance + amount;
            return _balance;
        }
        public decimal MakeWithdraw(decimal amount)
        {
            //controlled modification
            if (amount <= _balance)
            {
                _balance = _balance - amount;

                //successful withdrawal
                return _balance;
            }
            //unsuccessful withdrawal
                return -1;
        }

    }
}
