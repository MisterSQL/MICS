namespace patternMemento
{
    class GameState
    {
        // Gets the current board configuration
        public int[,] Board { get; }

        // Gets the X-coordinate of the empty space
        public int EmptyX { get; }

        // Gets the Y-coordinate of the empty space
        public int EmptyY { get; }

        // Constructor to initialize the GameState with the given board and empty space coordinates
        public GameState(int[,] board, int emptyX, int emptyY)
        {
            // Clones the board to prevent external modifications affecting the GameState
            Board = (int[,])board.Clone();
            EmptyX = emptyX;
            EmptyY = emptyY;
        }
    }
}
