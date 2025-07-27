using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventoryItemCrud.Models
{

              //primary constructor-newer syntax                  
    public class InventoryItem(int itemNo, string description, decimal price) : INotifyPropertyChanged
    {
        private int _itemNo=itemNo;
        private string _description=description;
        private decimal _price=price;

        public int ItemNo
        {
            get => _itemNo;
            set
            {
               _itemNo = value;
                //this is the instance of the inventory item that has changed, and event arguments with the name of the property that changed
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemNo"));
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PriceDisplay"));
            }
        }
        public string PriceDisplay => _price.ToString("C");
        

        //public InventoryItem(int itemNo, string description, decimal price)
        //{
        //    ItemNo = itemNo;
        //    Description = description;
        //    Price = price;
        //}

        //event has to be fired and then listened to in the XAML
        //this is creating an event that will be triggered when a property changes
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
