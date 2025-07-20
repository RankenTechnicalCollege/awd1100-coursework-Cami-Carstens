using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{

   

    public class Account
    {
        //I need a transactions list to keep track of all transactions in all accounts
        public List<string> Transactions = new List<string>();    


        private string _name;
        private string _pin;
        private decimal _balance;

        public Account(string name, string pin, decimal balance)
        {
            _name = name;
            _pin = pin;
            _balance = balance;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Pin
        {
            get { return _pin; }
            set { _pin = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public virtual decimal MinimumBalance()
        {
            return 0.0m; // Default minimum balance for a generic account
        }
        public virtual decimal TransactionFee()
        {
            //1%
            return 0.01m; // Default transaction fee for a regular account
        }

        

        public virtual bool Withdraw(decimal amount)
        {
            decimal fee = amount * TransactionFee();
            decimal total = amount + fee;

            if (_balance - total >= MinimumBalance())
            {
                _balance -= total;
                Transactions.Add($"Withdraw: {amount:C}, Fee: {fee:C}");
              
                return true;
            }
            return false;
        }
        public virtual void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            Transactions.Add($"Deposit: {amount:C}");

            //only store 10 transactions
            if (Transactions.Count > 10)
            {
                Transactions.RemoveAt(0);
                Transactions.Add($"Deposit: {amount:C}");

            }


        }



        public virtual string GetStatement()
        {
            return $"Balance: {Balance:C}";
        }
    }
}
