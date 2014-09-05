using DotsAndBoxesModels.Implementations;

namespace DotsAndBoxesModels.Interfaces
{
    public interface ITurnManager
    {
        IPlayer DecideFirstTurnPlayer();
        IPlayer NextTurn();
    }
}
