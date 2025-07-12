using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        //create order object
        Order anOrder;
        double grandTotal = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            //get name from textbox-parameter #1
            string name = txtName.Text;

            //get bool from checkbox-parameter #2 and #3 
            if ((chkSundae.Checked || chkSoda.Checked) && !String.IsNullOrEmpty(name))
            {
                bool isValid = true;
                //create/instanciate an order-instance of an Order
                lblNameOrFoodError.Visible = false;

                anOrder = new Order(name, chkSundae.Checked, chkSoda.Checked);

                if (chkSundae.Checked)
                {
                    if (chkSprinkles.Checked && chkNuts.Checked && chkChocolateSyrup.Checked)
                    {
                        //error if all toppings are checked
                        lblToppingsError.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        //Add toppings
                        lblToppingsError.Visible = false;
                        //add toppings to sundae
                        if (chkSprinkles.Checked)
                        {                                              //CAPITALIZE ENUMS
                            anOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES);
                        }
                        if (chkNuts.Checked)
                        {
                            anOrder.Sundae.AddTopping(SundaeTopping.NUTS);
                        }
                        if (chkChocolateSyrup.Checked)
                        {
                            anOrder.Sundae.AddTopping(SundaeTopping.CHOCOLATE_SYRUP);
                        }
                    }
                }

                    if (chkSoda.Checked)
                    {
                        if (chkLime.Checked && chkPeach.Checked || chkLime.Checked && chkMango.Checked || chkPeach.Checked && chkMango.Checked)
                        {
                            //too many mixins
                            lblMixinError.Visible = true;
                            isValid = false;

                        }
                        else
                        {
                            //add mixins to soda
                            lblNameOrFoodError.Visible = false;
                            if (chkLime.Checked) anOrder.Soda.AddFlavor(SodaFlavor.LIME);
                            if (chkPeach.Checked) anOrder.Soda.AddFlavor(SodaFlavor.PEACH);
                            if (chkMango.Checked) anOrder.Soda.AddFlavor(SodaFlavor.MANGO);
                        }
                    }
                //Display order information
                if (isValid)
                {

                    //Out put total price
                    grandTotal += anOrder.Price;
                    lblTotalPrice.Text = grandTotal.ToString("C");
                    //Output name
                    rtbOutput.Text += anOrder.Name;
                    rtbOutput.Text += "\n -------------------------------------------\n";



                    if (anOrder.Soda == null)
                    {

                        DisplaySundae();
                        rtbOutput.Text += "\n";


                    }
                    else if (anOrder.Sundae == null)
                    {
                        //soda output
                        DisplaySoda();
                        rtbOutput.Text += "\n";

                    }
                    else
                    {
                        DisplaySoda();
                        DisplaySundae();
                        rtbOutput.Text += "\n";
                    }
                }

             }
                else
                {
                    lblNameOrFoodError.Visible = true;
                }
            }
        
        private void DisplaySundae()
        {
            //sundae output

            rtbOutput.Text += "SUNDAE --";

            int toppingCount = anOrder.Sundae.ToppingCount;

            if (toppingCount == 0)
            {
                rtbOutput.Text += anOrder.Sundae.GetTopping(0) + " - ";
            }

            else
            {
                for (int i = 0; i < toppingCount; i++)
                {
                    //get topping from sundae
                    rtbOutput.Text +=  anOrder.Sundae.GetTopping(i) + " ";
                }
                rtbOutput.Text += anOrder.Sundae.Price.ToString("C") + "\n ";
                rtbOutput.Text += "\n -------------------------------------------------\n";
            }
        }
        
        private void DisplaySoda()
        {
            rtbOutput.Text += "SODA -- ";

            rtbOutput.Text += anOrder.Soda.Flavor + " - ";

            rtbOutput.Text += anOrder.Soda.Price.ToString("C") + "\n";
        }
           
     

        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSundae.Checked)
            {
                grpSundaeToppings.Visible = true;
            }
            else
            {
                grpSundaeToppings.Visible = false;
            }
        }

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            //if checked mixins is set to true if not checked its set to false
            //does the same thing as the if/else statement above                      
            grpDrinkMixins.Visible = chkSoda.Checked ? true : false;
        }
    }
}
