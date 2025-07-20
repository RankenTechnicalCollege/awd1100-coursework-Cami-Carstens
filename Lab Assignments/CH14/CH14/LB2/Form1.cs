using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
     //#1) parse width
     // #2) parse height
            if (!float.TryParse(txtWidth.Text, out float width)
                || !float.TryParse(txtHeight.Text, out float height))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Please enter a valid entry.";
                return;
            }

            lblErrorMessage.Visible = false;
            Photo photo = null;


            //#3) Get frame radio button selection
            if (rdbMatted.Checked)
            {
                // #4) Get color selection
                Color color = Color.BLACK;

                if (rdbRed.Checked)

                    color = Color.RED;

                else if (rdbGreen.Checked)

                    color = Color.GREEN;

                else if (rdbBlue.Checked)
                    color = Color.BLUE;

                else if (rdbWhite.Checked)

                    color = Color.WHITE;

     // #5) Create new matted photo object
                photo = new MattedPhoto(width, height, color);
            }

            else if (rdbFramed.Checked)
            {
                //#5) Get Material selection
                Material material = Material.PINE;
             
                if (rdbOak.Checked)

                    material = Material.OAK;

                else if (rdbSteel.Checked)

                    material = Material.STEEL;

                else if (rdbSilver.Checked)

                    material = Material.SILVER;
                else if (rdbGold.Checked)

                    material = Material.GOLD;


      // #6) Get Style selection
                Style style = Style.SIMPLE;
               
                if (rdbModern.Checked)
                {
                    style = Style.MODERN;
                }
                else if (rdbAntique.Checked)
                {
                    style = Style.ANTIQUE;
                }
                else if (rdbVintage.Checked)
                {
                    style = Style.VINTAGE;
                }
                else if (rdbEclectic.Checked)
                {
                    style = Style.ECLECTIC;
                }

         //create new framed picture object
                photo = new FramedPhoto(width, height, material, style);
            }

            // #7) if Unframed photo is selected
            else if (rdbUnframed.Checked)
            {
                photo = new Photo(width, height);
            }
     //#8) print the result in ToString
            lblOrderResult.Text = photo.ToString();
            lblCostResult.Text = $"COST: {photo.Price:C}";
        }
        
    }
}
    

