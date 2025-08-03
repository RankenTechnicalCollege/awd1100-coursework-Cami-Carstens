using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class SuperHero
    {
        public string Name { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string SuperPower { get; set; }
        public string Biography { get; set; }
        public Image Image { get; set; }
        public string Url { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
