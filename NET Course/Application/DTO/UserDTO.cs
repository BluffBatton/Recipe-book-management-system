using Core.Models;

namespace Application.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
