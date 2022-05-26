//Summary: Track all the white chess pieces

class White : Player
{
   public White()
      // :
      // base(king, queen,rook1, rook2, bishop1, bishop2, knight1, knight2, pawn1, pawn2, pawn3, pawn4, pawn5, pawn6, pawn7, pawn8)
   {
      _king = new King(8,4);
   }
}