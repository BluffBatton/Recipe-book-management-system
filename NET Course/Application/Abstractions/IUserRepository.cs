using Core.Models;

namespace Application.Abstractions
{
    public interface IUserRepository
    {
        List<User> ReadUsers();
        void SaveUsers(List<User> users);
        void CreateUser(User user);
        void DeleteUser(int userID);
    }
}
