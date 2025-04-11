using Core.Models;
using Application.DTO;
using Application.Mapping;
using AutoMapper;

namespace NET_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var user = new User()
            {
                Id = 1,
                Name = "James",
            };

            var mapper = AppMappingProfile.InitializeAutomapper();

            var userDTO1 = mapper.Map<UserDTO>(user);

            var empDTO2 = mapper.Map<User, UserDTO>(user);
            Console.WriteLine("Id: " + userDTO1.Id + ", Name: " + userDTO1.Name);
            Console.ReadLine();
        }
    }
}
