using System.Collections.Generic;
using DotsAndBoxesModels.Interfaces;

namespace DotsAndBoxesModels.Implementations
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int InvalidMoves { get;set; }

        public Player(string nameOfThePlayer)
        {            
            Name = nameOfThePlayer;
            Score = 0;
            InvalidMoves = 0;
        }

        public Line MakeAMove(IList<Line> linesOnTheBoard)
        {
            
        }

            
    }


}