using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_TryingASubString
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            string ccNumber = txtCCInput.Text;
            string lastFour = ccNumber.Substring(ccNumber.Length - 4, 4);
            string hashedValues = "####-####-####";
            string result = hashedValues + lastFour;

            for (int i = ccNumber.Length - 4; i >= 0; i--)
            {
                char c = ccNumber[i];
                hashedValues += c;
            }

        }

    }
}
