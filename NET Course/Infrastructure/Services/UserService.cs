using Application.Abstractions;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        public void CreateUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int UserID)
        {
            throw new NotImplementedException();
        }

        public User FindUserById(Func<int, User> id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ReadUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
