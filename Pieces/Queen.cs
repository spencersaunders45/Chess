//summary:

namespace Chess.Pieces
{
    class Queen : Piece
    {
        public Queen(int row, int col) : base(row, col)
        {
            _row = row;
            _col = col;
        }
    }
}