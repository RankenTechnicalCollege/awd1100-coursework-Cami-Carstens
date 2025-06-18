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

        string[] fortune = new string[8];

        public Form1()
        {
            InitializeComponent();
            fortune[0] = "Birthdays are like friends. The more you have the better.";
            fortune[1] = "Your smile is a treasure to all who know you.";
            fortune[2] = "You never hesitate to tackle the most difficult problems.";
            fortune[3] = "The most obvious solution is not always the best.";
            fortune[4] = "If you want the rainbow, you will have to tolerate the rain.";
            fortune[5] = "The early bird gets the worm. but the second mouse gets the cheese.";
            fortune[6] = "From listening comes wisdom and from repentance.";
            fortune[7] = "A smile is your personal welcome mat.";
        }

        private void btnFortune_Click(object sender, EventArgs e)
        {

            GenerateFortune();
        }
        private void GenerateFortune()
        { //first random fortune 
            Random rand = new Random();
            int firstFortune = rand.Next(fortune.Length);
            int secondFortune;

            //second random fortune, make sure there arent 2 repeats
            do
            {
                secondFortune = rand.Next(fortune.Length);
            }
            while (firstFortune == secondFortune);

            lblResult1.Text = $"{firstFortune} \n \n {secondFortune}";
        }
    }
}
    

