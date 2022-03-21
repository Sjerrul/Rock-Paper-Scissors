using System;
using System.Collections.Generic;
using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Strategies;

namespace Sjerrul.RockPaperScissors.Players
{
    public class Human : IHuman
    {
        public int Wins { get; set; }
        public GameMove CurrentMove { get; set; }

        public GameMove GetMove()
        {
            return CurrentMove;
        }
    }
}
