using System;

namespace CS.Demo.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
    public class CreateBookInput
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
    }
    public class DeleteBookInput
    {
        public int Id { get; set; }
    }
}
