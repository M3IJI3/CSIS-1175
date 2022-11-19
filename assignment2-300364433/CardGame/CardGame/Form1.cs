using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    
    public partial class Form1 : Form
    {
        string[] cards = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        
        int[] computer = new int[4];
        int[] player = new int[4];

        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnBet_Click(object sender, EventArgs e)
        {
            i++;

            Random random = new Random();

            if(i == 1)
            {
                computer[0] = random.Next(1, 13);
                player[0] = random.Next(1, 13);

                btnCptOne.Text = cards[computer[0] - 1];
                btnPlayerOne.Text = cards[player[0] - 1];

            }
            else if(i == 2)
            {
                computer[1] = random.Next(1, 13);
                player[1] = random.Next(1, 13);

                btnCptTwo.Text = cards[computer[1] - 1];
                btnPlayerTwo.Text = cards[player[1] - 1];
            }
            else if(i == 3)
            {
                computer[2] = random.Next(1, 13);
                player[2] = random.Next(1, 13);

                btnCptThree.Text = cards[computer[2] - 1];
                btnPlayerThree.Text = cards[player[2] - 1];
            }
            else if(i == 4)
            {
                computer[3] = random.Next(1, 13);
                player[3] = random.Next(1, 13);

                btnCptFour.Text = cards[computer[3] - 1];
                btnPlayerFour.Text = cards[player[3] - 1];
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Winner();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            i = 0;

            MessageBox.Show("New Game!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnPlayerOne.Text = btnPlayerTwo.Text = btnPlayerThree.Text = btnPlayerFour.Text = null;
            btnCptOne.Text = btnCptTwo.Text = btnCptThree.Text = btnCptFour.Text = null;

            computer = new int[4];
            player = new int[4];
            
        }

        public void Winner()
        {
            double computerSum = 0;
            double playerSum = 0;

            for(int i = 0; i < 4; i++)
            {
                if (computer[i] > 10)
                {
                    computerSum += 0.5;
                }
                else
                {
                    computerSum += computer[i];
                }
                

                if (player[i] > 10)
                {
                    playerSum += 0.5;
                }
                else
                {
                    playerSum += player[i];
                }              
            }

            if (computerSum < 10)
            {
                if (playerSum < 10)
                {
                    if (computerSum > playerSum)
                    {
                        MessageBox.Show("Computer Wins!","‍Card Game",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else if (computerSum == playerSum)
                    {
                        MessageBox.Show("Tie! Player Wins!", "Card Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Player Wins!", "Card Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You blast! Computer Wins!", "Card Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (playerSum < 10)
                {
                    MessageBox.Show("Computer Blast! Player Wins!", "Card Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("All blast! Computer Wins!", "Card Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }        
    }
}
