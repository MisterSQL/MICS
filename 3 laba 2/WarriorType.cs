namespace Flyweight
{
    // WarriorType class represents the intrinsic state of a warrior, shared among multiple warrior instances.
    class WarriorType
    {
        // Properties representing the intrinsic state of a warrior.
        public string Name { get; }
        public string Sprite { get; }
        public string Army { get; }

        // Constructor initializes the intrinsic state of a warrior.
        public WarriorType(string name, string sprite, string army)
        {
            Name = name;
            Sprite = sprite;
            Army = army;
        }
    }
}