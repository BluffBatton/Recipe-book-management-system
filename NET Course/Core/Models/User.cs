namespace Core.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string? Name { get; set; }
        
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
