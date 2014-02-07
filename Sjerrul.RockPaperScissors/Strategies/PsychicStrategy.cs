using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class PsychicStrategy : IStrategy
    {
        private readonly Player _player;

        public PsychicStrategy(Player playerToReadMindFrom)
        {
            _player = playerToReadMindFrom;
        }

        public Move PickMove()
        {
            return _player.GetMove();
        }
    }
}
