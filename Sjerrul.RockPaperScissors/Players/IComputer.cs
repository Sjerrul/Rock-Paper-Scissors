﻿using System.Collections.Generic;
using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Strategies;

namespace Sjerrul.RockPaperScissors.Players
{
    public interface IComputer : IPlayer
    {
        IDictionary<IStrategy, double> GetStrategyMap();
        IStrategy GetCurrentStrategy();
    }
}
