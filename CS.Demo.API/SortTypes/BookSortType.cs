using CS.Demo.Entity;
using HotChocolate.Types.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.API.SortTypes
{
    public class BookSortType : SortInputType<Book>
    {
        protected override void Configure(ISortInputTypeDescriptor<Book> descriptor)
        {
            base.Configure(descriptor);

            descriptor.BindFieldsExplicitly()                
                .Sortable(t => t.Title);

            descriptor.BindFieldsExplicitly()
               .Sortable(t => t.Price);

        }
    }
}
