using Infrastructure.Services;

namespace NET_Course
{
    internal class Program
    {
        static async Task Main()
        {
            UserService userService = new UserService();

            await userService.CreateUser("Serega", "123456");
            await userService.DeleteUser(1);
        }
    }
}
