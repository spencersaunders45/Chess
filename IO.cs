//summary:

namespace Chess
{
    class IO
    {
        
        /*
        summary: Displays the board to the user
        param: (string board) the string that contains the board
        */
        public void DisplayBoard(string board)
        {
            Console.Write(board);
        }
        
        /*
        summary: Gets the location of the piece to be moved
        */
        public string SelectPiece()
        {
            bool isValid;
            do
            {
                
            } while (!isValid);
            string location = Console.ReadLine();
        }
        
    }
}