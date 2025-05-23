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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (eggInput1.Text != "" && eggInput2.Text != "" && eggInput3.Text != "" && eggInput4.Text != "")
            {
                int egg1 = int.Parse(eggInput1.Text);
                int egg2 = int.Parse(eggInput2.Text);
                int egg3 = int.Parse(eggInput3.Text);
                int egg4 = int.Parse(eggInput4.Text);

                int totalEggs = egg1 + egg2 + egg3 + egg4;
                int dozen = totalEggs / 12;
                int remainder = totalEggs % 12;

              
                lblResult.Text = $"Total egg count is {totalEggs} or {dozen} dozen and {remainder} eggs";
            }
            else
            {
                lblResult.Text = "Please enter valid numbers for all four chickens.";
            }

            
          

        }
    }
}
