using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Mr Gudmestad hopefully this is ok. I wanted to try it with 
        //checkboxes instead of a textbox.
        //And I added a customization category to try to make my own method.
        //If it doesnt work like you wanted for the grade, I will redo it with a textbox instead. 
        
        

        private void button1_Click(object sender, EventArgs e)
        {
                                   //call methods
            string woodType = GetWood();
            int drawers = GetDrawers(); 
            double totalCost = CalculateTotalCost(woodType, drawers);
            double woodCost = CalculateWoodCost(woodType);
            double drawerCost = CalculateDrawerCost(drawers);
            double customizationCost = CalculateCustomizationCost();


            //Results
            lblResult.Text =  $"Wood Cost: {woodCost:C} \n" +
                              $"Drawer Cost: {drawerCost:C} \n" +
                              $"Customization Cost: {customizationCost:C} \n" +
                              $"Your Estimated Total Cost: {totalCost:C}";
        }
        
        //wood type method
        private string GetWood()
        {
            if (chkMahogany.Checked)
                return "mahogany";
            else if (chkOak.Checked)
                return "oak";
            else if (chkPine.Checked)
                return "pine";
            else 
                return "other";
        }

        //drawers method
        private int GetDrawers()
        {
            if (int.TryParse(txtDrawers.Text, out int drawers)
                && drawers >= 0)
            {
                return drawers;
            }
            else
            {
                lblResult.Text = $"Please enter a valid number of drawers.";
                return 0;
            }
        }

        //method for wood cost
        //I should have used radio buttons instead so only one could be checked at at time
        private double CalculateWoodCost(string woodType)
        {
            if (woodType == "pine")
            {
                return 100;
            }
            else if (woodType == "mahogany")
            {
                return 180;
            }
            else if (woodType == "oak")
            {
                return 140;
            }
            else
            {
                return 180;
            }

        }

        //method to calculate drawer cost
        private double CalculateDrawerCost(int numDrawers)
        {
            //each drawer cost $30
            return numDrawers * 30; 
        }

        //method to calculate added customization
        private double CalculateCustomizationCost()
        {
            double customCost = 0;

            //no customizations 
            if (chkOther.Checked)
                customCost = customCost + 50;
            //mirror price customization
            if (chkMirror.Checked)
                customCost = customCost + 50;
            //upgraded hardware
            if (chkHardware.Checked)
                customCost = customCost + 75;
            //custom paint details
            if (chkPaint.Checked)
                customCost = customCost + 100;
            //total custom cost 
            //multiples can be checked
            return customCost;
        }

        //calculate the total cost
        private double CalculateTotalCost(string woodType, int numDrawers) 
        {
            double woodCost = CalculateWoodCost(woodType); 
            double drawerCost = CalculateDrawerCost(numDrawers); 
            double customizationCost = CalculateCustomizationCost(); 
            double totalCost = woodCost + drawerCost + customizationCost; 

            return totalCost;

        }

    }
}
