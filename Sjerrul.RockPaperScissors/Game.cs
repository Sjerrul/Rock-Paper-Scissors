using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;
using Sjerrul.RockPaperScissors.Strategies;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sjerrul.RockPaperScissors
{
    public class Game
    {
        private readonly TextBox _gameLog;
        private readonly TextBox _strategyMap;
        private readonly IComputer _computerPlayer;

        public IHuman HumanPlayer { get; }

        public Game(TextBox gameLog, TextBox strategyMap, int switchComputerStrategyAfter, double degradeComputerStrategy)
        {
            _gameLog = gameLog;
            _strategyMap = strategyMap;

            HumanPlayer = new Human();

            IList<IStrategy> strategies = new List<IStrategy>();
            strategies.Add(new UsePlayersLastMoveStrategy(HumanPlayer));
            strategies.Add(new AlwaysRockStrategy());
            strategies.Add(new AlwaysPaperStrategy());
            strategies.Add(new AlwaysScissorsStrategy());
            strategies.Add(new AlternateMovesStrategy());
            strategies.Add(new AlternateMovesReversedStrategy());

            _computerPlayer = new Computer(strategies, switchComputerStrategyAfter, degradeComputerStrategy);

            OutputLine("Game Initialized");
        }

        public void Start()
        {
            OutputLine("Starting");
            OutputLine("Input your move");
        }

        private void OutputLine(string text)
        {
            _gameLog.AppendText(text + Environment.NewLine);
        }
        
        private void UpdateStrategyMap()
        {
            _strategyMap.Clear();
            foreach (var strategy in _computerPlayer.GetStrategyMap())
            {
                _strategyMap.AppendText($"{strategy.Key.Name}: {strategy.Value}{Environment.NewLine}");
            }
            
            _strategyMap.AppendText($"Using {_computerPlayer.GetCurrentStrategy().Name}{Environment.NewLine}");
        }

        public void DoTurn()
        {
            GameMove computerMove = _computerPlayer.GetMove();
            GameMove playerMove = HumanPlayer.GetMove();

            bool? computerBeatsPlayer = computerMove.Beats(playerMove);
            if (computerBeatsPlayer.HasValue)
            {
                if (computerBeatsPlayer.Value)
                {
                    _computerPlayer.Wins++;
                }
                else
                {
                    HumanPlayer.Wins++;
                }
            }

            OutputLine($"You picked: {playerMove}, I picked {computerMove}");
            OutputLine($"You: {HumanPlayer.Wins} - Me: {_computerPlayer.Wins}");
            UpdateStrategyMap();
        }
    }
}