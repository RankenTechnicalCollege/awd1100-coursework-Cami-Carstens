using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public class Style
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public System.Drawing.Image Image { get; set; }

        public Style(string name, decimal price, System.Drawing.Image image ) 
        {
            Name = name;
            Price = price;
            Image = image;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
