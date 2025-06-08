using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        string[] salesPerson = new string[3];
        string[] salesInitial = new string[3];
        double[] salesTotal = new double[3];
        
        public Form1()
        {
            InitializeComponent();

            salesPerson[0] = "Danielle";
            salesPerson[1] = "Edward";
            salesPerson[2] = "Francis";
        }
        //danielles button
        private void button1_Click(object sender, EventArgs e)
        {
            AddSale(0);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSale(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddSale(2);
        }
        private void AddSale(int index)
        {
            if(double.TryParse(txtSalesBox.Text, out double amount) && amount > 0)
            {
                salesTotal[index] += amount;
               UpdateDisplay();
            }
            else
            {
                lblResult.Text = $"Invalid. Please enter a valid positive number.";
            }
        }
        
        private void UpdateDisplay() //displaying results
        {
            double grandTotal = salesTotal.Sum();
            lblGrandTotal.Text = $"The grand total is: ${grandTotal:C}";

            int topSellerIndex = 0; //omparing to danielle and assuming danielle is the highest
            if (salesTotal[1] > salesTotal[topSellerIndex]) 
                topSellerIndex = 1;
            if (salesTotal[2] > salesTotal[topSellerIndex])
                topSellerIndex = 2;

            lblDanielle.Text = $"Danielle's sales: ${salesTotal[0]:C}";
            lblEdward.Text = $"Edward's sales: ${salesTotal[1]:C}";
            lblFrancis.Text = $"Francis's sales: ${salesTotal[2]:C}";

            lblTopSeller.Text = $"{salesPerson[topSellerIndex]} has the most sales.";
        }
    }
}
