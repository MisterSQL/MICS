 namespace PatternBuilderLaborotory
{
    interface IBuilderRegistration // Creating an interface for the builder
    {
        // Method to set name
        void SetFirstName(string firstName);

        // Method to set email
        void SetEmail(string email);
        // Method to set password

        // Method to construct a user object with set parameters
        void SetPassword(string password);
 
        User Build();
    }
}
