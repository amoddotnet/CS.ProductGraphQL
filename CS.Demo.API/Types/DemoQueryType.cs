using CS.Demo.API.FilterTypes;
using CS.Demo.API.SortTypes;
using CS.Demo.Entity;
using Cyclus.Order.API.Query;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.API.Types
{
    public class DemoQueryType : ObjectType<DemoQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<DemoQuery> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field<DemoQuery>(x => x.GetBooks(default))
              .Type<ListType<NonNullType<BookType>>>()
              .UsePaging<BookType>()
            //  .UseFiltering<BookFilterType>()
             // .UseSorting<BookSortType>()
              .Description("Retrieve Book details. Having Filter,Sorting and Paging");

        }
    }
}
