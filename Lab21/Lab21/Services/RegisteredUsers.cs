using System.Collections.Generic;
using Lab20.Models;

namespace Lab21.Services
{
    public class RegisteredUsers : IRegisteredUsers
    {
        public RegisteredUsers()
        {
            Users = new List<Registration>();
        }

        public List<Registration> Users { get; }

        public List<Registration> Register(Registration registration)
        {
            Users.Add(registration);
            return Users;
        }
    }
}
