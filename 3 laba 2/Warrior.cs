using System;

namespace Flyweight
{
    // Warrior class represents individual warriors with both intrinsic and extrinsic states.
    class Warrior
    {
        // Intrinsic state of the warrior, shared among multiple warrior instances.
        private readonly WarriorType _type;

        // Extrinsic state of the warrior.
        public int Health { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        // Constructor initializes the warrior with its intrinsic and extrinsic states.
        public Warrior(WarriorType type, int health, int x, int y)
        {
            _type = type;
            Health = health;
            X = x;
            Y = y;
        }

        // Display method prints information about the warrior's type, health, and position.
        public void Display()
        {
            Console.WriteLine($"Type: {_type.Name}, Sprite: {_type.Sprite}, Army: {_type.Army}");
            Console.WriteLine($"Health: {Health}, Position: ({X}, {Y})");
        }
    }
}
