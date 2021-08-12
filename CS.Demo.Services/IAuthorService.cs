using CS.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Demo.Services
{
    public interface IAuthorService
    {
        IQueryable<Author> GetAuthors();
        Task<Author> GetAuthorById(int id);
        Task<string> GetGenderName(int id);
    }
}
