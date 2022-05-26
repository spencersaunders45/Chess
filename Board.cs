/*
summary: Creates the board to be displayed by the IO class
*/

using Chess.Player;

namespace Chess
{
    class Board
    {
        private Black _black = new Black();
        private White _white = new White();
        private string _board;
        public Board()
        {
            _board = CreateBoard();
        }
        
        /*
         summary:
         return:
         */
        private string CreateBoard()
        {
            
        }
        
    }
}