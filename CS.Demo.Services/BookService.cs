using CS.Demo.DTO;
using CS.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.Services
{
    public class BookService : IBookService
    {
        private IList<Book> _books;

        public BookService()
        {
            _books = new List<Book>()
            {
                new Book() { Id = 1, Title = "First Book", Price = 10, AuthorId = 1},
                new Book() { Id = 2, Title = "Second Book", Price = 11, AuthorId = 2},
                new Book() { Id = 3, Title = "Third Book", Price = 12, AuthorId = 3},
                new Book() { Id = 4, Title = "Fourth Book", Price = 15, AuthorId = 1},               
            };

        }
        public IQueryable<Book> GetBooks()
        {
            return _books.AsQueryable();
        }
        public async Task<Book> GetBookById(int id)
        {
            return _books.Where(x => x.Id == id).AsQueryable().FirstOrDefault();
        }
        public async Task<int> GetTotalBooks()
        {
            return _books.Count();
        }
        public Book CreateBook(CreateBookInput inputBook)
        {
            var newBook = new Book()
            {
                Id = _books.Max(x => x.Id) + 1,
                Title = inputBook.Title,
                Price = inputBook.Price,
                AuthorId = inputBook.AuthorId,
            };

            _books.Add(newBook);

            return newBook;
        }

        public Book DeleteBook(DeleteBookInput inputBook)
        {
            var bookToDelete = _books.FirstOrDefault(b => b.Id == inputBook.Id);
            if (bookToDelete == null)
                throw new ArgumentException("Record not found");
            _books.Remove(bookToDelete);
            return bookToDelete;
        }
        public string DeleteBookById(int id)
        {
            var bookToDelete = _books.FirstOrDefault(b => b.Id == id);
            if (bookToDelete == null)
                throw new ArgumentException("Record not found");
            _books.Remove(bookToDelete);
            return "Record deleted successfully";
        }

    }
}
