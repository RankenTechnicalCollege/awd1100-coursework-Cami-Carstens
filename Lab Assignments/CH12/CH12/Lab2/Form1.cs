using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {


        List<InventoryItem> clothesItem = new List<InventoryItem>(20)
        {
            new InventoryItem("Let Loose fleece short", 12345, 24.99m, 299.88m, 12),
            new InventoryItem("Destination boxy graphic tee", 23456, 17.97m,449.25m,25),
            new InventoryItem("Sunchaser contrast stitch pullover", 34567, 48.00m, 720.00m, 15),
            new InventoryItem("Stovepipe distressed wide leg jean", 45678, 58.98m, 707.76m, 12),
            new InventoryItem("Gingham barrel leg balloon pant", 56789, 34.98m, 699.60m,20)
        };
        public Form1()
        {
            string accessKey = "1234";
            InitializeComponent();
        }
        //Searching for an item by name and displaying results
        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtName.Text.ToLower();

            //loop through the list for the name 
            foreach(InventoryItem item in clothesItem)
            {
                if(item.getItemName().ToLower() == searchName) 
                {
                    lblResultName.Text = $"Name: {item.getItemName()} \n UPC:{item.getUpc()} \n Price: {item.getPrice():C}";

                }
            }
            lblResultName.Text = "Item was not found.";

        }


        //searching upc text box and printing results
        private void btnUpcSearch_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtUpc.Text, out int upc))
            {
                //loop through for the upc 
                foreach(InventoryItem item in clothesItem)
                {
                    if(item.getUpc() == upc)
                    {
                        lblResultUpc.Text = $"Name: {item.getItemName()} \\n UPC:{item.getUpc()} \\n Price: {item.getPrice():C}";
                    }
                }
                lblResultUpc.Text = "UPC was not found.";
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (clothesItem.Count >= 20)
            {
                lblError3.Text = "Error: Can only add up 20 items to inventory.";
                return;
            }
           //check access code to add items
           if(txtAccessKey3.Text != "1234")
            {
                lblError3.Text = "Access Key was incorrect. Try again.";
                return;
            }
            //if  list count is less than 20 and correct access code- add item
            string newName = txtNewName.Text;
            //parameter pattern- string,int,decimal,decimal,int
            if (!int.TryParse(txtNewUpc.Text, out int upc) ||
                !decimal.TryParse(txtNewPrice.Text, out decimal price) ||
                !decimal.TryParse(txtCostPerCase.Text, out decimal cost) ||
                !int.TryParse(txtUnitsPerCase.Text, out int units))
            {
                lblError3.Text = "Invalid";
                return;

            }
            clothesItem.Add(new InventoryItem(newName, upc, price, cost, units));
            lblItemAddSuccess.Text = "Item has been added";
        }
       
    }
}
