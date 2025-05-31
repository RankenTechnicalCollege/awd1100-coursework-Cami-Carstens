using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_ALT_method
{
    public partial class Form1 : Form
    {
        Random randGenerator = new Random();
        int playerWins = 0;
        int computerWins = 0;
        int rounds = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameRound(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            GameRound(2);

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            GameRound(3);
        }
        private void GameRound(int playerChoice)
        {
            int computerChoice = randGenerator.Next(1, 4);
            lblComputerChoice.Text = $"Computer picked {computerChoice}";


            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (playerChoice == computerChoice)
                    {
                        lblResult.Text = $"It's a tie!";
                    }
                    else if ((playerChoice == 1 && computerChoice == 3) ||
                    (playerChoice == 2 && computerChoice == 1) ||
                    (playerChoice == 3 && computerChoice == 2))
                    {
                        lblResult.Text = $"You won this round!!";
                        playerWins++;
                    }
                    else
                    {
                        computerWins++;
                        lblResult.Text = $"Computer won this round!!";
                    }
                    lblScore.Text = $"Player Score: {playerWins} Computer Score: {computerWins}";

                    if (rounds == 3)
                    {
                        if(playerWins > computerWins)
                        {
                            lblFinalScore.Text = $"Player Wins!!";
                        }
                        else if(computerWins > playerWins)
                        {
                            lblFinalScore.Text = $"Computer Wins!!";
                        }
                        else
                        {
                            lblFinalScore.Text = $"It's a tie!!";
                            rounds++;
                        }
                    }
                    
                    }
                }
            }
        }
    }

