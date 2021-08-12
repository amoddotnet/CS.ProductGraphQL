using CS.Demo.Entity;
using CS.Demo.Services;
using HotChocolate;
using HotChocolate.Resolvers;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CS.Demo.API.Resolvers
{
    public class BookResolvers
    {
        public async Task<int> GetTotalBooksLoader(IResolverContext resolverContext, [Parent] Book book, [Service] IBookService bookService)
        {
            return await resolverContext.FetchOnceAsync("TotalBooksLoader", () => bookService.GetTotalBooks());
        }

    }
}
