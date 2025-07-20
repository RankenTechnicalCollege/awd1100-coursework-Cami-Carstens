using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        List<Letter> sentLetters = new List<Letter>();
        const int MAX_LETTERS = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblResult.Text = ""; 
            // #1)  Validate the recipient input
            string recipient = txtRecipient.Text.ToLower().Trim();
            if (string.IsNullOrWhiteSpace(recipient))
            {
                lblError.Text = "Please enter a recipient.";
                return;
            }

            //#2) validate date sent
            if(!DateTime.TryParse(txtSentDate.Text, out DateTime sentDate))
            {
                lblError.Text = "Please enter a valid date.";
                return;
            }

            //#3) validate tracking number
           if(sentLetters.Count >= MAX_LETTERS)
            {
                lblError.Text = "You have reached the maximum number of letters sent.";
                return;
            }

            //#4) check its a certified letter or regular
            Letter newLetter;

            //Certified Letter-if it has a tracking number
            if (!string.IsNullOrWhiteSpace(txtTrackingNumber.Text))
            {
                string trackingNumber = txtTrackingNumber.Text;
                //make new certified letter object
                newLetter = new CertifiedLetter(recipient, sentDate, trackingNumber);
                lblError.Text = "(Additional Fee for Certified Letter)";
            }
            //regular letter-make letter object
            else
            {
                newLetter = new Letter(recipient, sentDate);

            }

            //Letter added needs to go to beginning of List

            //will add new letter at the 0 index of the list
            sentLetters.Insert(0, newLetter);

            string letterList = "";

            foreach(Letter letterI in sentLetters)
            {
                //display each letter in the list
               letterList += letterI.ToString() + "\n";
            }
            //print to RTB 
            rtbLetterList.Text = letterList;
            lblResult.Text = "Letter sent successfully!";

            //clear the input fields
            txtRecipient.Clear();
            txtSentDate.Clear();
            txtTrackingNumber.Clear();
            txtRecipient.Focus();
        }
    }
}
