using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblError.Text = "";
            try
            {
                short itemNumber = short.Parse(txtItemNumber.Text);
                if (itemNumber < 100 || itemNumber > 999)
                {
                    throw new InvalidItemNumberException("Invalid item number.");
                }
                byte itemQuantity = byte.Parse(txtQuantity.Text);
                if (itemQuantity < 1 || itemQuantity > 12)
                {
                    throw new InvalidQuantityException("Invalid quantity.");
                }
                byte itemDelivery = byte.Parse(txtEstimatedDelivery.Text);
                if (itemDelivery < 1 || itemDelivery > 30)
                {
                    throw new InvalidDeliveryDaysException("Invalid delivery day.");
                }
                lblResult.Text = "Order is valid.";
            }
            catch (FormatException)
            {
                bool validItemNumber = short.TryParse(txtItemNumber.Text, out short item);
                bool validItemQuantity = byte.TryParse(txtQuantity.Text, out byte quantity);
                bool validItemDelivery = byte.TryParse(txtEstimatedDelivery.Text, out byte delivery);

                if (!validItemNumber) lblError.Text = "Invalid item number.";
                else if (!validItemQuantity) lblError.Text = "Invalid item quantity.";
                else if (!validItemDelivery) lblError.Text = "Invalid item delivery date.";

            }
            catch (InvalidItemNumberException ex)
            {
                lblError.Text = ex.Message;
            }
            catch (InvalidQuantityException ex)
            {
                lblError.Text = ex.Message;
            }
            catch (InvalidDeliveryDaysException ex)
            {
                lblError.Text = ex.Message;
            }

        }
    }
}
