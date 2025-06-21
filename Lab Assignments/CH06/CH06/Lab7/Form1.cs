using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        //try list so it could be dynamic
        
        List<string> accountNumbers = new List<string> { "111222333", "444555666", "777888999", "112113114"};
        List<string> pinNumbers = new List<string> { "2222", "1234", "1111", "1212" };
        List<decimal> balance = new List<decimal> { 10000.00m, 1500.00m, 250.00m, 75000.00m };
        int currentUser = -1; //no one logged in, first index at 0
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            string accountNum = txtAccountNumber.Text;
            string pinNum = txtPinNumber.Text;

            //call login method
            Login(accountNum, pinNum);

        }
        private void Login(string accountNum, string pinNum) 
        {
            bool found = false;

            for (int i = 0; i < accountNumbers.Count; i++) 
            { 
               if (accountNumbers[i] == accountNum && pinNumbers[i] ==  pinNum)
                {
                    currentUser = i; //0
                    lblResult.Text = $"Welcome to Weyland Bank! Login was successful. Your balance is {balance[i]:C} ";
                    found = true;
                    break;

                }
            }
            if (!found)
            {
                Logout(); //call method
                lblResult.Text = "Invalid account number or PIN.";
            }

        }
        private void MakeDeposit(decimal depositAmount)
        {
            if (currentUser == -1)
            {
                lblResult.Text = $"Please login in";
                return;
            }
            else if (depositAmount <= 0)
            {
                lblResult.Text = $"Please enter a valid deposit amount.";
                return;
            }

            //calculate deposit
            decimal currentBalance = balance[currentUser];
            decimal newBalance = currentBalance + depositAmount;

            //store entry back into the list
            balance[currentUser] = newBalance;

            //print new balance
            lblResult2.Text = $"Deposit added. New balance: {newBalance:C}";

        }
        private void MakeWithdrawl(decimal withdrawlAmount) 
        {
            decimal currentBalance = balance[currentUser];
            if (currentUser != -1 && withdrawlAmount > 0)
            {
                if (currentBalance >= withdrawlAmount)
                {   //new amount after withdraw
                    decimal newBalance  = currentBalance - withdrawlAmount;
                    balance[currentUser] = newBalance;

                    //print new balance after withdraw
                    lblResult2.Text = $"Withdraw of {withdrawlAmount:C} was successful.\n New balance:{newBalance:C}";
                }
                else
                {
                    lblResult2.Text = $"Insufficient funds available.";
                }

            }
            else
            {
                lblResult.Text = $"You must login in first.";
            }

        }

        private void Logout()
        {
            currentUser = -1; //0 is first indexed user
            lblResult2.Text = $"Logged out. Thank you!";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDeposit.Text, out decimal depositAmount))
            {
                //call deposit method
                MakeDeposit(depositAmount);
            }
            else 
            {
                lblResult2.Text = $"Enter valid amount";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtWithdraw.Text, out decimal withdrawAmount))
            {
                //call withdrawal method
                MakeWithdrawl(withdrawAmount);
            }
            else
            {
                lblResult2.Text = $"Enter valid amount.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logout(); 
            lblResult.Text = String.Empty; //clear out login results so it doesnt stay on the screen after logging out
        }
    }
}
