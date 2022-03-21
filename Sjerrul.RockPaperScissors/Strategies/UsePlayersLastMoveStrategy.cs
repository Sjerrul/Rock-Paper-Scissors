using Sjerrul.RockPaperScissors.Enums;
using Sjerrul.RockPaperScissors.Players;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class UsePlayersLastMoveStrategy : IStrategy
    {
        private readonly IPlayer _player;
        private GameMove? _playersPreviousMove;

        public string Name => nameof(UsePlayersLastMoveStrategy);

        public UsePlayersLastMoveStrategy(IPlayer player)
        {
            _player = player;
        }

        public GameMove PickMove()
        {
            if (!_playersPreviousMove.HasValue)
            {
                _playersPreviousMove = _player.GetMove();
                return GameMove.Rock;
            }

            GameMove moveToReturn = _playersPreviousMove.Value;
            _playersPreviousMove = _player.GetMove();

            return moveToReturn;
        }
    }
}
