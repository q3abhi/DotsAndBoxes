using System;
using System.Collections.Generic;
using System.Linq;
using DotsAndBoxesModels.Interfaces;

namespace DotsAndBoxesModels.Implementations
{
    public class GameBoard : IGameBoard
    {
        public string Name { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public string Color { get; set; }
        public int TotalSquares { get; set; }
        public int TotalLines { get; set; }
        public IList<Line> LinesDrawn { get; set; }
        public IList<IPlayer> Players { get; set; } 
        public IPlayer CurrentPlayer { get; set; }

        public GameBoard(int row, int column)
        {
            if (row < 3 && column < 3)
            {
                Console.WriteLine("Game cannot be played on this board's dimensions");
            }
            else
            {
                Rows = row;
                Columns = column;
                TotalLines = (2 * Rows * Columns) - (Rows + Columns);
                TotalSquares = (Rows - 1) * (Columns - 1);
                LinesDrawn = new List<Line>();
                Console.WriteLine("Game Board initialised");
            }
        }

        public bool IsLineValid(Line line)
        {
            if (line.XTypeCoordinates.Any(coordinate => coordinate < 0 || coordinate >= Columns))
                return false;

            if (line.YTypeCoordinates.Any(coordinate => coordinate < 0 || coordinate >= Rows))
                return false;

            if (LinesDrawn.Contains(line))
                return false;

            if (line.IsHorizontal())
                return (line.Y1Coordinate - line.YCoordinate == 1);

            if (line.IsVertical())
                return (line.X1Coordinate - line.X1Coordinate == 1);

            return false;
        }

        public void DrawALine(Line line)
        {
            LinesDrawn.Add(line);            
        }

        public bool IsGameOver()
        {
            return (LinesDrawn.Count == TotalLines);
        }

        public bool IsSquareFormed(Line line)
        {
            if (line.IsHorizontal())
            {
                return true;
            }

            if (line.IsVertical())
            {
                return true;
            }

            return false;
        }

        public void UpdateScore()
        {
            CurrentPlayer.Score++;
        }
    }
}