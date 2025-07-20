using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
  public class NormalCard : ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;


        //Constructor
        public NormalCard(string name, System.Drawing.Image image, double value)
        {
            _name = name;
            _image = image;
            _value = value;
        }

        //Method to show the card
        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image; // Set the image of the card
            label.Text = _name; // Set the name of the card
            label.BackColor = System.Drawing.Color.Transparent;
            label.ForeColor = System.Drawing.Color.Black; // Set the text color of the label
            label.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular); // Set the font of the label
        }
        // Method to compare cards based on their value
        public int CompareTo(ICard card)
        {

            if(Value > card.Value)
                return 1; // This card is greater
            else if (Value < card.Value)
                return -1; // This card is lesser
            else
                return 0; // They are equal
        }
        //Properties
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
