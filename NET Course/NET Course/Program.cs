using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Application.Abstractions;

namespace NET_Course
{
    internal class Program
    {
        static void Main()
        {
            ServiceCollection services = new();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IUserService, UserService>();
            using ServiceProvider provider = services.BuildServiceProvider();

            var userManager = provider.GetService<IUserService>()!;
            //var user = new User() { Id = 6, Name = "Bobi" };
            //userManager.CreateUser(user);
            var list = userManager.ReadUsers();
            foreach(var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
