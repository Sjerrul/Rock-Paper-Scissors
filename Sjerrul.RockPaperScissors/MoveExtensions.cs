using Sjerrul.RockPaperScissors.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.RockPaperScissors
{
    public static class MoveExtensions
    {
        public static bool? Beats(this Move move, Move moveToBeat)
        {
            if (move == Move.Rock)
            {
                if (moveToBeat == Move.Paper)
                {
                    return false;
                }
                if (moveToBeat == Move.Scissors)
                {
                    return true;
                }

                return null;
            }

            if (move == Move.Paper)
            {
                if (moveToBeat == Move.Scissors)
                {
                    return false;
                }
                if (moveToBeat == Move.Rock)
                {
                    return true;
                }

                return null;
            }

            if (move == Move.Scissors)
            {
                if (moveToBeat == Move.Rock)
                {
                    return false;
                }
                if (moveToBeat == Move.Paper)
                {
                    return true;
                }

                return null;
            }


            return null;
        }
    }
}
