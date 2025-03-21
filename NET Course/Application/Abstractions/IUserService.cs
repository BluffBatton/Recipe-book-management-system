using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IUserService
    {
        void CreateUser(string username, string password);

        IEnumerable<User> ReadUsers();

        void UpdateUser(User user);

        void DeleteUser(int UserID);

        User FindUserById(Func<int, User> id);
    }
}
