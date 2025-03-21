using Application.Abstractions;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class BookService : IBookService
    {
        public void AddRecipeToBook(Book book, int RecipeID)
        {
            throw new NotImplementedException();
        }

        public void CreateBook(Book book, int UserID)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int BookID, int UserID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipeFromBook(Book book, int RecipeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> FilterBooks(Func<Book, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetRecipesForBook(Book book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> ReadAllBooks()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book, int UserID)
        {
            throw new NotImplementedException();
        }
    }
}
