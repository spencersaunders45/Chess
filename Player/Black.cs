//Summary: Track the all the black chess pieces

class Black : Player
{
   public Black()
      // :
      // base(king, queen,rook1, rook2, bishop1, bishop2, knight1, knight2, pawn1, pawn2, pawn3, pawn4, pawn5, pawn6, pawn7, pawn8)
   {
      _king = new King(1, 4);
   }
}