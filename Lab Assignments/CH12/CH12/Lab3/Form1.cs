using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        List<Account> accountNumbers = new List<Account>();
         Account currentUser = null;

        public Form1()
        {
            InitializeComponent();

            accountNumbers.Add(new Account("123456789", "1234", "John Dally", 1000.00m));
            accountNumbers.Add(new Account("987654321", "4321", "Jane Smith", 50000.00m));
            accountNumbers.Add(new Account("111222333", "1111", "Alice Johnson", 750.00m));
            accountNumbers.Add(new Account("444555666", "2222", "Bob Brown", 3005.00m));
            accountNumbers.Add(new Account("777888999", "3333", "Charlie White", 12000.00m));
            accountNumbers.Add(new Account("000111222", "4444", "David Green", 80000.00m));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accNumber = txtAccount.Text;
            string pin = txtPin.Text;
            currentUser = null; // Reset before checking

            //class            //list items
            foreach (Account acc in accountNumbers)
            {
                if(acc.GetAccountNumber() == accNumber && acc.GetPin() == pin)
                {
                   lblResult.Visible = true;
                   currentUser = acc;
                    lblResult.Text = $" Login successful!\n Welcome, { acc.GetName()} \n Your balance is: {acc.GetBalance():C}";
                    return;
                }

            }
            if (currentUser == null)
            {
                lblResult.Visible = true;
                lblResult.Text = "Login failed!\n Please check your account number and PIN.";
            }



        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                lblResult.Text = "Please log in first.";
                return;

            }
            //if logged in is uccessful parse data
            if(decimal.TryParse(txtDeposit.Text, out decimal amount) 
                && amount > 0)
            {
                currentUser.MakeDeposit(amount);
                lblResult.Text = $" Deposit successful! \n Deposit: {amount:C} \n New balance: {currentUser.GetBalance():C}";
            }
            else
            {
                lblResult.Text = "Invalid deposit amount. Please enter a positive number.";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(currentUser == null)
            {
                lblResult.Text = "Please log in first.";
                return;
            }
            if (decimal.TryParse(txtWithdraw.Text, out decimal amount)
                && amount > 0)
            {
                decimal newBalance = currentUser.MakeWithdraw(amount);
                
                if (newBalance < currentUser.GetBalance() + amount)
                {
                    lblResult.Text = $" Withdrawal successful!\n Withdrawn: {amount:C} \n New balance: {newBalance:C}";
                    txtDeposit.Clear();
                }
            
                
                else
                {
                    lblResult.Text = "Insufficient funds for withdrawal.";
                }

            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(currentUser != null)
            {
               
                lblResult.Text = $"{currentUser.GetName()}\nYou have been logged out.";
                //set user back to null
                currentUser = null;
                //clear fields
                txtAccount.Clear();
                txtPin.Clear();
                txtDeposit.Clear();
                txtWithdraw.Clear();
            }
            else
            {
                lblResult.Text = "You are not logged in.";
            }
        }
    }
}
