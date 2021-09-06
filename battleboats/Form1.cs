using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;




namespace battleboats
{
    public partial class Form1 : Form
    {

        List<Button> playerPositions;
        List<Button> compPositions;

        Random rand = new Random();

        int totalShips = 5;
        int rounds = 10;
        int playerScore;
        int compScore;

        public Form1()
        {
            InitializeComponent();
            RestartGame();

        }

        private void CompPlayTimerEvent(object sender, EventArgs e)
        {
            if (playerPositions.Count > 0 && rounds > 0)
            {
                rounds -= 1;

                roundsTxt.Text = "Round: " + rounds;

                int index = rand.Next(playerPositions.Count);

                if ((string)playerPositions[index].Tag == "PlayerShip")
                {
                    playerPositions[index].BackColor = Color.Red;
                    compMove.Text = playerPositions[index].Text;
                    playerPositions[index].Enabled = false;
                    playerPositions.RemoveAt(index);
                    compScore += 1;
                    compScoreTxt.Text = compScore.ToString();
                    CompPlayTimer.Stop();

                }
                else
                {
                    playerPositions[index].BackColor = Color.Yellow;
                    compMove.Text = playerPositions[index].Text;
                    playerPositions[index].Enabled = false;
                    playerPositions.RemoveAt(index);
                    CompPlayTimer.Stop();

                }

                

            }

            if (rounds < 1 || compScore > 2 || playerScore > 2)
            {
                if (playerScore > compScore)
                {
                    MessageBox.Show("You have won the battle", "Win");
                    RestartGame();
                }
                
            }
            else if (compScore > playerScore)
            {
                MessageBox.Show("You have lost the battle", "Lost");
                RestartGame();
            }
            else if (compScore == playerScore)
            {
                MessageBox.Show("No one wins this battle", "Draw");
                RestartGame();
            }


        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {

            if (AttackChoices.Text != "")
            {
                var attackPos = AttackChoices.Text.ToLower();

                int index = compPositions.FindIndex(a => a.Name == attackPos);

                if (compPositions[index].Enabled && rounds > 0)

                {
                    rounds -= 1;
                    roundsTxt.Text = "Round: " + rounds;

                    if ((string)compPositions[index].Tag == "enemyShip")
                    {

                        compPositions[index].Enabled = false;
                        compPositions[index].BackColor = Color.Red;
                        playerScore += 1;
                        playerScoreTxt.Text = playerScore.ToString();
                        CompPlayTimer.Start();

                    }
                    else
                    {
                        compPositions[index].Enabled = false;
                        compPositions[index].BackColor = Color.Yellow;
                        CompPlayTimer.Start();
                    }
                }
            }

        }
        private void PlayerPositionButtonsEvent(object sender, EventArgs e)
        {

            if (totalShips > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = Color.Orange;
                totalShips -= 1;

            }

            if (totalShips == 0)
            {
                attackButton.Enabled = true;
                attackButton.BackColor = Color.Red;
                attackButton.ForeColor = Color.White;


            }


        }
        private void RestartGame()
        {

            playerPositions = new List<Button> {a5, a6, a7, a8, B1Player, B2Player, B3Player, B4Player, C1Player, C2Player, C3Player, C4Player, D1Player, D2Player, D3Player, D4Player };
            compPositions = new List<Button> {a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            AttackChoices.Items.Clear();

            AttackChoices.Text = null;

            for (int i = 0; i < compPositions.Count; i++)
            {
                compPositions[i].Enabled = true;
                compPositions[i].Tag = null;
                compPositions[i].BackColor = Color.White;
                compPositions[i].BackgroundImage = null;
                AttackChoices.Items.Add(compPositions[i].Text);


            }
            for (int i = 0; i < playerPositions.Count; i++)
            {
                playerPositions[i].Enabled = true;
                playerPositions[i].Tag = null;
                playerPositions[i].BackColor = Color.White;
                playerPositions[i].BackgroundImage = null;

            }

            playerScore = 0;
            compScore = 0;
            rounds = 10;
            totalShips = 5;

            playerScoreTxt.Text = playerScore.ToString();
            compScoreTxt.Text = compScore.ToString();

            compMove.Text = "A1";

            attackButton.Enabled = false;

            compLocationPicker();



        }
        private void compLocationPicker()
        {
            for (int i = 0; i < 5; i++) 
            {
                int index = rand.Next(compPositions.Count);

                if (compPositions[index].Enabled == true && (string)compPositions[index].Tag == null)
                {
                    compPositions[index].Tag = "compShip";

                    Debug.WriteLine("Comp Position: " + compPositions[index].Text);

                }
                else
                {
                    index = rand.Next(compPositions.Count);
                }

            
            }



        }

        private void EnemyPlayTimerEvent(object sender, EventArgs e)
        {
            if (playerPositions.Count > 0 && rounds > 0)
            {
                rounds -= 1;

                roundsTxt.Text = "Round: " + rounds;

                int index = rand.Next(playerPositions.Count);

                if ((string)playerPositions[index].Tag == "playerShip")
                {
                    enemyMoveTxt.Text = playerPositions[index].Text;
                    playerPositions[index].Enabled = false;
                    playerPositions[index].BackColor = Color.Red;
                    playerPositions.RemoveAt(index);
                    compScore += 1;
                    compScoreTxt.Text = compScore.ToString();
                    CompPlayTimer.Stop();

                }
                else
                {

                    enemyMoveTxt.Text = playerPositions[index].Text;
                    playerPositions[index].Enabled = false;
                    playerPositions[index].BackColor = Color.Yellow;
                    playerPositions.RemoveAt(index);
                    CompPlayTimer.Stop();
                }
            }
        }

        private void toMenu_Click(object sender, EventArgs e)
        {
            var back = new menu();
            back.Show();
            this.Hide();
        }
    }
}

