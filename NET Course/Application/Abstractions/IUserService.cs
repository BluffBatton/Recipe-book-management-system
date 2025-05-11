using Core.Models;
namespace Application.Abstractions
{
    public interface IUserService
    {
        void CreateUser(User user);

        List<User> ReadUsers();

        void UpdateUser(User user);

        void DeleteUser(int UserID);

        User FindUserById(Func<int, User> id);
    }
}
