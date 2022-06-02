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
         location = (_black.GetKing.GetRow() * 68) + (_black.GetKing.GetCol() * 4) + (_black.GetKing.GetRow() + (_black.GetKing.GetRow() - 1));
         tempBoard[location] = 'K';
         location = (_black.GetQueen.GetRow() * 68) + (_black.GetQueen.GetCol() * 4) + (_black.GetQueen.GetRow() + (_black.GetQueen.GetRow() - 1));
         tempBoard[location] = 'Q';
         location = (_black.GetRook1.GetRow() * 68) + (_black.GetRook1.GetCol() * 4) + (_black.GetRook1.GetRow() + (_black.GetRook1.GetRow() - 1));
         tempBoard[location] = 'R';
         location = (_black.GetRook2.GetRow() * 68) + (_black.GetRook2.GetCol() * 4) + (_black.GetRook2.GetRow() + (_black.GetRook2.GetRow() - 1));
         tempBoard[location] = 'R';
         location = (_black.GetBishop1.GetRow() * 68) + (_black.GetBishop1.GetCol() * 4) + (_black.GetBishop1.GetRow() + (_black.GetBishop1.GetRow() - 1));
         tempBoard[location] = 'B';
         location = (_black.GetBishop2.GetRow() * 68) + (_black.GetBishop2.GetCol() * 4) + (_black.GetBishop2.GetRow() + (_black.GetBishop2.GetRow() - 1));
         tempBoard[location] = 'B';
         location = (_black.GetKnight1.GetRow() * 68) + (_black.GetKnight1.GetCol() * 4) + (_black.GetKnight1.GetRow() + (_black.GetKnight1.GetRow() - 1));
         tempBoard[location] = 'N';
         location = (_black.GetKnight2.GetRow() * 68) + (_black.GetKnight2.GetCol() * 4) + (_black.GetKnight2.GetRow() + (_black.GetKnight2.GetRow() - 1));
         tempBoard[location] = 'N';
         location = (_black.GetPawn1.GetRow() * 68) + (_black.GetPawn1.GetCol() * 4) + (_black.GetPawn1.GetRow() + (_black.GetPawn1.GetRow() - 1));
         tempBoard[location] = 'P';
         location = (_black.GetPawn2.GetRow() * 68) + (_black.GetPawn2.GetCol() * 4) + (_black.GetPawn2.GetRow() + (_black.GetPawn2.GetRow() - 1));
         tempBoard[location] = 'P';
         location = (_black.GetPawn3.GetRow() * 68) + (_black.GetPawn3.GetCol() * 4) + (_black.GetPawn3.GetRow() + (_black.GetPawn3.GetRow() - 1));
         tempBoard[location] = 'P';
         location = (_black.GetPawn4.GetRow() * 68) + (_black.GetPawn4.GetCol() * 4) + (_black.GetPawn4.GetRow() + (_black.GetPawn4.GetRow() - 1));
         tempBoard[location] = 'P';
         location = (_black.GetPawn5.GetRow() * 68) + (_black.GetPawn5.GetCol() * 4) + (_black.GetPawn5.GetRow() + (_black.GetPawn5.GetRow() - 1));
         tempBoard[location] = 'P';
         location = (_black.GetPawn6.GetRow() * 68) + (_black.GetPawn6.GetCol() * 4) + (_black.GetPawn6.GetRow() + (_black.GetPawn6.GetRow() - 1));
         tempBoard[location] = 'P';
         location = (_black.GetPawn7.GetRow() * 68) + (_black.GetPawn7.GetCol() * 4) + (_black.GetPawn7.GetRow() + (_black.GetPawn7.GetRow() - 1));
         tempBoard[location] = 'P';
         location = (_black.GetPawn8.GetRow() * 68) + (_black.GetPawn8.GetCol() * 4) + (_black.GetPawn8.GetRow() + (_black.GetPawn8.GetRow() - 1));
         tempBoard[location] = 'P';
         string newBoard = new string(tempBoard);
         _board = newBoard;
      }
      
      /*
      summary: Adds the white chess pieces to the _board
      */
      private void AddWhitePieces()
      { 
         char[] tempBoard = _board.ToCharArray();
         int location;
         location = (_white.GetKing.GetRow() * 68) + (_white.GetKing.GetCol() * 4) + (_white.GetKing.GetRow() + (_white.GetKing.GetRow() - 1));
         tempBoard[location] = 'k';
         location = (_white.GetQueen.GetRow() * 68) + (_white.GetQueen.GetCol() * 4) + (_white.GetQueen.GetRow() + (_white.GetQueen.GetRow() - 1));
         tempBoard[location] = 'q';
         location = (_white.GetRook1.GetRow() * 68) + (_white.GetRook1.GetCol() * 4)  + (_white.GetRook1.GetRow() + (_white.GetRook1.GetRow() - 1));
         tempBoard[location] = 'r';
         location = (_white.GetRook2.GetRow() * 68) + (_white.GetRook2.GetCol() * 4) + (_white.GetRook2.GetRow() + (_white.GetRook2.GetRow() - 1));
         tempBoard[location] = 'r';
         location = (_white.GetBishop1.GetRow() * 68) + (_white.GetBishop1.GetCol() * 4) + (_white.GetBishop1.GetRow() + (_white.GetBishop1.GetRow() - 1));
         tempBoard[location] = 'b';
         location = (_white.GetBishop2.GetRow() * 68) + (_white.GetBishop2.GetCol() * 4) + (_white.GetBishop2.GetRow() + (_white.GetBishop2.GetRow() - 1));
         tempBoard[location] = 'b';
         location = (_white.GetKnight1.GetRow() * 68) + (_white.GetKnight1.GetCol() * 4) + (_white.GetKnight1.GetRow() + (_white.GetKnight1.GetRow() - 1));
         tempBoard[location] = 'n';
         location = (_white.GetKnight2.GetRow() * 68) + (_white.GetKnight2.GetCol() * 4) + (_white.GetKnight2.GetRow() + (_white.GetKnight2.GetRow() - 1));
         tempBoard[location] = 'n';
         location = (_white.GetPawn1.GetRow() * 68) + (_white.GetPawn1.GetCol() * 4) + (_white.GetPawn1.GetRow() + (_white.GetPawn1.GetRow() - 1));
         tempBoard[location] = 'p';
         location = (_white.GetPawn2.GetRow() * 68) + (_white.GetPawn2.GetCol() * 4) + (_white.GetPawn2.GetRow() + (_white.GetPawn2.GetRow() - 1));
         tempBoard[location] = 'p';
         location = (_white.GetPawn3.GetRow() * 68) + (_white.GetPawn3.GetCol() * 4) + (_white.GetPawn3.GetRow() + (_white.GetPawn3.GetRow() - 1));
         tempBoard[location] = 'p';
         location = (_white.GetPawn4.GetRow() * 68) + (_white.GetPawn4.GetCol() * 4) + (_white.GetPawn4.GetRow() + (_white.GetPawn4.GetRow() - 1));
         tempBoard[location] = 'p';
         location = (_white.GetPawn5.GetRow() * 68) + (_white.GetPawn5.GetCol() * 4) + (_white.GetPawn5.GetRow() + (_white.GetPawn5.GetRow() - 1));
         tempBoard[location] = 'p';
         location = (_white.GetPawn6.GetRow() * 68) + (_white.GetPawn6.GetCol() * 4) + (_white.GetPawn6.GetRow() + (_white.GetPawn6.GetRow() - 1));
         tempBoard[location] = 'p';
         location = (_white.GetPawn7.GetRow() * 68) + (_white.GetPawn7.GetCol() * 4) + (_white.GetPawn7.GetRow() + (_white.GetPawn7.GetRow() - 1));
         tempBoard[location] = 'p';
         location = (_white.GetPawn8.GetRow() * 68) + (_white.GetPawn8.GetCol() * 4) + (_white.GetPawn8.GetRow() + (_white.GetPawn8.GetRow() - 1));
         tempBoard[location] = 'p';
         string newBoard = new string(tempBoard);
         _board = newBoard;
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