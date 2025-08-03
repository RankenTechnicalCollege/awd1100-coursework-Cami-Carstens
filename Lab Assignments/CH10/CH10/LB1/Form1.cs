using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        SuperHero[] heroes =
        {
                new SuperHero{
                    Name="None", Likes="", Dislikes="", Biography="", Image=null, SuperPower="", Url="" },

            new SuperHero{
                    Name="Black Panther",
                    Likes="The people of Wakanda\n justice\n technology",
                    Dislikes="Political games\n betrayal ",
                    Biography="Black Panther is a fictional superhero\n appearing in Marvel Comics.\n He is also the title of the ruler \n of the fictional African nation of Wakanda, \n with the current ruler and protector being T'Challa. \n T'Challa inherits the mantle of Black Panther \n after his father's death, gaining enhanced \n physical abilities and mystical powers \n through a connection with the panther god \n and a mystical herb",
                    Image=Properties.Resources.bpanther,
                    SuperPower="Super human strength, \n Speed and agility. \n Enhanced senses and \n regenerative healing.",
                    Url="https://characterprofile.fandom.com/wiki/Black_Panther" },

            new SuperHero{
                   Name="Iron Man",
                   Likes="Advanced technology\n Inventing and creating",
                   Dislikes="Loss of control, \n Bureaucracy, Ineffectiveness",
                   Biography="Iron Man is the superhero persona \n of Anthony Edward \"Tony\" Stark,\n a businessman and engineer who runs \n the weapons manufacturing company \n Stark Industries.When Stark was captured\n in a war zone and \n sustained a severe heart wound, \n he built his Iron Man armor \n and escaped his captors.",
                   Image=Properties.Resources.ironman3,
                   SuperPower="His powers are found in his technologically\n advanced suit. With his suit he can fly, \n have weapons, advanced strength, \n defense systems, and super strength.",
                   Url="https://characterprofile.fandom.com/wiki/Iron_Man" },

            new SuperHero{
                  Name="Batman",
                  Likes="Exploring caves\n His bat mobile ",
                  Dislikes="Cruelty\n Injustice\n The Joker",
                  Biography="Batman, also known as Bruce Wayne,\n is a fictional superhero appearing \n in American comic books published by DC \n Comics. He is a wealthy playboy \n who dedicates his life to fighting crime \n in Gotham City as a masked vigilante.\n Driven by the traumatic murder of his parents, \n he developed a complex persona and a suite of gadgets \n and vehicles to combat criminals",
                  Image=Properties.Resources.batman,
                  SuperPower="Strength, Stamina, \n Endurance, Flight, \n Bio-energy manipulation, \n Darkness manipulation, \n Genuis level intellect",
                  Url="https://batman.fandom.com/wiki/Bruce_Wayne" },

            new SuperHero{
                  Name="Miles Morales-Spiderman",
                  Likes="Drawing/graffiti art\n Music \n Sneakers\n Playing video games,",
                Dislikes="His shoes untying\n Being lied to\n Being underestimated ",
                Biography="Miles Morales is a popular character \n in Marvel Comics, particularly known \n for becoming Spider-Man in the Ultimate \n Universe after the death of Peter Parker. \n He is a young, Black and Puerto Rican \n teenager who gains \n spider-like powers after being bitten \n by a genetically modified spider. \n His story often explores themes of identity, \n responsibility, and family",
                Image=Properties.Resources.miles_spiderman,
                SuperPower="Bio-electric venom blasts, \n Super human strength, Agility, \n Clings to surfaces(can climbs buildings), \n Camouflage(invisibility)",
                Url="https://marvels-spider-man.fandom.com/wiki/Miles_Morales" },

            new SuperHero{
                Name="Thor",
                Likes="Fighting and combat, \n His home in Asgard,\n, His hammer",
                Dislikes="People messing with his long hair\n War",
                Biography="Thor, in Norse mythology, \n is a prominent god associated\n with thunder, storms, \n strength, and protection. \n He is the son of Odin and \n Fyorgyn (also known as Jord) \n and is married to the goddess Sif. \n Thor is renowned for his strength, \n his mighty hammer Mjölnir, \n and his battles against giants and monsters",
                Image=Properties.Resources.thor,
                SuperPower="Rapid healing, Flight, \n Speed, Electromagnetism manipulation, \n Teleportation, Godlike strength,\n Weather modification",
                Url="https://en.wikipedia.org/wiki/Thor" },
            };

        public Form1()
        {
            InitializeComponent();
            cboHeroes.Items.AddRange(heroes);
            cboHeroes.SelectedIndex = 0;
        }

        private void cboHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex = cboHeroes.SelectedIndex;
            if(cboHeroes.SelectedIndex == 0)
            {
                lblName.Text = "Please select a hero.";
            }
            else
            {
                lblName.Text = heroes[currentIndex].Name;
                lblLikes.Text = heroes[currentIndex].Likes;
                lblDislikes.Text = heroes[currentIndex].Dislikes;
                lblSuperPower.Text = heroes[currentIndex].SuperPower;
                lblBiography.Text = heroes[currentIndex].Biography;
                pbHero.Image = heroes[currentIndex].Image;
                lblLink.Text = heroes[currentIndex].Url; 
            }
        }
    }
}

