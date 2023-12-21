using System;
using System.Collections.Generic;

namespace patternMemento
{
    class Game
    {
        private int[,] board;
        private int emptyX;
        private int emptyY;
        private Stack<GameState> history;
        private Stack<GameState> redoHistory;

        // Constructor to initialize the game board
        public Game()
        {
            board = new int[4, 4];
            InitializeBoard();
            history = new Stack<GameState>();
            redoHistory = new Stack<GameState>();
            SaveState();
        }

        // Initializes the game board and shuffles the tiles
        private void InitializeBoard()
        {
            int value = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = value++;
                }
            }
            ShuffleArray();
            emptyX = 3;
            emptyY = 3;
            board[emptyX, emptyY] = 0;
        }


        // Shuffles the tiles on the board
        private void ShuffleArray()
        {
            Random random = new Random();
            int totalElements = board.Length;
            for (int i = totalElements - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int row1 = i / board.GetLength(1);
                int col1 = i % board.GetLength(1);
                int row2 = j / board.GetLength(1);
                int col2 = j % board.GetLength(1);

                int temp = board[row1, col1];
                board[row1, col1] = board[row2, col2];
                board[row2, col2] = temp;
            }
        }

        // Prints the current state of the board
        public void PrintBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{board[i, j],-3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Checks if the game is over
        public bool IsGameOver()
        {
            int value = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] != value++ % 16)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Moves a tile on the board
        public void Move(int value)
        {
            int x = -1, y = -1;

            // Find the coordinates of the tile
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == value)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
                if (x != -1) break;
            }

            // Check if the move is valid
            if (Math.Abs(x - emptyX) + Math.Abs(y - emptyY) == 1)
            {
                // Swap the tile and the empty space
                board[emptyX, emptyY] = value;
                board[x, y] = 0;
                emptyX = x;
                emptyY = y;
                SaveState();
            }
            else
            {
                Console.WriteLine("Неправильний хід. Будь ласка, виберіть іншу фішку для переміщення.");
            }
        }

        // Saves the current state of the game
        private void SaveState()
        {
            history.Push(new GameState(board, emptyX, emptyY));
            redoHistory.Clear();
        }

        // Undoes the last move
        public void Undo()
        {
            if (history.Count > 1)
            {
                redoHistory.Push(history.Pop());
                RestoreState();
            }
            else
            {
                Console.WriteLine("Неможливо відмінити більше.");
            }
        }

        // Redoes the last undone move
        public void Redo()
        {
            if (redoHistory.Count > 0)
            {
                history.Push(redoHistory.Pop());
                RestoreState();
            }
            else
            {
                Console.WriteLine("Неможливо повторити більше.");
            }
        }

        // Restores the game state to the previous state
        private void RestoreState()
        {
            GameState state = history.Peek();
            board = (int[,])state.Board.Clone();
            emptyX = state.EmptyX;
            emptyY = state.EmptyY;
        }
    }
}
