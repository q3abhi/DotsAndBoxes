using System.Collections.Generic;
using DotsAndBoxesModels.Implementations;

namespace DotsAndBoxesModels.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Score { get; set; }
        int InvalidMoves { get; set; }

        Line MakeAMove(IList<Line> linesOnTheBoard);
    }
}
