using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class DiscountCode
    {
        //instance fields
        private string _code;
        private float _discount;


        //Constructor
        public DiscountCode(string code, float discount)
        {
            _code = code;
            _discount = discount;
        }

        //property 1
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        //property 2
        public float Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

    }

}
