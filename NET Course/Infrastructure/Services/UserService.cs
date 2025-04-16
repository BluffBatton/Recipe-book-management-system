using Application.Abstractions;
using Core.Models;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateUser(User user)
        {
            _userRepository.CreateUser(user);
        }

        public void DeleteUser(int UserID)
        {
            throw new NotImplementedException();
        }

        public User FindUserById(Func<int, User> id)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadUsers()
        {
            /*throw new NotImplementedException();*/
            return _userRepository.ReadUsers();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
