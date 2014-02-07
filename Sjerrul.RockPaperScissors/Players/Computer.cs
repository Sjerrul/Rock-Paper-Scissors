using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors.Players
{
    class Computer : Player
    {
        private int _switchStrategyAfter = 5;
        private double _degradeStragety = 0.7;

        private IList<IStrategy> _strategies { get; set; }
        private IStrategy _currentStrategy;
        public override Move CurrentMove { get; set; }
        private Dictionary<IStrategy, double> _memory = new Dictionary<IStrategy, double>();

        private int _wins;
        private int _gamesPlayed = 0;
        public override int Wins {get; set;}
        
        public Computer(IList<IStrategy> strategies)
        {
            _strategies = strategies;
            _currentStrategy = _strategies.First();

            foreach(IStrategy strategy in _strategies)
            {
                _memory.Add(strategy, 0);
            }          
        }

        public override Move GetMove()
        {
            _gamesPlayed++;
            _memory[_currentStrategy] = ((double)Wins / (double)_gamesPlayed) * _degradeStragety;

            Move move = _currentStrategy.PickMove();
            CurrentMove = move;

            if (_gamesPlayed % _switchStrategyAfter == 0)
            {
                KeyValuePair<IStrategy, double> strategy = _memory.Where(x => x.Value == 0).Select(x => new { o = x, guid = Guid.NewGuid()}).OrderBy(y => y.guid).Select(z => z.o).FirstOrDefault();

                if (strategy.Key == null)
                {
                    // All strategies have been tried, pick the one with the best score
                    _currentStrategy = _memory.OrderByDescending(x => x.Value).First().Key; 

                    _switchStrategyAfter = 3; //Increase interval for strategy switching
                }
                else
                {
                    _currentStrategy = strategy.Key;
                }
            }

            return move;           
        }
    }
}
