using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        //initilize loan parent, check if null in the button
        private ILoan currentNewLoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {

            lblResultAccumulation.Text = "";

        //Verify/Parse 1.)name, 2.)amount, 3.)check boxes

          //#1
        string name = txtName.Text.ToLower();
            if (string.IsNullOrWhiteSpace(name))
            {
                lblErrorResult.Text = "Please enter a valid name.";
                return;
            }

            //#2
            if (!double.TryParse(txtAmount.Text, out double balance)
                || balance <= 0)
            {
                lblErrorResult.Text = "Please enter a valid positive amount.";
                return;
            }

            //#3
            if (!chkShortTerm.Checked && !chkLongTerm.Checked)
            {
                lblErrorResult.Text = "Please select your loan type choice.";
                return;
            }
            if(chkShortTerm.Checked)
            {               //create a new loan object
                currentNewLoan = new ShortTermLoan(name, "Short Term", balance);
            }
            else if (chkLongTerm.Checked)
            {
                currentNewLoan = new LongTermLoan(name, "Long Term", balance);
            }
            else
            {
                lblErrorResult.Text = "Please select a long term or short term loan type.";
            }   

            DisplayLoan();
            lblErrorResult.Text = "";
            lblErrorResult2.Text = "";


        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if(currentNewLoan == null)
            {
                lblErrorResult2.Text = "Please create a loan first.";
                return;
            }
            //current entered loan, call on MakePayment method
            currentNewLoan.MakePayment();

            //new balance
            double balanceAfterPayment = currentNewLoan.Balance;

            //Display the updated loan information
            lblNewLoanAmount.Text = $"After the last payment the loan is down to: {balanceAfterPayment:C}"; 

            //Apply interest on current loan
            currentNewLoan.ApplyInterest();

            double balanceAfterApplyInterest = currentNewLoan.Balance;

            //Display interest accumulation
            lblResultAccumulation.Text = $"After the last interest accumulation the loan is now: {currentNewLoan.Balance:C}";


            //Check if loan is paid and display congrats message
            if(balanceAfterApplyInterest <= 0)
            {
                lblNewLoanAmount.Text = "Congratulations! Your loan is paid off.";
                lblResultAccumulation.Text = "";
                return;
            }


        }

        private void DisplayLoan()
        {
            

            if (currentNewLoan != null)
            {
                lblResultName.Text = $"{currentNewLoan.Name}";
                lblResultLoanAndAmount.Text = $"Loan Type: {currentNewLoan.Type} \n" + 
                    $"Balance: {currentNewLoan.Balance:C}";
                lblNewLoanAmount.Text = "";
                lblErrorResult.Text = ""; 
            }
            else
            {
                lblErrorResult.Text = "No loan created.";
            }
        }
    }
}
