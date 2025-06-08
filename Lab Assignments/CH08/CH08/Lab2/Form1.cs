using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        string[] nightStayed =
        {
            "1-2 nights",
            "3-4 nights",
            "5-7 nights",
            "8 or more nights"
        };

        int[] nightlyRate = new int[4];

        public Form1()
        {
            InitializeComponent();


            nightlyRate[0] = 200;
            nightlyRate[1] = 180;
            nightlyRate[2] = 160;
            nightlyRate[3] = 145;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNightEntry.Text, out int nights))
            {
                int rate = 0;

                for (int i = 0; i < nightStayed.Length; i++)
                {
                    if (nightStayed[i] == "1-2 nights" && nights >= 1 && nights <= 2)
                    {
                        rate = nightlyRate[i];
                        break;
                    }
                    else if (nightStayed[i] == "3-4 nights" && nights >= 3 && nights <= 4)
                    {
                        rate = nightlyRate[i];
                        break;
                    }
                    else if (nightStayed[i] == "5-7 nights" && nights >= 5 && nights <= 7)
                    {
                        rate = nightlyRate[i];
                        break;
                    }
                    else if (nightStayed[i] == "8 or more nights" && nights >= 8)
                    {
                        rate = nightlyRate[i];
                        break;
                    }
      
                }
                if (rate > 0)
                { 
                    int total = rate * nights;
                    txtNightlyCost.Text = $"{rate:C}";
                    txtTotalCost.Text = $"{total:C}";
                }
                else
                {
                    lblErrorMessage.Text = $"Invalid Entry.";
                }


            }
        }
    }
}
