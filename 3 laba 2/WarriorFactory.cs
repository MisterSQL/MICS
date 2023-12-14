using System.Collections.Generic;

namespace Flyweight
{
    // WarriorFactory class is responsible for creating and managing warrior instances.
    class WarriorFactory
    {
        // Dictionary to store and retrieve shared instances of WarriorType based on their names.
        private readonly Dictionary<string, WarriorType> _warriorTypes = new Dictionary<string, WarriorType>();

        // GetWarrior method creates or retrieves a warrior based on the provided parameters.
        public Warrior GetWarrior(string name, int health, int x, int y, string sprite, string army)
        {
            // Check if the warrior type with the given name is already in the dictionary.
            if (!_warriorTypes.ContainsKey(name))
            {
                // If not, create a new WarriorType instance and add it to the dictionary.
                _warriorTypes[name] = new WarriorType(name, sprite, army);
            }

            // Return a new Warrior instance with the specified external state and the shared intrinsic state.
            return new Warrior(_warriorTypes[name], health, x, y);
        }
    }
}
