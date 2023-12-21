using System;

namespace patternMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the sliding puzzle game
            Game game = new Game();

            // Continue the game until it is over or the user chooses to exit
            while (!game.IsGameOver())
            {
                Console.Clear();
                game.PrintBoard();

                Console.WriteLine("Оберiть номер фiшки для перемiщення (1-15), 'u' для вiдмiни ходу, 'r' для повторення ходу, 'q' для виходу:");
                string input = Console.ReadLine().ToLower();

                if (input == "q")
                {
                    break;
                }
                else if (input == "u")
                {
                    // Undo the last move if the user chooses to undo
                    game.Undo();
                }
                else if (input == "r")
                {
                    // Redo the last undone move if the user chooses to redo
                    game.Redo();
                }
                else
                {
                    if (int.TryParse(input, out int value) && value >= 1 && value <= 15)
                    {
                        game.Move(value);
                    }
                    else
                    {
                        Console.WriteLine("Неправильний ввід. Будь ласка, введіть номер фішки (1-15), 'u', 'r' або 'q'.");
                    }
                }
            }

            Console.WriteLine("Гра завершена!");
            Console.ReadLine();
        }
    }
}
