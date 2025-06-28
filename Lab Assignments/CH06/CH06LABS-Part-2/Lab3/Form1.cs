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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string input = txtBid.Text;
            string result = ParseBid(input); //call method

        }

        private string ParseBid(string bidString)
        {
            if(bidString == "")
            {
                return lblResult.Text = $"Invalid Bid";
            }

            //need to remove unwanted text- maybe with cleaned?
            string cleaned = bidString; //"clean" the entered string of text thats not needed

            //if $ sign was entered maybe use .Contains to check?
            if(cleaned.Contains("$")) //check if the cleaned phrase contain a $ sign
            {
                cleaned = cleaned.Replace("$", "");//make new cleaned phrase replace all $ signs

            }
            if(cleaned.Contains("dollars"))//checks if input contains the word dollars
            {
                cleaned = cleaned.Replace("dollars", ""); //replace the word dollars, if entered 

            }
            //new cleaned phrase without any extra spaces
            cleaned = cleaned.Trim(); //get rid of extra spaces if entered

            // now after everything is cleaned try to turn into an appliable number
            decimal bidAmount;

            //successful "cleaning", TryParse data into bidAmount
            bool success = decimal.TryParse(cleaned, out bidAmount);

            //if true/successful
            if(success)
            {
                if(bidAmount < 10) //bid must be at least 10.00
                {
                    return lblResult.Text= $"Your bid must be at least $10.00 ";

                }
                else
                {
                    return lblResult.Text= $"Your bid of {bidAmount:C} is accepted!";
                   
                }
            }
            else
            {
                return lblResult.Text= $"Invalid bid entry";
            }


        }
    }
}
