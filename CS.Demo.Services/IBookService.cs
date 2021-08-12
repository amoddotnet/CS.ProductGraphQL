using CS.Demo.DTO;
using CS.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Demo.Services
{
    public interface IBookService
    {
        IQueryable<Book> GetBooks();
        Task<Book> GetBookById(int id);
        Task<int> GetTotalBooks();
        Book CreateBook(CreateBookInput inputBook);
        Book DeleteBook(DeleteBookInput inputBook);
        string DeleteBookById(int id);
    }
}
