using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS.Demo.API.Resolvers;
using CS.Demo.Entity;
using HotChocolate.Types;

namespace CS.Demo.API.Types
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor.Field(b => b.Id).Type<IdType>();
            descriptor.Field(b => b.Title).Type<StringType>();
            descriptor.Field(b => b.Price).Type<DecimalType>();
            descriptor.Field<AuthorResolver>(x => x.GetAuthorLoader(default, default, default, default))
                .Type<AuthorType>()
                .Name("author");

            descriptor.Field("totalBooksCount")
                .ResolveWith<BookResolvers>(x => x.GetTotalBooksLoader(default, default, default));
        }
    }
}
