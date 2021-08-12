using CS.Demo.Entity;
using CS.Demo.Services;
using HotChocolate;
using HotChocolate.Resolvers;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CS.Demo.API.Resolvers
{
    public class AuthorResolver
    {
        public async Task<Author> GetAuthorLoader(IResolverContext resolverContext, [Parent] Book book, [Service] IAuthorService authorService , CancellationToken cancellationToken)
        => await resolverContext.CacheDataLoader<int, Author>("AuthorLoader", key => authorService.GetAuthorById(key)).LoadAsync(book.AuthorId, cancellationToken);

        public async Task<string> GetGenderLoader(IResolverContext resolverContext, [Parent] Author author , [Service] IAuthorService authorService, CancellationToken cancellationToken)
       => await resolverContext.CacheDataLoader<int, string>("GenderLoader", key => authorService.GetGenderName(key)).LoadAsync(author.GenderId, cancellationToken);
    }
}