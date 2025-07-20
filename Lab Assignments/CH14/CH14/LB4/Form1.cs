using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        //list for accounts
        private List<Account> bankAccounts = new List<Account>();
        Account currentUser = null;
        public Form1()
        {
            InitializeComponent();
            bankAccounts.Add(new SilverAccount("Alice", "1234", 2000.00m));
            bankAccounts.Add(new GoldAccount("Bob", "5678", 2500000.00m));
            bankAccounts.Add(new Account("Charlie", "4321", 500.00m));
            bankAccounts.Add(new SilverAccount("Charlie", "4321", 1500.00m));
            bankAccounts.Add(new GoldAccount("Diana", "8765", 10000000.00m));
            bankAccounts.Add(new Account("Eve", "1111", 500.00m));
            bankAccounts.Add(new SilverAccount("Stephan", "9876", 2500.00m));
            bankAccounts.Add(new GoldAccount("Cynthia", "6655", 750000.00m));
            bankAccounts.Add(new Account("Edith", "9999", 750.00m));
            bankAccounts.Add(new GoldAccount("Maria", "7891", 1100750.00m));

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblDepositMessage.Text = "";
            lblWithdrawMessage.Text = "";
            txtDeposit.Text = "";
            txtWithdrawal.Text = "";
            //varify first 2 fields
            string name = txtName.Text;
            string pin = txtPin.Text;

            //loop through accounts
            foreach(Account account in bankAccounts)
            {
                if(account.Name == txtName.Text && account.Pin == txtPin.Text)
                {
                    currentUser = account; 
                    lblWelcome.Text = $"Welcome {account.Name}!";
                    lblBalanceResult.Text = $"Your balance is: {account.Balance:C}";
                    lblAccountType.Text = account.GetType().Name;
                    return;
                }
            }
            lblWelcome.Text = "Invalid name or pin. Please try again.";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtDeposit.Text, out decimal depositAmount))
            {
                currentUser.Deposit(depositAmount);
                lblDepositMessage.Text = $"Deposit successful. New balance: {currentUser.Balance:C}";
            }
            else
            {
                lblDepositMessage.Text = "Invalid deposit amount. Please enter a valid number.";
            }

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                lblWithdrawMessage.Text = "Please log in first.";
                return;
            }
            if (decimal.TryParse(txtWithdrawal.Text, out decimal withdrawAmount))
            {
                if (currentUser.Withdraw(withdrawAmount))
                {
                    lblWithdrawMessage.Text = $"Withdrawal successful. New balance: {currentUser.Balance:C}";
                }
                else
                {
                    lblWithdrawMessage.Text = "Insufficient funds for this withdrawal.";
                }
            }
            else
            {
                lblWithdrawMessage.Text = "Invalid withdrawal amount. Please enter a valid number.";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (currentUser is SilverAccount)
            {
              string output = string.Join("\n", currentUser.Transactions);
                //print in seperate output box
                MessageBox.Show(output, "STATEMENT: Last 10 Transactions");
            }

            else if (currentUser is GoldAccount)
            {
                string output = "*****<><><>GOLD  ACCOUNT<><><>**** \n\n" + string.Join("\n", currentUser.Transactions)+
                    "\n\nThank you for being a valued Gold Customer!";
                MessageBox.Show(output, "STATEMENT: Last 10 Transactions");
            } 
            else 
            {
                 lblAccountType.Text = "Standard Bronze Account";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "You have been logged out.";
            currentUser = null;
            txtName.Text = "";
            txtPin.Text = "";
            txtDeposit.Text = "";
            txtWithdrawal.Text = "";
            lblBalanceResult.Text = "";
            lblAccountType.Text = "";
            lblDepositMessage.Text = "";
            lblWithdrawMessage.Text = "";

        }
    }
}
