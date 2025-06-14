using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hands_On_Test_CH08
{
    public partial class Form1 : Form
    {
        string[] firstName = new string[5];
        string[] lastName = new string[5];
        string[] phoneNumber = new string[5];
        public Form1()
        {
            InitializeComponent();
            firstName[0] = "Markel";
            firstName[1] = "Luiza";
            firstName[2] = "Bryony";
            firstName[3] = "Giraldo";
            firstName[4] = "Lowri";

            lastName[0] = "Diggory";
            lastName[1] = "Gunnar";
            lastName[2] = "Hester";
            lastName[3] = "Addy";
            lastName[4] = "Hari";

            phoneNumber[0] = "555-8390";
            phoneNumber[1] = "555-4618";
            phoneNumber[2] = "555-4440";
            phoneNumber[3] = "555-1687";
            phoneNumber[4] = "555-7763";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            string input = txtNameSearch.Text.ToLower();

            for (int i = 0; i < firstName.Length; i++)
            {
                if (firstName[i].ToLower().Contains(input) || lastName[i].ToLower().Contains(input))
                {
                    lblResult.Text = $" First Name: {firstName[i]} \n Last Name: {lastName[i]} \n Phone Number: {phoneNumber[i]}";
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                lblResult.Text = $"User not found.";



            }
        }
    }
}
