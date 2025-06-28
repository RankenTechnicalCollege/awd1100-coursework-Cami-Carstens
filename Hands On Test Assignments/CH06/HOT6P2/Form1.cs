using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT6P2
{
    public partial class Form1 : Form
    {
        const double SHIRT_SMALL = 9.99;
        const double SHIRT_MEDIUM = 10.99;
        const double SHIRT_LARGE = 11.99;
        const double TAX_RATE = 0.07;

        int countSmall = 0;
        int countMedium = 0;
        int countLarge = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            //call method
            AddShirt("small");
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            //call method
            AddShirt("medium");
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            //Call method
            AddShirt("large");
        }

        //Methods
        //Adding shirts method
        private void AddShirt(string size)
        {
            switch (size)
            {
                case "small":
                    countSmall++;
                    break;
                case "medium":
                    countMedium++;
                    break;
                case "large":
                    countLarge++;
                    break;
            }
            ShowInvoice();

        }
        //method of showing invoice

        private void ShowInvoice()
        {
            double subTotal = (countSmall * SHIRT_SMALL) + (countMedium * SHIRT_MEDIUM) + (countLarge * SHIRT_LARGE);
            double tax = subTotal * TAX_RATE;
            double finalTotal = subTotal + tax;

            //clear previous
            lblInvoiceSmall.Text = "";
            lblInvoiceMedium.Text = "";
            lblInvoiceLarge.Text = "";

            //adding up the button click for shirts
            if (countSmall > 0)
            {
                lblInvoiceSmall.Text = $"{countSmall} Sm Shirts @ {SHIRT_SMALL:C}\n";
            }
            if (countMedium > 0) 
            {
                lblInvoiceMedium.Text = $"{countMedium} Md Shirts @ {SHIRT_MEDIUM:C}\n\n";
            }
            if(countLarge > 0)
            {
                lblInvoiceLarge.Text = $"{countLarge} Lg Shirts @ {SHIRT_LARGE:C}\n";

            }

            lblResultTotal.Text = $"Subtotal: {subTotal:C} \n Tax: {tax:C} \n Total: {finalTotal:C}";


           


        }

        //method for clearing out the order
        private void ClearOrder()
        {
            countSmall = 0;
            countMedium = 0;
            countLarge = 0;
            lblInvoiceSmall.Text = "";
            lblInvoiceMedium.Text = "";
            lblInvoiceLarge.Text = "";
            lblResultTotal.Text = $"Subtotal: 0.00 \n Tax: 0.00 \n Total: 0.00";
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }
    }
    }

