using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors
{
    class Turn
    {
        private Move _playerMove;
        private Move _computerMove;
        
        public Turn(Move playerMove, Move computerMove)
        {
            _playerMove = playerMove;
            _computerMove = computerMove;
        }

        public Move? GetWinningMove()
        {
            if (!_playerMove.Beats(_computerMove).HasValue)
            {
                return null;
            }

            if (_playerMove.Beats(_computerMove).Value)
            {
                return _playerMove;
            }

            return _computerMove;
        }
    }
}
