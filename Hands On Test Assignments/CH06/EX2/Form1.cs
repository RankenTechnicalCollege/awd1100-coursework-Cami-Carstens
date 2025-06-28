using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        const double SHIRT_PRICE = 13.75;
        const double SALES_TAX = 0.08;

        List<DiscountCode> discounts = new List<DiscountCode>
        {
            new DiscountCode("8264", 0.30f),
            new DiscountCode("5679", 0.20f),
            new DiscountCode("6483", 0.10f)
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity)
                 && quantity > 0)
            {
                string discountInput = txtDiscount.Text;
                float discount = CheckDiscountCode(discountInput);
                ShowInvoice(quantity, discount);
                grpInvoice.Visible = true;
            }
            else
            {
                lblError.Text = $"Please enter a valid quantity.";
            }
        }

        private float CheckDiscountCode(string code)
        {
            for (int i = 0; i < discounts.Count; i++)
            {
                if (discounts[i].Code == code)
                {
                    return discounts[i].Discount;
                }
            }
            return 0.0f;

        }
      
         
        private void ShowInvoice(int quantity, float discountPercentage)
        {
            double firstTotal = quantity * SHIRT_PRICE;
            double discountAmount = firstTotal * discountPercentage;
            double subTotal = firstTotal - discountAmount;
            double tax = subTotal * SALES_TAX;
            double grandTotal = subTotal + tax;

            string discountResult;
            if (discountPercentage > 0)
            {
                discountResult = $"Discount applied {discountPercentage:P0} off / {discountAmount:C} off \n";
            }
            else
            {
                discountResult = $"No discount was applied";
            }
            lblResult.Text = $"Quantity: {quantity}\nPrice per shirt: {SHIRT_PRICE:C}\n" +
                discountResult;


            txtSubtotal.Text = $"{subTotal:C}";
            txtTax.Text = $"{tax:C}";
            txtTotal.Text = $"{grandTotal:C}";

        }
        //clear out form to start over
        private void ClearForm()
        {
            txtDiscount.Text = "";
            txtQuantity.Text = "";
            txtSubtotal.Text = "";
            lblResult.Text = "";
            lblError.Text = "";
            txtTotal.Text = "";
            txtTax.Text = "";
            grpInvoice.Visible = false;
            txtQuantity.Focus();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
