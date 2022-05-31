/*
summary: Creates the board to be displayed by the IO class
*/

using Chess.Player;

namespace Chess
{
    class Board
    {
        private Black _black = new Black();
        private White _white = new White();
        private string _board;
        private List<int[]> _whitePieces;
        private List<int[]> _blackPieces;
        public Board()
        {
            _board = CreateBoard();
        }
        
        /*
         summary: Creates a string that contains the board text
         return: (string board) returns the board text
         */
        private string CreateBoard()
        {
            AddBoard();
            AddBlackPieces();
            AddWhitePieces();
            return _board;
        }
        
        /*
         summary: Adds the image of the board to the _board
         34 chars in one line
         */
        private void AddBoard()
        {
            _board = ("   A   B   C   D   E   F   G   H  \n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "1|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "2|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "3|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "4|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "5|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "6|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "7|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n" +
                      "8|   |   |   |   |   |   |   |   |\n" +
                      " +---+---+---+---+---+---+---+---+\n");
        }
        
        /*
         summary: Adds the black chess pieces to the _board
         Row then Col
         */
        private void AddBlackPieces()
        {
            
        }
        
        /*
         summary: Adds the white chess pieces to the _board
         */
        private void AddWhitePieces()
        {
            
        }
        
        /*
         summary: Allows the attribute to be viewed
         return: (string) the value of _board
         */
        public string GetBoard()
        {
            return _board;
        }
        
    }
}