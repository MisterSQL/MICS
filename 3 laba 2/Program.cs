using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the WarriorFactory, responsible for creating warriors.
            WarriorFactory warriorFactory = new WarriorFactory();

            // Prompt the user to input information about the warrior.

            Console.Write("Type warrior: ");
            string typeWarrior = Console.ReadLine();

            Console.Write("Sprite: ");
            string sprite = Console.ReadLine();

            Console.Write("Type army: ");
            string army = Console.ReadLine();

            Console.Write("Health: ");
            int health = int.Parse(Console.ReadLine());

            Console.Write("Possition x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Possition y: ");
            int y = int.Parse(Console.ReadLine());

            // Use the WarriorFactory to create a warrior based on user input.
            Warrior warrior1 = warriorFactory.GetWarrior(typeWarrior, health, x, y, sprite, army);

            // Display information about the created warrior.
            warrior1.Display();

            Console.ReadLine();
        }
    }
}
