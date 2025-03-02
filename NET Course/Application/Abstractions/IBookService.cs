using Core.Models;
namespace Application.Abstractions
{
    public interface IBookService
    {
        public void CreateBook(Book book, User user);
        public IEnumerable<Book> ReadAllBooks();
        public Book GetBook(string title);
        public void UpdateBook(Book book, User user);
        public void DeleteBook(Book book, User user);
        public IEnumerable<Book> GetRecipesForBook(Book book);
        public void AddRecipeToBook(Book book, Recipe recipe);
        public void DeleteRecipeFromBook(Book book, Recipe recipe);
    }
}
