 namespace PatternFactoryLab
{
    class BankManagerFactory
    {
        // Creates a specific bank manager based on the given request type.
        // Parameters:
        //   - requestType: A string representing the type of bank manager to create.
        // Returns:
        //   An instance of the IBankManager interface corresponding to the specified request type.
        public IBankManager CreateManager(string requestType)
        {
            // Check if the request type is for card management.
            if (requestType == "cards")
            {
                // Return a new instance of CardManager.
                return new CardManager();
            }
            // Check if the request type is for deposit management.
            else if (requestType == "deposits")
            {
                // Return a new instance of DepositManager.
                return new DepositManager();
            }
            // Check if the request type is for loan management.
            else if (requestType == "loans")
            {
                // Return a new instance of CreditManager.
                return new CreditManager();
            }
            // If the request type is not recognized, throw an ArgumentException.
            else
            {
                throw new ArgumentException("Unknown question type");
            }
        }
    }
}
