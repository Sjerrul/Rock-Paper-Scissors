using System;
using System.Configuration;
using System.Windows.Forms;
using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors
{
    public partial class Form1 : Form
    {
        private readonly Game _game;
        public Form1()
        {
            InitializeComponent();

            if(!int.TryParse(ConfigurationSettings.AppSettings.Get("switchStrategiesAfter"), out int switchStrategiesAfter))
            {
                throw new ConfigurationException("Invalid 'switchStrategiesAfter' configuration");
            }
            
            if(!double.TryParse(ConfigurationSettings.AppSettings.Get("degradeStrategy"), out double degradeStrategy))
            {
                throw new ConfigurationException("Invalid 'degradeStrategy' configuration");
            }            
            
            _game = new Game(txtGameLog, txtStrategyMap, switchStrategiesAfter, degradeStrategy);
            _game.Start();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            _game.HumanPlayer.CurrentMove = GameMove.Rock;
            _game.DoTurn();
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            _game.HumanPlayer.CurrentMove = GameMove.Paper;
            _game.DoTurn();
        }

        private void buttonScissor_Click(object sender, EventArgs e)
        {
            _game.HumanPlayer.CurrentMove = GameMove.Scissors;
            _game.DoTurn();
        }
    }
}
