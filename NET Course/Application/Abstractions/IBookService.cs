using Core.Models;
namespace Application.Abstractions
{
    public interface IBookService
    {
        Task CreateBook(Book book, int UserID);

        Task<IEnumerable<Book>> ReadAllBooks();

        Task<Book> GetBook(string title);

        Task UpdateBook(Book book, int UserID);

        Task DeleteBook(int BookID, int UserID);

        Task<IEnumerable<Book>> GetRecipesForBook(Book book);

        Task AddRecipeToBook(Book book, int RecipeID);

        Task DeleteRecipeFromBook(Book book, int RecipeID);

        Task<IEnumerable<Book>> FilterBooks(Func<Book, bool> filter);
    }
}
