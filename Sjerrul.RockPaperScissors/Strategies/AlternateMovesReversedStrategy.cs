using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class AlternateMovesReversedStrategy : IStrategy
    {
        private GameMove _nextMove;

        public AlternateMovesReversedStrategy()
        {
            _nextMove = GameMove.Rock;
        }

        public string Name => nameof(AlternateMovesReversedStrategy);

        public GameMove PickMove()
        {
            GameMove moveToReturn = _nextMove;

            switch (_nextMove)
            {
                case GameMove.Rock: _nextMove = GameMove.Scissors; break;
                case GameMove.Paper:  _nextMove = GameMove.Rock; break;
                case GameMove.Scissors:  _nextMove = GameMove.Paper; break;
                default:  _nextMove = GameMove.Rock; break;
            }

            return moveToReturn;
        }
    }
}
