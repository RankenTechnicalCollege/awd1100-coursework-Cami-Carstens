using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public class DecoderRing
    {
        private int _shift;
        private string _innerRing;
        private string _outerRing;

        public DecoderRing()
        {
            _outerRing = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Shift = 0;

        }

        public int Shift
        {
            get { return _shift; }
            set
            {
                if (value < 0 || value > 25)
                {
                    throw new ArgumentOutOfRangeException("Invalid shift");
                }

                _shift = value;

                //  change inner ring
                _innerRing = _outerRing.Substring(_shift) + _outerRing.Substring(0, _shift); 
            }
        }
        public string Decoder(string text)
        {
            text = text.ToUpper();
            StringBuilder builderPhrase = new StringBuilder();

            foreach (char c in text)
            {
                //getting errors so allow for spaces. 
                if(c == ' ')
                {
                    builderPhrase.Append(' ');
                    continue;
                }
                if(!char.IsLetter(c))
                {
                    throw new InvalidCharacterException("Message must only contain letters.");
                }

                //instructions #5) decoder--outer to inner ring
                int index = _outerRing.IndexOf(c); //find  in outer ring
                char originalChar = _innerRing[index];//replace char at index in inner ring
                //change/append phrase
                builderPhrase.Append(originalChar);
            }
            return builderPhrase.ToString();
       


        }
        public string Encoder(string text)
        {

            text = text.ToUpper();
            string result = "";

            //loop through each letter in message input
            foreach(char eachLetter in text)
            {
                //erroring when you have spaces in text, fix that!
                if(eachLetter ==  ' ')
                {
                    result = result + ' ';
                    continue;
                }
                if(eachLetter <  'A' || eachLetter > 'Z')
                {
                    throw new InvalidCharacterException("Invalid characters in message.");
                }

                //#4 instructions Encoder--inner to outer ring
                int index = _innerRing.IndexOf(eachLetter);//find it on inner ring

                char codeLetter = _outerRing[index];//replace same position on outer

                result = result + codeLetter;

            }
            return result;

        }
    }
}
