using CS.Demo.API.Resolvers;
using CS.Demo.Entity;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using System.Collections.Generic;
using System.Linq;

namespace CS.Demo.API.Types
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor.Field(a => a.Id).Type<IdType>();
            descriptor.Field(a => a.Name).Type<StringType>();
            descriptor.Field(a => a.Surname).Type<StringType>();
            descriptor.Field<AuthorResolver>(x => x.GetGenderLoader(default, default, default, default))             
              .Name("gender");
        }
    }
   
}