using Sjerrul.RockPaperScissors.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors.Players
{
    class Human : Player
    {
        public override Move CurrentMove { get; set; }

        public override Move GetMove()
        {
            return CurrentMove;
        }
    }
}
