using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    internal interface IUserService
    {
        void CreateUser(User user);
        User ReadUser(int UserID);
        IEnumerable<User> ReadUsers();
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
