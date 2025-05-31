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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGpaInput.Text, out double gpa)
            && double.TryParse(txtTestInput.Text, out double testScore))
            {
                if (gpa >= 3.0 && testScore >= 60)
                {
                    lblResult.Text = $"Accepted";
                }
                else if (gpa < 3.0 && testScore >= 80)
                {
                    lblResult.Text = "Accepted";
                }
                else
                {
                    lblResult.Text = "Rejected";
                }

            }
        }
    }
}
