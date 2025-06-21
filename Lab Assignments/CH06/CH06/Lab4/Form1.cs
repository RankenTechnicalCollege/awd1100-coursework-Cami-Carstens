using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        const double JOB_PRICE = 6;
        const int WALL_HEIGHT = 9;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLength.Text, out int length)
             && int.TryParse(txtWidth.Text, out int width))
            {                       
                                 //call methods
                int totalArea = CalculateTotalArea(length, width);
                double totalCost = CalculatePaintEstimate(totalArea);
                lblResult.Text = $" Total Area: {totalArea} sq ft. \n " +
                    $"Estimated Cost: {totalCost:C}";
            }
        }
        private int CalculateTotalArea(int length, int width)
        {
            int totalArea = (length * WALL_HEIGHT * 2) + (width * WALL_HEIGHT * 2);
            return totalArea;

           
        }

        private double CalculatePaintEstimate(int totalArea)
        {
            return (totalArea * JOB_PRICE);
        }
    }
}
