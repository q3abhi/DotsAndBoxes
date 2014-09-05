using System;
using System.Collections;
using System.Collections.Generic;
using DotsAndBoxesModels.Interfaces;

namespace DotsAndBoxesModels.Implementations
{
    public class TurnManager : ITurnManager
    {
        private static IList<IPlayer> _players;
        private static IPlayer _currentPlayer;
        public static readonly TurnManager TurnManagerInstance = new TurnManager();

        public TurnManager()
        {
            
        }

        public TurnManager(IList<IPlayer> players)
        {
            _players = players;
        }

        public IPlayer DecideFirstTurnPlayer()
        {
            var randomNumber = new Random();
            var randomPlayer = _players[randomNumber.Next(_players.Count)];
            _currentPlayer = randomPlayer;
            return _currentPlayer;
        }

        public IPlayer NextTurn()
        {
            return null;
        }
    }
}
