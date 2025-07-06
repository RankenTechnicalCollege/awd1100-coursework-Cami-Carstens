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
            

            Login(accNumber, pin);


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
            Logout();
            if (currentUser != null)
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
           
        }

        private void Login(string accountNumber, string pin)
        {
            currentUser = null; // Reset before checking

            foreach (Account accNum in accountNumbers)
            {
                if (accNum.GetAccountNumber() == accountNumber && accNum.GetPin() == pin)
                {
                    currentUser = accNum;
                    lblResult.Visible = true;
                    lblResult.Text = $"Login successful!\nWelcome, {accNum.GetName()}!\nYour balance is: {accNum.GetBalance():C}";
                    return;
                }
            }

            // If no match found, logout any user just in case and show error
            Logout();
            lblResult.Visible = true;
            lblResult.Text = "Login failed!\nPlease check your account number and PIN.";
        }

        private void Logout()
        {
            if (currentUser != null)
            {
                lblResult.Text = $"{currentUser.GetName()}\nYou have been logged out.";
            }
            else
            {
                lblResult.Text = "You are not logged in.";
            }

            currentUser = null;

            // Clear input fields
            txtAccount.Clear();
            txtPin.Clear();
            txtDeposit.Clear();
            txtWithdraw.Clear();
        }

    }
}
