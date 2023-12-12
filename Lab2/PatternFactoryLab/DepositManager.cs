 namespace PatternFactoryLab
{
        // This class represents a Deposit Manager, implementing the IBankManager interface.
    class DepositManager : IBankManager
    {
        // Implementation of the processClientRequest method specific to deposit management.
        public void processСlientRequest()
        {
        //Output a message indicating that deposit requests are being processed.
          Console.WriteLine("Processing deposit requests");
        }
    }
}
