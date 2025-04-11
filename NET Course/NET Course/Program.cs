using Infrastructure.Repositories;

namespace NET_Course
{
    internal class Program
    {
        static void Main()
        {
            //List<User> newUsers = new List<User>
            //{
            //    new User { Id = 1, Name = "Sanek" },
            //    new User { Id = 2, Name = "Mykyta" },
            //    new User { Id = 3, Name = "Danylo" },
            //};

            //foreach(var user in newUsers)
            //{
            //    UserRepository.CreateUser(user);
            //}
            //Console.WriteLine("User has been added");

            //var users = UserRepository.ReadUsers();
            //Console.WriteLine("List of users:");
            //foreach (var user in users)
            //{
            //    Console.WriteLine($"{user.Id}: {user.Name}");
            //}

            //UserRepository.DeleteUser(1);
            //Console.WriteLine("User has been deleted");

            var users = UserRepository.ReadUsers();
            Console.WriteLine("List of users:");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id}: {user.Name}");
            }
        }
    }
}
