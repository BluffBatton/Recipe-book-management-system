using Core.Models;
namespace Application.Abstractions
{
    public interface IBookService
    {
        public void CreateBook(Book book, int UserID);

        public IEnumerable<Book> ReadAllBooks();

        public Book GetBook(string title);

        public void UpdateBook(Book book, int UserID);

        public void DeleteBook(int BookID, int UserID);

        public IEnumerable<Book> GetRecipesForBook(Book book);

        public void AddRecipeToBook(Book book, int RecipeID);

        public void DeleteRecipeFromBook(Book book, int RecipeID);

        IEnumerable<Book> FilterBooks(Func<Book, bool> filter);
    }
}
