using CS.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CS.Demo.Services
{
    public class AuthorService : IAuthorService
    {
        private IList<Author> _authors;

        public AuthorService()
        {
            _authors = new List<Author>()
            {
                new Author() { Id = 1, Name = "Amod", Surname = "Kumar",GenderId=1},
                new Author() { Id = 2, Name = "Fathima", Surname = "Khatun",GenderId=2},
                new Author() { Id = 3, Name = "Babar", Surname = "Khan",GenderId=1}
            };
        }        
        public IQueryable<Author> GetAuthors()
        {
            return _authors.AsQueryable();
        }
        public async Task<Author> GetAuthorById(int id)
        {
            return  _authors.Where(x => x.Id == id).AsQueryable().FirstOrDefault();
        }
        public async Task<string> GetGenderName(int id)
        {
            string genderName = string.Empty;
            if (id == 1)
                genderName = "Male";
            else if (id == 2)
                genderName = "Female";
            else
                genderName = "Other";

            return genderName;
        }
    }
}
