using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            lblError.Text = "";

            try
            {
                float weight = float.Parse(txtWeight.Text);
                if (weight < 70 || weight > 300)
                {
                    throw new InvalidWeightException("Invalid weight.");
                }

                float height = float.Parse(txtHeight.Text);
                if (height < 60 || height > 84)
                {
                    throw new InvalidHeightException("Invalid height.");
                }

                Bmi result = BmiCalculator.CalcBmi(weight, height);
                lblResult.Text = $"BMI: {result.BmiValue:F2} \n\nCategory: {result.WeightCategory}";

            }
            catch (FormatException)
            {
                bool weightInputFail;
                if (!float.TryParse(txtWeight.Text, out float weight))
                {
                    weightInputFail = true;
                }
                else
                {
                    weightInputFail = false;
                }
                if (weightInputFail) 
                {
                    lblError.Text = "Invalid Weight";
                }


                bool heightInputFailed;
                if (!float.TryParse(txtHeight.Text, out float height))
                {
                    heightInputFailed = true;
                }
                else
                {
                    heightInputFailed = false;
                }
                if (heightInputFailed) 
                {
                    lblError.Text = "Invalid Height";
                }

            }
            catch(InvalidWeightException ex)
            {
                lblError.Text = ex.Message;
            }
            catch(InvalidHeightException ex)
            {
                lblError.Text = ex.Message;
            }
   
            }

        }
    }


