using System.Collections.Generic;
using DotsAndBoxesModels.Implementations;

namespace DotsAndBoxesModels.Interfaces
{
    public interface IGameBoard
    {
        string Name { get; set; }
        int Rows { get; set; }
        int Columns { get; set; }
        string Color { get; set; }
        int TotalSquares { get; set; }
        int TotalLines { get; set; }
        IList<Line> LinesDrawn { get; set; }
        IList<IPlayer> Players { get; set; }
        IPlayer CurrentPlayer { get; set; }


        bool IsLineValid(Line line);
        void DrawALine(Line line);
        bool IsGameOver();
        bool IsSquareFormed(Line line);
        void UpdateScore();

    }
}
