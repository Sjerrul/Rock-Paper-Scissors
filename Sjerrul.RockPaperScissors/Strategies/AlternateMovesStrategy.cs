using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public class AlternateMovesStrategy : IStrategy
    {
        private GameMove _nextMove;

        public AlternateMovesStrategy()
        {
            _nextMove = GameMove.Rock;
        }
        
        public string Name => nameof(AlternateMovesStrategy);

        public GameMove PickMove()
        {
            GameMove moveToReturn = _nextMove;

            switch (_nextMove)
            {
                case GameMove.Rock: _nextMove = GameMove.Paper; break;
                case GameMove.Paper:  _nextMove = GameMove.Scissors; break;
                case GameMove.Scissors:  _nextMove = GameMove.Rock; break;
                default:  _nextMove = GameMove.Rock; break;
            }

            return moveToReturn;
        }
    }
}
