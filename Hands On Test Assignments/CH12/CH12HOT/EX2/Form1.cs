using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        Computer[] inputAddress = new Computer[10];

        public Form1()
        {
            InitializeComponent();
            inputAddress[0] = new Computer("My-Desktop", "1278.0235.0871.6589", 20, 21, 23, 25, 53, 80, 123, 389, 443);
            inputAddress[1] = new Computer("google-public-dns-a", "8888.8888.8888.8888", 53,25,89,6,789,2,65);
            inputAddress[2] = new Computer("ranken.edu", "4744.1246.9880,5789", 25, 80, 443);
            inputAddress[3] = new Computer("kirks-home", "5023.6778.2147.6582", 89,256,89,22, 2, 65, 3);
            inputAddress[4] = new Computer("microsoft.ddc-a", "2983.4552.5215.9898", 80, 443,334,336,339,3);
            inputAddress[5] = new Computer("amazon-warehouse","5221.9797.2387.5871", 80, 446,2,10,8,55);
            inputAddress[6] = new Computer("digitalgamer-land", "5299.1185.6577.2459", 65, 55,898,257,12,37,985,55,36);
            inputAddress[7] = new Computer("apple-storewestco", "6912.5298.6893.5675", 25, 65, 98, 65, 28, 97, 85, 35, 65, 22, 1, 5, 65, 25, 85);
            inputAddress[8] = new Computer("google-public-dns-b", "212.585.669.4145", 25, 78,85,6,23);
            inputAddress[9] = new Computer("barnesandnoble-public-dns-c", "255.252.656.256", 2, 5, 32, 65, 99, 74);

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
           
            string ipInput = txtIPAddress.Text;
            Computer foundComputer = ScanIpAddress(ipInput);
            ShowComputer(foundComputer);
           

        }
        public Computer ScanIpAddress(string ipAddress)
        {
           
            for (int i = 0; i < this.inputAddress.Length; i++)
            {
                if (inputAddress !=null
                    
                    
                    && inputAddress[i].IpAddress == ipAddress)
                {
                    return inputAddress[i];
                }
            }
            return null;

        }
        public void ShowComputer(Computer computer)
        {

    
            if (computer != null)
            {
                //make things visible only if info is found.
                //join together the services with a comma,check if null before!
                txtCompName.Visible = true;
                txtIpOutput.Visible = true;
                lblComputerName.Visible = true;
                lblIp.Visible = true;
                lblServices.Visible = true;

                string compServices = string.Join("\n ", computer.Services);
                lblComputerName.Text = $"Computer Name:";
                txtCompName.Text = $"{computer.Name}";
                txtIpOutput.Text = $"{computer.IpAddress}";
                lblServices.Text = $"Services: \n {compServices}";
            }
            else
            {
             
                lblComputerName.Text = "Request Timed Out.\n";
                txtCompName.Visible = false;
                txtIpOutput.Visible = false;
                lblServices.Visible = false;
                lblIp.Visible = false;
                lblServices.Visible = true;
                lblServices.Text = "Services: \nNONE";
            }
        }
    }
}

