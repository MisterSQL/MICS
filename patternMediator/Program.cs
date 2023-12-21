using System;

namespace patternMediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            // Create instances of different brigades.
            PlasteringBrigade plasteringBrigade1 = new PlasteringBrigade("Штукатурна бригада 1");
            PlasteringBrigade plasteringBrigade2 = new PlasteringBrigade("Штукатурна бригада 2");
            ElectricalBrigade electricalBrigade = new ElectricalBrigade("Електрична бригада");

            // Add brigades to the manager.
            manager.AddBrigade(plasteringBrigade1);
            manager.AddBrigade(plasteringBrigade2);
            manager.AddBrigade(electricalBrigade);

            // Create tasks.
            Task task1 = new Task { Name = "Штукатурка стiн", Specialization = "штукатурка" };
            Task task2 = new Task { Name = "Встановлення розеток", Specialization = "електрика" };

            // Add tasks to the manager
            manager.AddTask(task1);
            manager.AddTask(task2);

            // Start the work process.
            manager.StartWork();

            Console.ReadLine();
        }
    }
}
