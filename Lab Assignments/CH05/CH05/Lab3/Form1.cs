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
        Random randGenerator = new Random();
        int roundCountStarts = 1;
        int playerWins = 0;
        int computerWins = 0;
        public Form1()
        {
            InitializeComponent();
        }
    private void GameRound(int playerChoice)
        {
            int computerChoice = randGenerator.Next(1, 4);
            lblCompResult.Text = $"The computer picked {computerChoice}";
         
            if (playerChoice == computerChoice)
            {
                lblFinalScoreResult.Text = $"It's a tie!";
            }
            else if (playerChoice == 1 && computerChoice == 3)
            {
                lblFinalScoreResult.Text = $"You win this round!";
                playerWins++;
            }
            else if (playerChoice == 2 && computerChoice == 1)
            {
                lblFinalScoreResult.Text = $"You win this round!";
                playerWins++;
            }
            else if (playerChoice == 3 && computerChoice == 2)
            {
                lblFinalScoreResult.Text = $"You win this round!";
                playerWins++;
            }
            else
            {
                lblFinalScoreResult.Text = $"Computer wins this round!";
                computerWins++;
            }

            roundCountStarts++;
            lblCurrentScore.Text = $"Your player score: {playerWins}  Computer score: {computerWins}";

            if(roundCountStarts == 3) 

              if (playerWins > computerWins)
                 {
                    lblFinalScoreResult.Text = $"Player Wins!!";
                 }
            else if (computerWins > playerWins)
                {
                    lblFinalScoreResult.Text = $"Computer Wins!!";
                }
            else
                {
                    lblFinalScoreResult.Text = $"It's a tie!!";
                }

                

                

            
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            GameRound(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameRound(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameRound(3);
        }
    }
}
