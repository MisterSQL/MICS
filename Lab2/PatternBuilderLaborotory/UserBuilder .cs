namespace PatternBuilderLaborotory
{
    class UserBuilder : IBuilderRegistration
    {
        private User user = new User();
        // Method to set username
        public void SetFirstName(string firstName)
        {
            user.FirstName = firstName;
        }
        // Method to set the user's email
        public void SetEmail(string email)
        {
            user.Email = email;
        }
        // Method to set the user's password
        public void SetPassword(string password)
        {
            user.Password = password;
        }

 
        // Method to construct a user object with set parameters
        public User Build()
        {
            return user;
        }
    }
}
