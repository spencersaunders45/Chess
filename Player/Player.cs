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

     public King GetKing => _king;

     public Queen GetQueen => _queen;

     public Rook GetRook1 => _rook1;

     public Rook GetRook2 => _rook2;

     public Bishop GetBishop1 => _bishop1;

     public Bishop GetBishop2 => _bishop2;

     public Knight GetKnight1 => _knight1;

     public Knight GetKnight2 => _knight2;

     public Pawn GetPawn1 => _pawn1;
     
     public Pawn GetPawn2 => _pawn2;
     
     public Pawn GetPawn3 => _pawn3;
     
     public Pawn GetPawn4 => _pawn4;
     
     public Pawn GetPawn5 => _pawn5;
     
     public Pawn GetPawn6 => _pawn6;
     
     public Pawn GetPawn7 => _pawn7;
     
     public Pawn GetPawn8 => _pawn8;
  }
}