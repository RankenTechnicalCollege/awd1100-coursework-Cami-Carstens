using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class Ability
    {
        //instance field 
        private string _name;

        // Constructor
        public Ability(string name)
        {
            _name = name;
        }

        // Property
        public string Name
        {
             get { return _name; }
        }
    }
}
