using Infrastructure.Repositories;
using Core.Models;

namespace NET_Course
{
    internal class Program
    {
        static void Main()
        {
            var userRepository = new UserRepository();
            //List<User> newUsers = new List<User>
            //{
            //    new User { Id = 1, Name = "Sanek" },
            //    new User { Id = 2, Name = "Mykyta" },
            //    new User { Id = 3, Name = "Danylo" },
            //};

            //foreach (var user in newUsers)
            //{
            //    userRepository.CreateUser(user);
            //}
            //Console.WriteLine("User has been added");
            //var users = userRepository.ReadUsers();
            //Console.WriteLine("List of users:");
            //foreach (var user in users)
            //{
            //    Console.WriteLine($"{user.Id}: {user.Name}");
            //}
            /////
            userRepository.DeleteUser(1);
            Console.WriteLine("User has been deleted");
            var users = userRepository.ReadUsers();
            Console.WriteLine("List of users:");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id}: {user.Name}");
            }
        }
    }
}
