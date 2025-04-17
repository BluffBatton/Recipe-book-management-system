using Application.Abstractions;
using Core.Models;

namespace Infrastructure.Services
{
    public class BookService : IBookService
    {
        public async Task AddRecipeToBook(Book book, int RecipeID)
        {
            await Task.CompletedTask;
        }

        public async Task CreateBook(Book book, int UserID)
        {
            await Task.CompletedTask;
        }

        public async Task DeleteBook(int BookID, int UserID)
        {
            await Task.CompletedTask;
        }

        public async Task DeleteRecipeFromBook(Book book, int RecipeID)
        {
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Book>> FilterBooks(Func<Book, bool> filter)
        {
            return await Task.FromResult(new List<Book>());
        }

        public async Task<Book> GetBook(string title)
        {
            return await Task.FromResult(new Book());
        }

        public async Task<IEnumerable<Book>> GetRecipesForBook(Book book)
        {
            return await Task.FromResult(new List<Book>());
        }

        public async Task<IEnumerable<Book>> ReadAllBooks()
        {
            return await Task.FromResult(new List<Book>());
        }

        public async Task UpdateBook(Book book, int UserID)
        {
            await Task.CompletedTask;
        }
    }
}
