using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ReceiptResult : Form
    {
        public ReceiptResult(List<Book> books,decimal storeCredit)
        {
            InitializeComponent();
            DisplayReceipt(books, storeCredit);
        }

        private void DisplayReceipt(List<Book> priceResults, decimal storeCredit)
        {
            decimal totalPrice = 0;
            rtbResult.Clear();
            foreach (Book book in priceResults)
            {
                rtbResult.AppendText($"Book Name: {book.Name} \n Author: {book.Author}\n Genre:{book.Genre}\n  ");
                totalPrice += book.Price;
            }
            lblFinalCredit.Text = $"{storeCredit:C2}";
            lblTotalPrice.Text = $" {totalPrice:C2}";
        }
    }
}
