using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternMediator
{
    class Manager
    {
        // List to store different types of work brigades.
        private List<Brigade> Brigades = new List<Brigade>();

        // Queue to store tasks that need to be completed.
        private Queue<Task> TaskQueue = new Queue<Task>();

        // Method to add a brigade to the manager's list of available brigades.
        public void AddBrigade(Brigade brigade)
        {
            Brigades.Add(brigade);
        }

        // Method to add a task to the task queue and print a message.
        public void AddTask(Task task)
        {
            TaskQueue.Enqueue(task);
            Console.WriteLine($"Завдання {task.Name} додано в чергу.");
        }

        // Method to start the work process by assigning tasks to available brigades.
        public void StartWork()
        {
            while (TaskQueue.Count > 0)
            {
                Task currentTask = TaskQueue.Dequeue();
                Console.WriteLine($"Розпочато роботу над завданням: {currentTask.Name}");

                foreach (var brigade in Brigades)
                {
                    if (brigade.Specialization == currentTask.Specialization && brigade.CurrentTask == null)
                    {
                        brigade.TakeTask(currentTask);
                        brigade.CompleteTask();
                        break;
                    }
                }
            }
        }
    }
}
