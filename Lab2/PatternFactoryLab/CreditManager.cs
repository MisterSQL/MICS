namespace PatternFactoryLab
{
    // This class represents a Credit Manager, implementing the IBankManager interface.
    class CreditManager : IBankManager
    {
        // Implementation of the processClientRequest method specific to loan management.
        public void processСlientRequest()
        {
            // Output a message indicating that loan requests are being processed.
            Console.WriteLine("Processing loan requests");
        }
    }
}
