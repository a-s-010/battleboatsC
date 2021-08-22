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

            playerPositions = new List<Button> {A1Player, A2Player, A3Player, A4Player, B1Player, B2Player, B3Player, B4Player, C1Player, C2Player, C3Player, C4Player, D1Player, D2Player, D3Player, D4Player };
            compPositions = new List<Button> {A1Comp, A2Comp, A3Comp, A4Comp, B1Comp, B2Comp, B3Comp, B4Comp, C1Comp, C2Comp, C3Comp, C4Comp, D1Comp, D2Comp, D3Comp, D4Comp };

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

        }
    }
}

