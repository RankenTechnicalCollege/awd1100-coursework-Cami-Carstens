using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        string[] zipCodes = new string[10];
        int[] deliveryFee = new int[10];
      


        public Form1()
        {
            InitializeComponent();

            zipCodes[0] = "63101";
            zipCodes[1] = "63103";
            zipCodes[2] = "63105";
            zipCodes[3] = "63109";
            zipCodes[4] = "63113";
            zipCodes[5] = "63118";
            zipCodes[6] = "63130";
            zipCodes[7] = "63133";
            zipCodes[8] = "63136";
            zipCodes[9] = "63137";

            deliveryFee[0] = 20;
            deliveryFee[1] = 12;
            deliveryFee[2] = 25;
            deliveryFee[3] = 15;
            deliveryFee[4] = 10;
            deliveryFee[5] = 23;
            deliveryFee[6] = 18;
            deliveryFee[7] = 20;
            deliveryFee[8] = 17;
            deliveryFee[9] = 12;
        }

        private void btnZipEntry_Click(object sender, EventArgs e)
        {
            string userZip = txtZipEntryBox.Text;
            bool found = false;


            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (userZip == zipCodes[i]) 
                { txtFeeResult.Text = $"{deliveryFee[i]:C}";
                    found = true;
                    break;
                }
                if (!found)
                {
                    txtFeeResult.Text = "Zip code not found.";
                }


                //if (zipCodes[i] == "63101")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[0]:C}";
                //    found = true;
                //    break;
                //}
                //else if (zipCodes[i] == "63103")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[1]:C}";
                //    found = true;
                //    break;
                //}
                //else if (zipCodes[i] == "63105")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[2]:C}";
                //    found = true;
                //    break;
                //}
                //else if (zipCodes[i] == "63109")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[3]:C}";
                //    found = true;
                //    break;
                //}
                //else if (zipCodes[i] == "63113")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[4]:C}";
                //    found = true;
                //    break;
                //}
                //else if(zipCodes[i] == "63118")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[5]:C}";
                //    found = true;
                //    break;
                //}
                //else if( zipCodes[i] == "63130")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[6]:C}";
                //    found = true;
                //    break;
                //}
                //else if(zipCodes[i] == "63133")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[7]:C}";
                //    found = true;
                //    break;
                //}
                //else if(zipCodes[i] == "63136") {
                //    txtFeeResult.Text = $"{deliveryFee[8]:C}";
                //    found = true;
                //    break;
                //}
                //else if (zipCodes[i] == "63137")
                //{
                //    txtFeeResult.Text = $"{deliveryFee[9]:C}";
                //    found = true;
                //    break;
                //}
                //else
                //{
                //    txtFeeResult.Text = $"Zip not found.";
                //}
            }
        }
    }
}
