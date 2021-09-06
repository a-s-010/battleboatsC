using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battleboats
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            var newGame = new Form1();
            newGame.Show();

            this.Hide();
        }

        private void howTo_Click(object sender, EventArgs e)
        {
            var howToPlay = new HowTo();
            howToPlay.Show();

            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void resumeGame_Click(object sender, EventArgs e)
        {

        }
    }
}
