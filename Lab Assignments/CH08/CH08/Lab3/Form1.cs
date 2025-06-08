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
        string[] videoGames = new string[5];
        string[] gamePublisher = new string[5];
        decimal[] prices = new decimal[5];
        public Form1()
        {
            InitializeComponent();
            videoGames[0] = "Player Unknown's Battlegrounds(PUBG)";
            videoGames[1] = "League of Legends";
            videoGames[2] = "Call of Duty: Black Ops III";
            videoGames[3] = "Battlefield 4";
            videoGames[4] = "Super Mario Odyssey";

            gamePublisher[0] = "Bluehole";
            gamePublisher[1] = "Riot Games";
            gamePublisher[2] = "Activision";
            gamePublisher[3] = "Electronic Arts (EA)";
            gamePublisher[4] = "Nintendo";

            prices[0] = 35m;
            prices[1] = 0m;
            prices[2] = 60m;
            prices[3] = 20m;
            prices[4] = 60m;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtGameSearch.Text.ToLower();
            bool found = false;

            for (int i = 0; i < videoGames.Length; i++)
            {
                if (videoGames[i].ToLower().Contains(input) || gamePublisher[i].ToLower().Contains(input))
                {
                    lblResult.Text = $" Name: {videoGames[i]} \n Publisher: {gamePublisher[i]} \n Price: {prices[i]:C}";
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                lblResult.Text = "Game or publisher not found.";
            }

        }
    }
  }
    

