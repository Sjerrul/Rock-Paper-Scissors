using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;
using Sjerrul.RockPaperScissors.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sjerrul.RockPaperScissors
{
    class Game
    {
        private TextBox _textBox;
        public Player HumanPlayer = new Human();
        public Player ComputerPlayer;

        public Game(TextBox textBox)
        {
            _textBox = textBox;

            IList<IStrategy> strategies = new List<IStrategy>();
            strategies.Add(new UsePlayersLastMoveStrategy(HumanPlayer));
            strategies.Add(new AlwaysRockStrategy());
            strategies.Add(new AlwaysPaperStrategy());
            strategies.Add(new AlwaysScissorsStrategy());
            strategies.Add(new AlternateMovesStrategy());
            strategies.Add(new AlternateMovesReversedStrategy());

            ComputerPlayer = new Computer(strategies);

            OutputLine("Game Initialized");
        }

        public void Start()
        {
            OutputLine("Starting");

            OutputLine("Input your move");            
        }

        private void OutputLine(string text)
        {
            _textBox.AppendText(text + Environment.NewLine);
           
        }

        public void DoTurn()
        {
            Move computerMove = ComputerPlayer.GetMove();
            Move playerMove = HumanPlayer.GetMove();

            bool? computerBeatsPlayer = computerMove.Beats(playerMove);
            if (computerBeatsPlayer.HasValue)
            {
                if (computerBeatsPlayer.Value == true)
                {
                    ComputerPlayer.Wins++;
                }
                else
                {
                    HumanPlayer.Wins++;
                }
            }

            OutputLine("You picked: " + playerMove + ", I picked " + computerMove);
            OutputLine("You: " + HumanPlayer.Wins + " - Me: " + ComputerPlayer.Wins); 
        }

        
    }
}
