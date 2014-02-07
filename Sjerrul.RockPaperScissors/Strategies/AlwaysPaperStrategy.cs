﻿using Sjerrul.RockPaperScissors.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class AlwaysPaperStrategy : IStrategy
    {
        public Move PickMove()
        {
            return Move.Paper;
        }
    }
}