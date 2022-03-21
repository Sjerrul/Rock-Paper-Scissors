using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class AlwaysScissorsStrategy : IStrategy
    {
        public string Name => nameof(AlwaysScissorsStrategy);

        public GameMove PickMove()
        {
            return GameMove.Scissors;
        }
    }
}
