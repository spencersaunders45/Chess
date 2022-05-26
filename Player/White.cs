//summary: Track all the white chess pieces

using Chess.Pieces;

namespace Chess.Player
{
    class White : Player
    {
        public White()
            // :
            // base(king, queen,rook1, rook2, bishop1, bishop2, knight1, knight2, pawn1, pawn2, pawn3, pawn4, pawn5, pawn6, pawn7, pawn8)
        {
            _king = new King(8,4);
            _queen = new Queen(8, 5);
            _bishop1 = new Bishop(8, 2);
            _bishop2 = new Bishop(8, 7);
            _rook1 = new Rook(8, 1);
            _rook2 = new Rook(8, 8);
            _knight1 = new Knight(8, 3);
            _knight2 = new Knight(8, 6);
            _pawn1 = new Pawn(7, 1);
            _pawn2 = new Pawn(7, 2);
            _pawn3 = new Pawn(7, 3);
            _pawn4 = new Pawn(7, 4);
            _pawn5 = new Pawn(7, 5);
            _pawn6 = new Pawn(7, 6);
            _pawn7 = new Pawn(7, 7);
            _pawn8 = new Pawn(7, 8);
        }
    }
}