using CS.Demo.DTO;
using CS.Demo.Entity;
using CS.Demo.Services;
using HotChocolate;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.API.Mutation
{
    [EnableCors("MyPolicy")]
    public class DemoMutation
    {
        public Book CreateBook([Service] IBookService bookService, CreateBookInput inputBook) => bookService.CreateBook(inputBook);
        public Book DeleteBook([Service] IBookService bookService, DeleteBookInput inputBook) => bookService.DeleteBook(inputBook);
        public string DeleteBookById([Service] IBookService bookService, int id) => bookService.DeleteBookById(id);

    }
}
