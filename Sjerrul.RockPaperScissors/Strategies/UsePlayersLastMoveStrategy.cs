using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors.Strategies
{
    class UsePlayersLastMoveStrategy : IStrategy
    {
        private readonly Player _player;
        private Move? _playersPreviousMove;

        public UsePlayersLastMoveStrategy(Player player)
        {
            _player = player;
        }

        public Move PickMove()
        {
            if (!_playersPreviousMove.HasValue)
            {
                _playersPreviousMove = _player.GetMove();
                return Move.Rock;
            }

            Move moveToReturn = _playersPreviousMove.Value;
            _playersPreviousMove = _player.GetMove();

            return moveToReturn;

            //return Move.Paper;
        }
    }
}
