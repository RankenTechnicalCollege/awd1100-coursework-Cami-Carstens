using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_
{
    public class FlashCard


    {   //instance fields/variables
        private string _term;
        private string _definition;

        //constructor
        public FlashCard(string term, string definition)
        {
            _term = term;
            _definition = definition;
        }

        //methods
        public string GetTerm()
        {
            return _term;
        }
        public string GetDefinition()
        {
            return _definition;
        }


        
       
    }
}
