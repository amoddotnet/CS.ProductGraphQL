using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Demo.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
   
}
