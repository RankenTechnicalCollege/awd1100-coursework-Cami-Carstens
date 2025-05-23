using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        const double PERCENT_RAISE = 1.04;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = (string)txtName1.Text;
            string name2 = (string)txtName2.Text;
            string name3 = (string)txtName3.Text;

            double salary1 = Convert.ToDouble(txtSalary1.Text);
            double salary2 = Convert.ToDouble(txtSalary2.Text);
            double salary3 = Convert.ToDouble(txtSalary3.Text);


            //employee 1
            double year1_1 = salary1;
            double year2_1 = year1_1 * PERCENT_RAISE;
            double year3_1 = year2_1 * PERCENT_RAISE;

            lblNameResult1.Text = name1;
            lblEmp1_Year1.Text = $"{year1_1:C}";
            lblEmp1_Year2.Text = $"{year2_1:C}";
            lblEmp1_Year3.Text = $"{year3_1:C}";

            //employee2 
            lblNameResult2.Text = name2;
            double year1_2 = salary2;
            double year2_2 = year1_2 * PERCENT_RAISE;
            double year3_2 = year2_2 * PERCENT_RAISE;

            lblEmp2_Year1.Text = $"{year1_2:C}";
            lblEmp2_Year2.Text = $"{year2_2:C}";
            lblEmp2_Year3.Text = $"{year3_2:C}";

            //employee3
            lblNameResult3.Text = name3;
            double year1_3 = salary3;
            double year2_3 = year1_3 * PERCENT_RAISE;
            double year3_3 = year2_3 * PERCENT_RAISE;
            lblEmp3_Year1.Text = $"{year1_3:C}";
            lblEmp3_Year2.Text = $"{year2_3:C}";
            lblEmp3_Year3.Text = $"{year3_3:C}";

        }
    }
}
