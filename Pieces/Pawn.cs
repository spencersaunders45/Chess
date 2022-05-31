//summary:

namespace Chess.Pieces
{
    class Pawn : Piece
    {
        public Pawn(int row, int col) : base(row, col)
        {
            Row = row;
            Col = col;
        }
    }
}