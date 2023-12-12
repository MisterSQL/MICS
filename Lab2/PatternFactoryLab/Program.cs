using PatternFactoryLab;

Console.Write("Enter the type of question (cards, deposits, loans): ");
string request = Console.ReadLine();

// Create an instance of the BankManagerFactory.
BankManagerFactory managerFactory = new BankManagerFactory();
// Use the factory to create an IBankManager based on the user's input.
IBankManager manager = managerFactory.CreateManager(request);
// Call the processClientRequest method on the created manager.
manager.processСlientRequest();

Console.ReadKey();
