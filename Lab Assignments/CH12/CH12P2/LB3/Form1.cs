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
        
        List<Champion> championNames = new List<Champion>();
        public Form1()
        {
            InitializeComponent();

            //make  champions and each ability an instance/object

            //Ruckus
            championNames.Add(new Champion("Ruckus", 
                ChampionType.FRONT_LINE, 
                new Ability("miniguns"), 
                new Ability("Missile Launcher"),
                new Ability("Emitter"),
                new Ability("Advance"),
                new Ability("Hexa Fire")));

            //Makoa
            championNames.Add(new Champion("Makoa",
                ChampionType.FRONT_LINE,
                new Ability("Cannon"),
                new Ability("Dredge Anchor"),
                new Ability("Shell Shield"),
                new Ability("Shell Spin"),
                new Ability("Ancient Rage"
                )));


            //Drogoz
            championNames.Add(new Champion("Drogoz",
                ChampionType.DAMAGE,
                new Ability("Rocket Launcher"),
                new Ability("Fire Spit"),
                 new Ability("Salvo"),
                new Ability("Thrust"),
                new Ability("Dragon Punch")));

            //Tyra
            championNames.Add(new Champion("Tyra",
                ChampionType.DAMAGE,
                new Ability("Auto Rifle"),
                new Ability("Node Launcher"),
                new Ability("Fire Bomb"),
                new Ability("Hunters Mark"),
                new Ability("Crossfire")));

            //Grover
            championNames.Add(new Champion("Grover",
                ChampionType.SUPPORT,
                new Ability("Throwing Axe"),
                new Ability("Crippling Throw"),
                new Ability("Blossom"),
                new Ability("Vine"),
                new Ability("Whirlwind")));

            //Evie
            championNames.Add(new Champion("Evie",
                ChampionType.FLANK,
                new Ability("Ice Staff"),
                new Ability("Ice Block"),
                new Ability("Blink"),
                new Ability("Soar"),
                new Ability("Ice Storm")));


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblResult.Visible = true;
          
            Champion foundChampion = null;
            string inputName = txtSearchInput.Text.ToLower();
           

            foreach( Champion champ in championNames)
            {
                if(champ.Name.ToLower().Contains(inputName))
                {
                    foundChampion = champ;
                    break;
                }
            }
            if (foundChampion != null)
            {
              
                lblResult.Text = foundChampion.ToString();
            }
            else
            {
                 lblResult.Text = "Champion not found.";
            }



        }
    }
}
