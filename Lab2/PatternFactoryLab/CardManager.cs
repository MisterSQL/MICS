 namespace PatternFactoryLab
{
    // This class represents a Card Manager, implementing the IBankManager interface.
    class CardManager : IBankManager
    {
        // Implementation of the processClientRequest method specific to card management.
        public void processСlientRequest()
        {
            // Output a message indicating that card requests are being processed.
            Console.WriteLine("Processing card requests");
        }
    }
}
