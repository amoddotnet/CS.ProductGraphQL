using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.API.GraphQLExtensions
{
    public static class SchemaBuilderTypeExtension
    {
        public static ISchemaBuilder AddTypes(this ISchemaBuilder builder)
        {
           // builder.AddType<PriceShemeType>();
           
            return builder;
        }
    }
}
