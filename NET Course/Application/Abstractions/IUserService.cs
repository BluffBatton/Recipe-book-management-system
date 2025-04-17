using Core.Models;
namespace Application.Abstractions
{
    public interface IUserService
    {
        Task CreateUser(string username, string password);

        Task<IEnumerable<User>> ReadUsers();

        Task UpdateUser(User user);

        Task DeleteUser(int UserID);

        Task<User> FindUserById(Func<int, User> id);
    }
}
