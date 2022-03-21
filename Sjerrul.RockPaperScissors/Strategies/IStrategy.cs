using Sjerrul.RockPaperScissors.Enums;

namespace Sjerrul.RockPaperScissors.Strategies
{
    public interface IStrategy
    {
        string Name { get; }

        GameMove PickMove(); 
    }
}
