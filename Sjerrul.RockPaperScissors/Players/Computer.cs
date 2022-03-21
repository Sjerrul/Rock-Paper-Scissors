using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sjerrul.RockPaperScissors.Players
{
    public class Computer : IComputer
    {
        private int _switchStrategyAfter;
        private double _degradeStrategy;
        private int _gamesPlayed;
        
        private IStrategy _currentStrategy;
        private readonly Dictionary<IStrategy, double> _memory = new Dictionary<IStrategy, double>();

        public GameMove CurrentMove { get; set; }
        public int Wins {get; set;}
        
        public Computer(IList<IStrategy> strategies, int switchStrategyAfter, double degradeStrategy)
        {
            if (strategies == null)
            {
                throw new ArgumentNullException(nameof(strategies));
            }

            foreach(IStrategy strategy in strategies)
            {
                _memory.Add(strategy, 0);
            }  
            
            _currentStrategy = strategies.First();
            
            _switchStrategyAfter = switchStrategyAfter;
            _degradeStrategy = degradeStrategy;
        }

        public GameMove GetMove()
        {
            _gamesPlayed++;
            _memory[_currentStrategy] = Wins / (double)_gamesPlayed * _degradeStrategy;

            GameMove move = _currentStrategy.PickMove();
            CurrentMove = move;

            if (_gamesPlayed % _switchStrategyAfter == 0)
            {
                KeyValuePair<IStrategy, double> strategy = _memory.Where(x => x.Value == 0)
                    .Select(x => new { o = x, guid = Guid.NewGuid()})
                    .OrderBy(y => y.guid)
                    .Select(z => z.o)
                    .FirstOrDefault();

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

        public IDictionary<IStrategy, double> GetStrategyMap()
        {
            return _memory;
        }

        public IStrategy GetCurrentStrategy()
        {
            return _currentStrategy;
        }
    }
}
