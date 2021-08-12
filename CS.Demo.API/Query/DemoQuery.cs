using CS.Demo.Entity;
using CS.Demo.Services;
using HotChocolate;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyclus.Order.API.Query
{
    [EnableCors("MyPolicy")]
    public class DemoQuery
    {
        public IQueryable<Book> GetBooks([Service] IBookService bookService ) => bookService.GetBooks();
        public Task<Book> GetBookById([Service] IBookService bookService,int id) => bookService.GetBookById(id);       
        public IQueryable<Author> GetAuthors([Service] IAuthorService authorService) => authorService.GetAuthors();
        public Task<Author> GetAuthorById([Service] IAuthorService authorService,int id) => authorService.GetAuthorById(id);
    }
}
