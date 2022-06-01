/*
summary: Creates the board to be displayed by the IO class
*/

using Chess.Player;
using Chess.Pieces;

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
         summary: Creates a string that contains the board text
         return: (string board) returns the board text
         */
        private string CreateBoard()
        {
            AddBoard();
            AddBlackPieces();
            AddWhitePieces();
            return _board;
        }
        
        /*
         summary: Adds the image of the board to the _board
         34 chars in one line
         */
        private void AddBoard()
        {
            _board = ("   A   B   C   D   E   F   G   H  \n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "1|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "2|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "3|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "4|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "5|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "6|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "7|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "8|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n");
        }
        
        /*
         summary: Adds the black chess pieces to the _board
         Row then Col
         */
        private void AddBlackPieces()
        {
            char[] tempBoard = _board.ToCharArray();
            int location;
            location = (_black.GetKing.GetRow() * 34) + (_black.GetKing.GetCol() * 4);
            tempBoard[location] = 'K';
            location = (_black.GetQueen.GetRow() * 34) + (_black.GetQueen.GetCol() * 4);
            tempBoard[location] = 'Q';
            location = (_black.GetRook1.GetRow() * 34) + (_black.GetRook1.GetCol() * 4);
            tempBoard[location] = 'R';
            location = (_black.GetRook2.GetRow() * 34) + (_black.GetRook2.GetCol() * 4);
            tempBoard[location] = 'R';
            location = (_black.GetBishop1.GetRow() * 34) + (_black.GetBishop1.GetCol() * 4);
            tempBoard[location] = 'B';
            location = (_black.GetBishop2.GetRow() * 34) + (_black.GetBishop2.GetCol() * 4);
            tempBoard[location] = 'B';
            location = (_black.GetKnight1.GetRow() * 34) + (_black.GetKnight1.GetCol() * 4);
            tempBoard[location] = 'N';
            location = (_black.GetKnight2.GetRow() * 34) + (_black.GetKnight2.GetCol() * 4);
            tempBoard[location] = 'N';
            location = (_black.GetPawn1.GetRow() * 34) + (_black.GetPawn1.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn2.GetRow() * 34) + (_black.GetPawn2.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn3.GetRow() * 34) + (_black.GetPawn3.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn4.GetRow() * 34) + (_black.GetPawn4.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn5.GetRow() * 34) + (_black.GetPawn5.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn6.GetRow() * 34) + (_black.GetPawn6.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn7.GetRow() * 34) + (_black.GetPawn7.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn8.GetRow() * 34) + (_black.GetPawn8.GetCol() * 4);
            tempBoard[location] = 'P';
            _board = tempBoard.ToString();
        }
        
        /*
         summary: Adds the white chess pieces to the _board
         */
        private void AddWhitePieces()
        {
            char[] tempBoard = _board.ToCharArray();
            int location;
            location = (_black.GetKing.GetRow() * 34) + (_black.GetKing.GetCol() * 4);
            tempBoard[location] = 'K';
            location = (_black.GetQueen.GetRow() * 34) + (_black.GetQueen.GetCol() * 4);
            tempBoard[location] = 'Q';
            location = (_black.GetRook1.GetRow() * 34) + (_black.GetRook1.GetCol() * 4);
            tempBoard[location] = 'R';
            location = (_black.GetRook2.GetRow() * 34) + (_black.GetRook2.GetCol() * 4);
            tempBoard[location] = 'R';
            location = (_black.GetBishop1.GetRow() * 34) + (_black.GetBishop1.GetCol() * 4);
            tempBoard[location] = 'B';
            location = (_black.GetBishop2.GetRow() * 34) + (_black.GetBishop2.GetCol() * 4);
            tempBoard[location] = 'B';
            location = (_black.GetKnight1.GetRow() * 34) + (_black.GetKnight1.GetCol() * 4);
            tempBoard[location] = 'N';
            location = (_black.GetKnight2.GetRow() * 34) + (_black.GetKnight2.GetCol() * 4);
            tempBoard[location] = 'N';
            location = (_black.GetPawn1.GetRow() * 34) + (_black.GetPawn1.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn2.GetRow() * 34) + (_black.GetPawn2.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn3.GetRow() * 34) + (_black.GetPawn3.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn4.GetRow() * 34) + (_black.GetPawn4.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn5.GetRow() * 34) + (_black.GetPawn5.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn6.GetRow() * 34) + (_black.GetPawn6.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn7.GetRow() * 34) + (_black.GetPawn7.GetCol() * 4);
            tempBoard[location] = 'P';
            location = (_black.GetPawn8.GetRow() * 34) + (_black.GetPawn8.GetCol() * 4);
            tempBoard[location] = 'P';
            _board = tempBoard.ToString();
        }
        
        /*
         summary: Allows the attribute to be viewed
         return: (string) the value of _board
         */
        public string GetBoard()
        {
            return _board;
        }

    }
}