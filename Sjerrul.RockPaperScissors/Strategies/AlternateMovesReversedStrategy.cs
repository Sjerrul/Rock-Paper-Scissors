﻿using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors.Strategies
{
    class AlternateMovesReversedStrategy : IStrategy
    {
        private Move _nextMove;

        public AlternateMovesReversedStrategy()
        {
            _nextMove = Move.Rock;
        }

        public Move PickMove()
        {
            Move moveToReturn = _nextMove;

            switch (_nextMove)
            {
                case Move.Rock: _nextMove = Move.Scissors; break;
                case Move.Paper:  _nextMove = Move.Rock; break;
                case Move.Scissors:  _nextMove = Move.Paper; break;
                default:  _nextMove = Move.Rock; break;
            }

            return moveToReturn;
        }
    }
}
