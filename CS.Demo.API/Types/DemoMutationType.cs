using CS.Demo.API.Mutation;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.API.Types
{    
    public class DemoMutationType : ObjectType<DemoMutation>
    {
        protected override void Configure(IObjectTypeDescriptor<DemoMutation> descriptor)
        {
            base.Configure(descriptor);

            //descriptor.Field(x => x.DeleteBookById(default, default))
            //    .Argument("bookDelete", x => x.DefaultValue(1));
                        
        }
    }
}
