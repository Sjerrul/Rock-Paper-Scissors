using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class PsychicStrategy : IStrategy
    {
        private readonly IPlayer _player;

        public string Name => nameof(PsychicStrategy);

        public PsychicStrategy(IPlayer playerToReadMindFrom)
        {
            _player = playerToReadMindFrom;
        }

        public GameMove PickMove()
        {
            return _player.GetMove();
        }
    }
}
