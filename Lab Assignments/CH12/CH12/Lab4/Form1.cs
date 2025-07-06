using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Lab4
{
    public partial class Form1 : Form
    {
        List<Game> games = new List<Game>();
        public Form1()
        {
            //pattern: name,publisher,price
            InitializeComponent();
            games.Add(new Game("Player Unknown's BattleGrounds(PUBG)", "Bluehole", 35.00f));
            games.Add(new Game("League of Legends", "Riot Games", 0.00f));
            games.Add(new Game("Call of Duty: Black Ops III", "Activision", 60.00f));
            games.Add(new Game("Battlefield 4", "Electronic Arts(EA)", 20.00f));
            games.Add(new Game("Super Mario Odyssey", "Nintendo", 60.00f));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userInput = txtGameSearch.Text.ToLower();

            int index = SearchForGame(userInput);
            ShowGameInfo(index);


            //didnt see the methods in instructions and did it without them first

            //class variable in list object
            // foreach (Game game in games)
            //{
            //if (game.GetName().ToLower().Contains(userInput) ||
            // game.GetPublisher().ToLower().Contains(userInput))
            //{
            //   lblResult.Text = $" Name: {game.GetName()} \n Publisher: {game.GetPublisher()}\n Price: {game.GetPrice():C} ";
            //  found = true;
            //  break;
            //}

            //{
            //    if (!found)
            //    {
            //        lblResult.Text = " Name: Game Not Found. \n Publisher: Game Not Found. \n Price: Game Not Found.";
            //    }
            //}
            //if (userInput == "")
            //{
            //    lblResult.Text = "Please enter a game name or publisher to search.";
        }
        private int SearchForGame(string input)
        {
            input = input.ToLower();
            for (int i = 0; i < games.Count; i++)
            {
                string gameName = games[i].GetName().ToLower();
                string gamePublisher = games[i].GetPublisher().ToLower();

                if (gameName.Contains(input) || gamePublisher.Contains(input))
                {
                    return i; // Return the index of the game that was found
                }
            }

            return -1; // not found
        }

        private void ShowGameInfo(int index)
        {
            if (index >= 0 && index < games.Count)
            {
                Game foundGame = games[index];
                lblResult.Text = $" Name: {foundGame.GetName()} \n Publisher: {foundGame.GetPublisher()} \n Price: {foundGame.GetPrice():C}";
            }
            else
            {
                lblResult.Text = "Game Not Found.";
            }
        }
    }
}
    

