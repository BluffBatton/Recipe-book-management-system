using Core.Models;
using Application.Abstractions;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly static string filePath = "C:\\Users\\havch\\Desktop\\.NET-Course\\.NET-Course\\users.json";

        public List<User> ReadUsers()
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void CreateUser(User user)
        {
            var users = ReadUsers();
            users.Add(user);
            SaveUsers(users);
        }

        public void DeleteUser(int userID)
        {
            var users = ReadUsers();
            var userToDelete = users.FirstOrDefault(u => u.Id == userID);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
                SaveUsers(users);
            }
        }
    }
}
