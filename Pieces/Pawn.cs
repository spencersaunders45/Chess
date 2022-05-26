//summary:

namespace Chess.Pieces
{
    class Pawn : Piece
    {
        public Pawn(int row, int col) : base(row, col)
        {
            _row = row;
            _col = col;
        }
    }
}