using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Order
    {
        //instance fields

        private string _name;
        private Sundae _sundae;
        private Soda _soda;


        //Properties
        public string Name
        {
            get { return _name; }
          
        }
        //shorthand 
        //public string Name => _name;
        

             //data type  //identifier //value field
        public Soda Soda => _soda;
        public Sundae Sundae => _sundae;

        public double Price
        {
            get
            {
                double price = 0;
                if(_soda == null)
                {
                    //return just sundae price
                    price = _sundae.Price;

                }
                else if(_sundae == null)
                {
                    //return just soda price
                    price = _soda.Price;
                    return price;
                }
                
                else
                {
                    //return both
                    price = _sundae.Price + _soda.Price;
                }
                return price;
            }
        }
        //Methods
        public Order(string name, bool hasSundae, bool hasSoda)
        {
            //set first parameter
            _name = name;
            //check bool on first parameter
            if(hasSundae)
            {
                _sundae = new Sundae(); //true
            }
            else
            {
                _sundae = null; //no sundae false
            }
            //check bool on third parameter
            if (hasSoda)
            {
                _soda = new Soda(); //true
            }
            else
            {
                _soda = null; //no soda false
            }

        }
        
            
        }
    }


