using Application.Abstractions;
using Core.Models;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        public async Task CreateUser(string username, string password)
        {
            Console.WriteLine($"Creating user with username: {username} and password: {password}");
            await Task.CompletedTask;
        }

        public async Task DeleteUser(int UserID)
        {
            Console.WriteLine($"Deleting user with ID: {UserID}");
            await Task.CompletedTask;
        }

        public async Task<User> FindUserById(Func<int, User> id)
        {
            return await Task.FromResult(new User());
        }

        public async Task<IEnumerable<User>> ReadUsers()
        {
            return await Task.FromResult(new List<User>());
        }

        public async Task UpdateUser(User user)
        {
            await Task.CompletedTask;
        }
    }
}
