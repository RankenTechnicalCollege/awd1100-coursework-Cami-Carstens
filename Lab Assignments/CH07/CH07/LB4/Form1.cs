using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                //make new instance of decoder ring
                DecoderRing ringPhrase = new DecoderRing();

                //1
                ringPhrase.Shift = int.Parse(txtShift.Text);
                //2
                string encodeInput = ringPhrase.Encoder(txtEncode.Text);
               
               
                txtDecodePhrase.Text = encodeInput;
            }
            //1
            catch (InvalidCharacterException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //2
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                DecoderRing decodePhrase = new DecoderRing();
                decodePhrase.Shift = int.Parse(txtShift.Text);
                string decoded = decodePhrase.Decoder(txtDecodePhrase.Text);
               
                txtDecodePhrase.Text = decoded;
            }
            catch (InvalidCharacterException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message) ;
            }

        }
    }
}
