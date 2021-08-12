using CS.Demo.Entity;
using HotChocolate.Types.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CS.Demo.API.FilterTypes
{
    public class BookFilterType : FilterInputType<Book>
    {
        protected override void Configure(IFilterInputTypeDescriptor<Book> descriptor)
        {
            base.Configure(descriptor);

            descriptor.BindFieldsExplicitly()
                 .Filter(t => t.Title)
                 .BindFiltersExplicitly()
                 .AllowContains().And()
                 .AllowEquals().And()
                 .AllowStartsWith();

        }
    }
}
