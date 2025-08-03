using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        Occasion[] selectedOccasions;
        public Form1()
        {
            InitializeComponent();

          


            //create the style options

            Style[] getWell =
                {
                new Style("Get Well-Option 1/Elmo", 4.99m, Properties.Resources.getWell ),
                new Style("Get Well-Option 2/Flowers", 3.99m, Properties.Resources.getWell2),
                new Style("Get Well-Option 3/Germs", 3.49m, Properties.Resources.getWell3)

            };
            Style[] birthday =
            {
            new Style("Birthday-Option 1/Cupcake", 2.99m, Properties.Resources.bday ),
            new Style("Birthday-Option 2/ Dinosaur", 4.49m, Properties.Resources.bday2 ),
            new Style("Birthday-Option 3/Balloons", 1.99m, Properties.Resources.bday3),
            new Style("Birthday-Option 3/Colorful", 4.99m , Properties.Resources.bday4 ),
        };
            Style[] happyHolidays =
            {
            new Style("Happy Holidays-Option 1/Snowflake", 1.29m, Properties.Resources.happyholidays ),
            new Style("Happy Holidays-Option 2/Colorful snowflake", 3.99m, Properties.Resources.happyholidays2 ),
            new Style("Happy Holidays-Option 3/Snowy village", 4.49m, Properties.Resources.happyholidays3)
        };
            Style[] thankYou =
            {
            new Style("Thank you-Option 1/Generic Black and white", 1.99m, Properties.Resources.thankYou ),
            new Style("Thank You-Option 2/Large Personalization", 2.29m, Properties.Resources.thankYou2),
            new Style("Thank you-Option 3/Hearts", 3.49m,Properties.Resources.thankYou3),
            new Style("Thank you-Option 4/Modern abstract", 4.49m, Properties.Resources.thankyou4 )
        };
            Style[] thinkingOfYou =
            {
            new Style("Thinking of you- Option 1/Ocean", 2.29m, Properties.Resources.Thinkingofyou),
            new Style("Thinking of you-Option 2/Flower Bouquet", 4.49m, Properties.Resources.thinkingofyou2),
            new Style("Thinking of you-Option 3/Heart", 1.99m, Properties.Resources.thinkingofyou3)
        };


            //create the occasions 
            selectedOccasions = new Occasion[]
                 {
                    new Occasion("Get Well",getWell),
                    new Occasion("Birthday", birthday),
                    new Occasion("Happy Holidays", happyHolidays),
                    new Occasion("Thank you", thankYou),
                    new Occasion("Thinking of you", thinkingOfYou)

                 };

            cboOccasion.Items.AddRange(selectedOccasions);

        
            txtCustomMessage.Enabled = true;
                lblPreviewMessage.Text = "";
                lblTotal.Text = "Cost: $0.00";

   }

        

        private void txtCustomMessage_TextChanged(object sender, EventArgs e)
        {
            lblPreviewResult.Text = txtCustomMessage.Text;
        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {

            //make datas match-cast in Occasion
            Occasion selectedOccasion = (Occasion)cboOccasion.SelectedItem;

            cboStyle.Items.Clear();
            cboStyle.Text = "";
            Occasion selectedOccasions = (Occasion)cboOccasion.SelectedItem;
            cboStyle.Items.AddRange(selectedOccasion.styles);
        }


      

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Style selected = (Style)cboStyle.SelectedItem;
           lblTotal.Text = selected.Price.ToString("c");
           pbCardSample.Image = selected.Image;

            UpdateTotal();
        }

        private void chkEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void chkStamp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomMessage.Enabled = chkCustom.Checked;
            if(!chkCustom.Checked)
            {
                txtCustomMessage.Text = "";
                lblPreviewMessage.Text = "";

            }
            UpdateTotal();

        }

        private void pbCardSample_Click(object sender, EventArgs e)
        {

        }

        //method for updated total

        public void UpdateTotal()
        {
            Order currentOrder = new Order
            {
                //1.)Get occasion selection, 2)style selection 3)check box Envelope
                //4)Checkbox Stamp 5)checkbox custom message 
                SelectedOccasion = (Occasion)cboOccasion.SelectedItem,
                SelectedStyle = (Style)cboStyle.SelectedItem,
                AddEnvelope = chkEnvelope.Checked,
                AddStamp = chkStamp.Checked,
                AddCustomMessage = chkCustom.Checked,
                CustomMessage = txtCustomMessage.Text

            };
            decimal total = currentOrder.CalculateTotal();
            lblTotal.Text = $"Cost: {total:C}";
        }

        //highligh the background light green
        private void Field_Enter(object sender, EventArgs e)
        {
            if(sender is Control c)
            {
                c.BackColor = Color.LightGreen;
            }
        }

        private void Field_Leave(object sender, EventArgs e)
        {
            if(sender is Control c)
            {
                c.BackColor = Color.White;
            }
        }

       
    }
}
