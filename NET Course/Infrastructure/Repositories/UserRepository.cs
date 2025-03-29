using Core.Models;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public static class UserRepository
    {
        private readonly static string filePath = "C:\\Users\\havch\\Desktop\\.NET-Course\\.NET-Course\\users.json";

        public static List<User> ReadUsers()
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static void CreateUser(User user)
        {
            var users = ReadUsers();
            users.Add(user);
            SaveUsers(users);
        }

        public static void DeleteUser(int userID)
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
