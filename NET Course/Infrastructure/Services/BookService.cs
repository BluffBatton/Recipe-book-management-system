using Application.Abstractions;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class BookService : IBookService
    {
        public void CreateBook(Book book, User user)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Book> ReadAllBooks()
        {
            throw new NotImplementedException();
        }
        public Book GetBook(string title)
        {
            throw new NotImplementedException();
        }
        public void UpdateBook(Book book, User user)
        {
            throw new NotImplementedException();
        }
        public void DeleteBook(Book book, User user)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Book> GetRecipesForBook(Book book)
        {
            throw new NotImplementedException();
        }
        public void AddRecipeToBook(Book book, Recipe recipe)
        {
            throw new NotImplementedException();
        }
        public void DeleteRecipeFromBook(Book book, Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> FilterBooks(Func<Book, bool> filter)
        {
            throw new NotImplementedException();
        }
    }
}
