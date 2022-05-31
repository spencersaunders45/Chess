//summary:

namespace Chess
{
    class Director
    {
        private bool _gameOver;
        private Board _board = new Board();
        private IO _io = new IO();

        public Director()
        {
            _gameOver = false;
        }

        public void StartGame()
        {
            while(!_gameOver)
            {
                _io.DisplayBoard(_board.GetBoard());
                _gameOver = true;
            }
        }
    }
}