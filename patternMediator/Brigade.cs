using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternMediator
{
    abstract class Brigade
    {
        // Private field to store the name of the brigade.
        private string Name;

        // Public property to store the specialization of the brigade.
        public string Specialization;

        // Public property to store the current task assigned to the brigade.
        public Task CurrentTask;

        // Constructor for the Brigade class, initializing it with a name, specialization, and setting the current task to null.
        public Brigade(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
            CurrentTask = null;
        }

        // Method to assign a task to the brigade and print a message.
        public void TakeTask(Task task)
        {
            Console.WriteLine($"{Name} отримує завдання: {task.Name}");
            CurrentTask = task;
        }

        // Method to complete the current task assigned to the brigade and print a message.
        public void CompleteTask()
        {
            Console.WriteLine($"{Name} завершує завдання: {CurrentTask.Name}");
            CurrentTask = null;
        }
    }
}
