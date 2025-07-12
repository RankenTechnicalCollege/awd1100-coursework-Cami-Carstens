using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Sundae
    {
        //instance fields
        public const double BASE_PRICE = 4.50;
        public const double TOPPING_PRICE = 0.50;
        private SundaeTopping[] _toppings;
        private int _toppingCount;
        private double _price;

        //Properties
        public int ToppingCount
        {
            get { return _toppingCount; }
        }
        public double Price
        {
            get { return _price; }
        }

        //Constructor
        public Sundae()
        { 
            _toppingCount = 0;
            _price += BASE_PRICE;

            //2 toppings set to none
            _toppings = new SundaeTopping[2];
            _toppings[0] = SundaeTopping.NONE;
            _toppings[1] = SundaeTopping.NONE;

        }
        //method that passes in index and returns the topping array element
        public SundaeTopping GetTopping(int index)
        {
            return _toppings[index];
        }
        public void AddTopping(SundaeTopping t)
        {
            //add topping to the toppings array
            //t represents the topping to add
            _toppings[_toppingCount] = t;
            //increment topping count
            _toppingCount++;
            //increase the price for adding a topping
            _price += TOPPING_PRICE;
        }

    }
}
