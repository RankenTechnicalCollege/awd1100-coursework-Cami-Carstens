using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Photo
    {
        protected float _width;
        protected float _height;
        

        // Constructor to initialize width and height
        public Photo(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        
        public virtual float Price
        {
            get
            {
                if ((_width == 8 && _height == 10)
                    || (_width == 10 && _height == 8))
                {
                    return 3.99f;
                }
                else if ((_width == 10 && _height == 12)
                    || (_width == 12 && _height == 10))
                {
                    return 4.99f;
                }
                else
                {
                    return 9.99f;
                }
            }
            
        }
       

        public override string ToString()
        {
        
          return $"{_width}x{_height}";
        }
    }
      
   }
