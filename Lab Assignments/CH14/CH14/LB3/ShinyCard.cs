using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class ShinyCard : ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;
        private System.Drawing.Font _font;
        private System.Drawing.Color _backcolor;
        private System.Drawing.Color _forecolor;
        // Constructor
        public ShinyCard(string name, System.Drawing.Image image, double value, System.Drawing.Font font, System.Drawing.Color backcolor, System.Drawing.Color forecolor)
        {
            _name = name;
            _image = image;
            _value = value;
            _font = font;
            _backcolor = backcolor;
            _forecolor = forecolor;
        }
        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image; 
            label.Text = _name; 
            label.Font = _font; // Set the font of the label
            label.BackColor = _backcolor; // Set the background color of the label
            label.ForeColor = _forecolor; // Set the foreground color of the label
        }

        public int CompareTo(ICard card)
        {

            if (Value > card.Value)
                return 1; // This card is greater
            else if (Value < card.Value)
                return -1; // This card is lesser
            else
                return 0; // They are equal
        }
        // Properties
        public string Name
        {
            get { return _name; }
        }
        public System.Drawing.Image Image
        {
            get { return _image; }
        }
        public double Value
        {
            get { return _value; }
        }
    }
}
