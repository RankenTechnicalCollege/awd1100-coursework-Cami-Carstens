using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Game
    {
        private string _name;
        private string _publisher;
        private float _price;

        //constructor(has name name as class)
        public Game(string name, string publisher, float price)
        {
            _name = name;
            _publisher = publisher;
            _price = price;

        }
        public string GetName()
        {
            return _name;
        }
        public string GetPublisher() 
        {
            return _publisher;
        }
        public float GetPrice()
        {
            return _price;
        }
    }
}
