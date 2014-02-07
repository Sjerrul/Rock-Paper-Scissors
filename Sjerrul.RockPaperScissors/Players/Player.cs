using Sjerrul.RockPaperScissors.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors.Players
{
    public abstract class Player
    {
        public virtual int Wins { get; set; }

        public abstract Move CurrentMove { get; set; }
        public abstract Move GetMove();
    }
}
