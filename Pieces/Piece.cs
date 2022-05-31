//Summary:

namespace Chess.Pieces
{
    class Piece
    {
        protected bool _knockedOut = false;
        protected int Row;
        protected int Col;

        public Piece(int row, int col)
        {
            Row = row;
            Col = col;
        }
        
        public int GetRow()
        {
            return Row;
        }

        public int GetCol()
        {
            return Col;
        }

        public bool GetKnockedOut()
        {
            return _knockedOut;
        }
    }
}