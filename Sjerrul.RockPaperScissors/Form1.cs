using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sjerrul.RockPaperScissors
{
    public partial class Form1 : Form
    {
        private Game _game;
        public Form1()
        {
            InitializeComponent();

            _game = new Game(textBox);
            _game.Start();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            _game.HumanPlayer.CurrentMove = Enums.Move.Rock;
            _game.DoTurn();
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            _game.HumanPlayer.CurrentMove = Enums.Move.Paper;
            _game.DoTurn();
        }

        private void buttonScissor_Click(object sender, EventArgs e)
        {
            _game.HumanPlayer.CurrentMove = Enums.Move.Scissors;
            _game.DoTurn();
        }
    }
}
