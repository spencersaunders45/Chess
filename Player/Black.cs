//summary: Track the all the black chess pieces

using Chess.Pieces;

namespace Chess.Player
{
    class Black : Player
    {
        public Black()
        {
            _king = new King(1,4);
            _queen = new Queen(1, 5);
            _bishop1 = new Bishop(1, 2);
            _bishop2 = new Bishop(1, 7);
            _rook1 = new Rook(1, 1);
            _rook2 = new Rook(1, 8);
            _knight1 = new Knight(1, 3);
            _knight2 = new Knight(1, 6);
            _pawn1 = new Pawn(2, 1);
            _pawn2 = new Pawn(2, 2);
            _pawn3 = new Pawn(2, 3);
            _pawn4 = new Pawn(2, 4);
            _pawn5 = new Pawn(2, 5);
            _pawn6 = new Pawn(2, 6);
            _pawn7 = new Pawn(2, 7);
            _pawn8 = new Pawn(2, 8);
        }
    }
}