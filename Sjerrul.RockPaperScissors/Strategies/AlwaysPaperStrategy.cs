using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class AlwaysPaperStrategy : IStrategy
    {
        public string Name => nameof(AlwaysPaperStrategy);

        public GameMove PickMove()
        {
            return GameMove.Paper;
        }
    }
}
