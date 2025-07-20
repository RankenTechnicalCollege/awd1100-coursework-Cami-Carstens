using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class FramedPhoto : Photo
    {
        protected Material _material;
        protected Style _style;
        const float FRAME_SURCHARGE = 25f;

        public FramedPhoto(float width, float height, Material material, Style style)
            : base(width, height)
        {
            _material = material;
            _style = style;

        } 
        public Material Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public Style Style
        {
            get { return _style; }
            set { _style = value; }
        }
        //override and add virtual in parent class
       
        public override float Price => base.Price + FRAME_SURCHARGE;
        public override string ToString()
        {
            return base.ToString() + $", Framed,({_material}, {_style})";
            
        }
    } 
    }

