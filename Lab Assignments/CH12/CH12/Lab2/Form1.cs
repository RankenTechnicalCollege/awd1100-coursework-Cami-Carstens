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
        private string accessKey = "1234";

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
            
            InitializeComponent();
        }
        //Searching for an item by name and displaying results
       
        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtName.Text.ToLower().Trim();
            bool found = false;

            //loop through the list for the name 
            foreach(InventoryItem item in clothesItem)
            {
                string itemName = item.getItemName().ToLower();
                if(itemName.Contains(searchName)) //allow for a partial search
                {
                    lblResultName.Text = $" Name: {item.getItemName()} \n UPC:{item.getUpc()} \n Price: {item.getPrice():C}";
                   found = true;
                    break;

                }
            }
            if (!found)
           {
              lblResultName.Text = "Item was not found.";
           }
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
                        lblResultUpc.Text = $" Name: {item.getItemName()} \n UPC:{item.getUpc()} \n Price: {item.getPrice():C}";
                        return;
                    }
                }
                lblResultUpc.Text = "UPC was not found.";
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (txtAccessKey.Text != "1234")
            {
                lblError1.Text = "Access key was incorrect";
                return;
            }

            //if it fails to parse show error, otherwise it should move on
            if(!decimal.TryParse(txtNewPrice.Text, out decimal newPrice))
            {
                lblError1.Text = "Invalid entry,";
                return;

            }
            string searchedName = txtName.Text.ToLower();
            bool found = false;
                foreach(InventoryItem item in clothesItem)
                {
                    if( item.getItemName().ToLower().Contains(searchedName))
                    {
                        item.setPrice(newPrice);
                        found = true;
                    lblError1.Text = $"Price updated to {newPrice:C}";
                         
                          break;
                    }
                    if(!found)
                    {
                        lblError1.Text = "Item not found.";
                    }
                }
            }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtAccessKey2.Text != "1234")
            {
                lblError2.Text = "Access Key was incorrect";
                return;
            }

            if(int.TryParse(txtVerifyUpc.Text,out int upc))
            {
                for(int i = 0; i < clothesItem.Count; i++)
                {
                    if(clothesItem[i].getUpc() == upc)
                    {
                        clothesItem.RemoveAt(i);
                        lblError2.Text = "Item deleted";
                        return;
                    }
                } 
               
                }
            else
            {
                lblError2.Text = "Invalid UPC.";
            }
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
                lblItemAddSuccess.Text = "";
                lblError3.Text = "Access Key was incorrect. Try again.";
                return;
            }
            //if  list count is less than 20 and correct access code- add item
            string newName = txtNewName.Text;
            //parameter pattern- string,int,decimal,decimal,int
            if (!int.TryParse(txtNewUpc.Text, out int upc) ||
                !decimal.TryParse(txtNewStorePrice.Text, out decimal price) ||
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
