namespace Core.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        private List<Book> books { get; set; } = new List<Book>();

        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }
        public void AddBook(Book Book)
        {
            books.Add(Book);
        }
        public void DeleteBook(Book Book)
        {
            books.Remove(Book);
        }
    }
}
