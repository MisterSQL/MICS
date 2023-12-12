using PatternBuilderLaborotory;
using System.Net.NetworkInformation;

// Using the builder to register a user: 
IBuilderRegistration userBuilder = new UserBuilder();

Console.Write("Input first Name: ");
userBuilder.SetFirstName(Console.ReadLine());

Console.Write("Input email: ");
userBuilder.SetEmail(Console.ReadLine());

Console.Write("Input password: ");
userBuilder.SetPassword(Console.ReadLine());
 

User user = userBuilder.Build();

Console.WriteLine($"User {user.FirstName} registered!");
Console.ReadKey();