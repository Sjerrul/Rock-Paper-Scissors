using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors
{
    public static class MoveExtensions
    {
        public static bool? Beats(this GameMove move, GameMove moveToBeat)
        {
            switch (move)
            {
                case GameMove.Rock when moveToBeat == GameMove.Paper:
                    return false;
                case GameMove.Rock when moveToBeat == GameMove.Scissors:
                    return true;
                case GameMove.Rock:
                    return null;
                case GameMove.Paper when moveToBeat == GameMove.Scissors:
                    return false;
                case GameMove.Paper when moveToBeat == GameMove.Rock:
                    return true;
                case GameMove.Paper:
                    return null;
                case GameMove.Scissors when moveToBeat == GameMove.Rock:
                    return false;
                case GameMove.Scissors when moveToBeat == GameMove.Paper:
                    return true;
                case GameMove.Scissors:
                    return null;
                default:
                    return null;
            }
        }
    }
}
