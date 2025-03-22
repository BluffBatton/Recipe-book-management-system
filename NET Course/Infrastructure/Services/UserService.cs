using Application.Abstractions;
using Core.Models;
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
