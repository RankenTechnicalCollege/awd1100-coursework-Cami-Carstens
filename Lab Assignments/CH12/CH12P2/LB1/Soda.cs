using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Soda
    {
        //instance fields //only 1 flavor allowed
        public const double BASE_PRICE = 1.75;
        public const double FLAVOR_PRICE = 0.15;

        private SodaFlavor _flavor;
        private double _price;

        //Properties
        public SodaFlavor Flavor
        {
            get { return _flavor; }
        }
        public double Price
        {
            get { return _price; }
        }
        //shorthand
        // public double Price => _price; means same as above.

        //Constructor
        public Soda()
        {
            _price += BASE_PRICE;
            _flavor = SodaFlavor.NONE; //default flavor
        }
        public void AddFlavor(SodaFlavor f)
        {
            _flavor = f;
            _price += FLAVOR_PRICE; //increase price for adding a topping
        }

    }
}
