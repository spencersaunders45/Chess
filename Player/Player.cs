//summary: Parent of the two players Black and White. Purpose of Player.cs is to simplify code for Black and White

using Chess.Pieces;

namespace Chess.Player
{
  class Player
  {
     protected King _king;
     protected Queen _queen;
     protected Rook _rook1, _rook2;
     protected Bishop _bishop1, _bishop2;
     protected Knight _knight1, _knight2;
     protected Pawn _pawn1, _pawn2, _pawn3, _pawn4, _pawn5, _pawn6, _pawn7, _pawn8;
  }
}