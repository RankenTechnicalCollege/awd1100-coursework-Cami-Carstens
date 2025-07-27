using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Order
    {
        private short _itemNumber;
        private byte _quantity;
        private byte _estimatedDeliveryDays;

        public Order(short itemNumber, byte quantity, byte estimatedDeliveryDays)
        {
            _itemNumber = itemNumber;
            _quantity = quantity;
            _estimatedDeliveryDays = estimatedDeliveryDays;
        }
        public short ItemNumber 
        { 
            get { return _itemNumber; } 
            set { _itemNumber = value; }
        }
        public byte Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public byte EstimatedDeliveryDays
        { 
            get { return _estimatedDeliveryDays; }
            set { _estimatedDeliveryDays = value; }
        }
        
    }
}
