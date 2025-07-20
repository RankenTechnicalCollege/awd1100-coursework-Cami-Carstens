using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1 : Form
    {

        List<ICard> cardPack = new List<ICard>(10);

        Random numGen = new Random();
        int shinyCount = 0; // Count of shiny cards

        // Array of Pokemon names
        string[] pokemonNames = new string[]
        {
        "Bulbasaur", "Vaporeon", "Charizard", "Froakie", "Greninja",
        "Hitmontop", "Jigglypuff", "Piplup", "Machoke", "Nidorina",
        "Ninetales", "Lickitung", "Pikachu", "Pyroar", "Squirtle",
        "Rayquaza", "Umbreon", " Pikachu", "Sylveon"

        };
        // Array of Pokemon images
        Image[] pokemonImages = new Image[]
        {
        Properties.Resources.bulbasaur_pokemon,
        Properties.Resources.vaporeon1,
        Properties.Resources.charizardx1,
        Properties.Resources.froakie1,
        Properties.Resources.greninja,
        Properties.Resources.hitmontop1shiny,
        Properties.Resources.jigglypuffshiny1,
        Properties.Resources.luvers1,
        Properties.Resources.machoke1,
        Properties.Resources.nidorina1,
        Properties.Resources.nintales1,
        Properties.Resources.pangea1,
        Properties.Resources.pikachu_shiny,
        Properties.Resources.pokemon2,
        Properties.Resources.squirtle1,
        Properties.Resources.Rayquaza_Shiny1,
        Properties.Resources.shiny_umbreon,
        Properties.Resources.shinyPikachu,
        Properties.Resources.syleon,

        };

        PictureBox[] printpbArray;
        Label[] printlblArray;


        public Form1()
        {
            InitializeComponent();

            printpbArray = new PictureBox[]
            {
                pbPokemon, pbPokemon2, pbPokemon3, pbPokemon4, pbPokemon5,
                pbPokemon6, pbPokemon7, pbPokemon8, pbPokemon9, pbPokemon10
            };
            printlblArray = new Label[]
            {
                lblPokemonName, lblPokemonName2, lblPokemonName3, lblPokemonName4, lblPokemonName5,
                lblPokemonName6, lblPokemonName7, lblPokemonName8, lblPokemonName9, lblPokemonName10
            };

        }

        private void btnOpen_Click(object sender, EventArgs e)
        { 
            cardPack.Clear();
            pbPokemon.Visible = true;
            pbPokemon2.Visible = true;
            pbPokemon3.Visible = true;
            pbPokemon4.Visible = true;
            pbPokemon5.Visible = true;
            pbPokemon6.Visible = true;
            pbPokemon7.Visible = true;
            pbPokemon8.Visible = true;
            pbPokemon9.Visible = true;
            pbPokemon10.Visible = true;


            shinyCount = 0; // Reset shiny count
            

            while(cardPack.Count < 10)
            {
                int index = numGen.Next(pokemonNames.Length);
                string name = pokemonNames[index];
                Image image = pokemonImages[index];
               
                // 20% chance of shiny card
                ICard card;

                if (shinyCount < 2 && numGen.NextDouble() < 0.2)
                {
                    double value = numGen.Next(50, 100);
                    // Create a shiny card
                    card = new ShinyCard(name, image, value, new Font("Cursive", 16, FontStyle.Bold), Color.Gold, Color.DarkBlue);
                    shinyCount++;
                }

                else
                {
                    double value = numGen.Next(1, 51);
                    // Create a normal card
                    card = new NormalCard(name, image, value);
                }
                cardPack.Add(card);
            }
            cardPack.Sort();

            //print results in arrays
            for(int i = 0; i < 10; i++)
            {
                cardPack[i].ShowCard(printpbArray[i], printlblArray[i]);
            }


            //    if (cardPack.Count == 0 || cardIndex >= 10)
            //    {
            //        cardPack.Clear();
            //        cardIndex = 0;
            //        shinyCount = 0;

            //        //10 random cards, 20% chance of shiny card
            //       while(cardPack.Count < 10)
            //        {
            //        int index = numGen.Next(pokemonNames.Length);

            //        string name = pokemonNames[index];

            //        Image image = pokemonImages[index];

            //            double value = numGen.Next(1, 101);

            //            // 20% chance of shiny card

            //            ICard card;

            //        if (shinyCount < 2 && numGen.NextDouble() < 0.2)
            //        {
            //            // Create a shiny card
            //            card = new ShinyCard(name, image, value, new Font("Arial", 14, FontStyle.Bold), Color.Gold, Color.DarkBlue);
            //            shinyCount++;
            //        }
            //        else
            //        {
            //            // Create a normal card
            //            card = new NormalCard(name, image, value);

            //        }
            //        cardPack.Add(card);



            //    }
            //    cardPack.Sort();
            //}

            //    if (cardIndex < 10)
            //    {
            //        ICard card = cardPack[cardIndex];
            //        card.ShowCard(pbPokemon, lblPokemonName);
            //        cardIndex++;

            //        if(cardIndex == 10)
            //        {
            //            lblResult.Text = "You have opened all the cards in the pack!";
            //            pbPokemon.Image = null; // Clear the picture box
            //            lblPokemonName.Text = ""; // Clear the label

            //        }
            //    }

            //}

        }
    }
}


