using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Room
    {
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        public Room(string name, int width, int length)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = _width * _length;


            //checklist item #1) 1 box for every 12 square feet
            //#2) one for remainders %
            //#3) one for extra
            int neededBoxes = _area / 12; //#1

            if(_area % 12 != 0) //2
            {
                neededBoxes = neededBoxes + 1; //#2
            }
            _boxes = neededBoxes +1 ; //#3
        }
        //All read only properties
        public string Name
        {
            get { return _name; }
        }
        public int Width
        {
            get { return _width; }
        }
        public int Length
        {
            get { return _length; }
        }
        public int Area
        {
            get { return _area; }
        }
        public int Boxes
        {
            get { return _boxes; }
        }

        //try a ToString method to print
        public override string ToString()
        {
            return $"Room Name: {_name}\n\n" +
                $"Width: {_width} ft\n\n" +
                $"Length: {_length} ft\n\n" +
                $"Area: {_area} sq ft\n\n" +
                $"Boxes Needed: {_boxes}";
        }
    }
}
