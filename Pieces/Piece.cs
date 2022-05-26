//Summary:

namespace Chess.Pieces
{
    class Piece
    {
        protected bool _knockedOut = false;
        protected int _row;
        protected int _col;

        public Piece(int row, int col)
        {
            _row = row;
            _col = col;
        }
    }
}