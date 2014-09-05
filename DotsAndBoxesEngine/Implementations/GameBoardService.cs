using System;
using System.Collections.Generic;
using DotsAndBoxesModels.Implementations;
using DotsAndBoxesModels.Interfaces;
using DotsAndBoxesServices.Interfaces;

namespace DotsAndBoxesServices.Implementations
{
    public class GameBoardService : IGameBoardService
    {
        public void StartAGame(int rows,int columns , String[] playerNames)
        {
            var startedAlready = IsGameStartedAlready();

            if (!startedAlready)
            {
                var players = InitialisePLayers(playerNames);
                var turnManager = new TurnManager(players);
                var firstPlayer = turnManager.DecideFirstTurnPlayer();
                var game = new GameBoard(rows, columns)
                {
                    Players = players,
                    CurrentPlayer = firstPlayer
                };

                PlayGame(game);
            }
            else
            {
                Console.WriteLine("Somebody else is playing the game. Kindly try after sometime");
            }
        }

        public void EndAGame()
        {
            // Destroy game object
            //Destroy Turn Manager Object

        }

        public IList<IPlayer> InitialisePLayers(String[] playerNames)
        {
            return null;

        }

        public bool IsGameStartedAlready()
        {
            // If there is already an instance , return true
            return false;
        }

        private void PlayGame(IGameBoard board)
        {
            while (!board.IsGameOver())
            {

                var lineToBeDrawn = board.CurrentPlayer.MakeAMove(board.LinesDrawn);
                var isLineValid = board.IsLineValid(lineToBeDrawn);
                if (!isLineValid)
                {
                    board.CurrentPlayer.InvalidMoves++;
                    break;
                }

                board.DrawALine(lineToBeDrawn);

                var isSquareFormed = board.IsSquareFormed(lineToBeDrawn);
                if (!isSquareFormed)
                {
                    
                }



            }
            EndAGame();
        }

/*        private Line AskPlayerToMakeAMove(IPlayer player,IList<Line> drawnLines )
        {
            var lineToBeDrawn = player.MakeAMove(drawnLines);
            return lineToBeDrawn;
        }*/
    }
}
