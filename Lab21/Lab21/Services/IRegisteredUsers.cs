using System.Collections.Generic;
using Lab20.Models;

namespace Lab21.Services
{
    public interface IRegisteredUsers
    {
        List<Registration> Users { get; }

        List<Registration> Register(Registration registration);
    }
}