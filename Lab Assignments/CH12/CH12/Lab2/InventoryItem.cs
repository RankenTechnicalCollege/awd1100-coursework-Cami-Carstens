using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class InventoryItem
    {
       
            //instance fields
            private string _itemName;
            private int _upc;
            private decimal _price;
            private decimal _costPerCase;
            private int _unitsPerCase;

            //constructor field=value or whats changing goes on the left of =
            public InventoryItem(string itemName, int upc, decimal price, decimal costPerCase, int unitsPerCase)
            {
                _itemName = itemName;
                _upc = upc;
                _price = price;
                _costPerCase = costPerCase;
                _unitsPerCase = unitsPerCase;
            }
        //mutators //field = value
        public void setItemName(string itemName)
        {
            _itemName = itemName;
        }

        public void setUpc(int upc)
        {
            _upc = upc;
        }

        public void setPrice(decimal price)
        {
            _price = price;
        }
        public void setCostPerCase(decimal costPerCase)
        {
            _costPerCase = costPerCase;
        }
        public void setUnitsPerCase(int unitsPerCase)
        {
            _unitsPerCase = unitsPerCase;
        }

        //accessors
        public string getItemName()
        {
            return _itemName;
        }
        public int getUpc()
        {
            return _upc;
        }
        public decimal getPrice()
        {
            return _price;
        }
        public decimal getCostPerCase()
        {
            return _costPerCase;
        }
        public int getUnitsPerCase()
        {
            return _unitsPerCase;
        }

        }
    }

