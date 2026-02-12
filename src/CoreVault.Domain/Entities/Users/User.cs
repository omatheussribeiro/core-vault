using CoreVault.Domain.Entities.Base;

namespace CoreVault.Domain.Entities.Users
{
    public class User : EntityBase
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;

        private User() { }

        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
