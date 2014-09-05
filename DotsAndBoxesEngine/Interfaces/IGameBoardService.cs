using System;

namespace DotsAndBoxesServices.Interfaces
{
    public interface IGameBoardService
    {
        void StartAGame(int rows, int columns, String[] players);
        void EndAGame();
    }
}
