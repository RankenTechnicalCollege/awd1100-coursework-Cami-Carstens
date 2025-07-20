using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    internal class MattedPhoto : Photo
    {
        protected Color _color;
        const float MATTED_SURCHARGE = 10f;

        
        public MattedPhoto(float width, float height, Color color) : base(width, height)
                                                    // Pass to the base constructor
        {
            _color = color;
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        
        public override float Price
        {
            get { return base.Price + MATTED_SURCHARGE; } // Add a surcharge for matted photos
        }
        public override string ToString()
        {
            return base.ToString() + $", Matted, {_color}";
        }
    }
}
