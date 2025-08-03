using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public class Occasion
    {
       

       
        private string _name;
        private Style[] _style;
        public Occasion(string name, Style[] styles)
        {
            _name = name;
            _style = styles;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Style[] styles
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
            }
        }

        public override string ToString()
        {
            return _name;
        }
        
    }
}
