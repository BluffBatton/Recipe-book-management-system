using Core.Models;
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
