using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class AlwaysRockStrategy : IStrategy
    {
        public string Name => nameof(AlwaysRockStrategy);

        public GameMove PickMove()
        {
            return GameMove.Rock;
        }
    }
}
