using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab6
{
    public partial class Form1 : Form
    {
        //#2 use an array

        Room[] rooms = new Room[20];
        int roomCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            if(roomCount >= 20)
            {
                lblResult.Text = "Maximum number of 20 rooms reached.";
                return;
            }

            string roomName = txtName.Text;
            if(!int.TryParse (txtWidth.Text, out int width) || width <= 0)
            {
                lblResult.Text = "Invalid width. Please enter a positive integer.";
                return;
            }   
            if(!int.TryParse(txtLength.Text, out int length) || length <= 0)
            {
                lblResult.Text = "Invalid length. Please enter a positive integer.";
                return;
            }

            //create a new room object
            Room newRoom = new Room(roomName, width, length);
            rooms[roomCount] = newRoom; 
            roomCount++;

            lblResult.Text = newRoom.ToString();




            //clear the input fields
            txtName.Clear();
            txtWidth.Clear();
            txtLength.Clear();
        }
    }
}
