using System.Collections.Generic;
using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Strategies;

namespace Sjerrul.RockPaperScissors.Players
{
    public interface IPlayer
    {
        int Wins { get; set; }
        GameMove CurrentMove { set; }
          
        GameMove GetMove();
    }
}
