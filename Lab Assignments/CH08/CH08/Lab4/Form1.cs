using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        string[] movieTitle = new string[10];
        string[] director = new string[10];
        string[] description = new string[10];
        public Form1()
        {
            InitializeComponent();
            movieTitle[0] = "Matilda";
            movieTitle[1] = "Spider-Man: Across the Spider-Verse";
            movieTitle[2] = "The Goofy Movie";
            movieTitle[3] = "Inside Out";
            movieTitle[4] = "Lord of the Rings: Fellowship of the Ring";
            movieTitle[5] = "John Wick";
            movieTitle[6] = "The Lion King";
            movieTitle[7] = "Toy Story";
            movieTitle[8] = "Gladiator";
            movieTitle[9] = "Grave of the Fireflies";

            director[0] = "Danny Devito";
            director[1] = "Joaquim Santos, Kemp Powers, Justin Thompson";
            director[2] = "Kevin Lima";
            director[3] = "Pete Docter";
            director[4] = "Peter Jackson";
            director[5] = "Chad Stahelski";
            director[6] = "Don Hahn";
            director[7] = "Bonnie Arnold, Ralph Guggenheim";
            director[8] = "David Franzoni, Douglas Wick, Branko Lustig";
            director[9] = "Toru Hara";

            description[0] = "A gifted girl forced to put up with cruel parents and an evil principal finds magic and love.";
            description[1] = "Miles is catapulted across the multiverse. He must redefine what it means to be a hero \n " + 
                " and protect those he loves.";
            description[2] = "A father son camping trip with a reluctant teenage son Max find themselves in endless adventures.\n" +
                " Max learns theres nothing wrong with being like his goofy dad.";
            description[3] = "Follows the inner workings of the mind of Riley a young growing girl fluctuating emotions.\n";
            description[4] = "An epic journey of hobits and magic rings";
            description[5] = "A hitman returns to the criminal underground to seek revenge after his car is stolen and his \n" +
                " dog is killed. He begins killing away the criminal organization that wronged him.";
            description[6] = "Simba is tricked into thinking he is responsible for his fathers death. He flees into exile.\n " +
                " But eventually returns to take his rightly place as King.";
            description[7] = "Andy's collection of toys come to life when Andy is not around. Packed full of toy adventures.";
            description[8] = "Roman general Maximus is betrayed and forced to become a gladitor. Fighting to survive and \n" +
                " eventually seeks revenge.";
            description[9] = "Siblings and war orphans struggle desperately to survive the final months of Pacific War.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInputBox.Text.ToLower();
            bool found = false;
            for (int i = 0; i < movieTitle.Length; i++)
            {
                if (movieTitle[i].ToLower().Contains(input) || director[i].ToLower().Contains(input))
                {
                    lblResult.Text = $" Title: {movieTitle[i]} \n \n Director: {director[i]} \n \n Description: {description[i]}";
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                lblResult.Text = $"Movie or director you entered was not found.";
            }
        }
    }
}
