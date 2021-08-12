using CS.Demo.API.Types;
using HotChocolate;
using HotChocolate.AspNetCore.Subscriptions;
using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.API.Infrastructure
{
    public static class RegisterGraphqlServices
    {
        public static void AddGraphqlServices(this IServiceCollection services)
        {
            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddServices(sp)
                 .AddQueryType<DemoQueryType>()
                  .AddMutationType<DemoMutationType>()
               // .AddQueryType(d => d.Name("Query"))
               // .AddMutationType(d => d.Name("Mutation"))
               //.AddSubscriptionType(d => d.Name("Subscription"))
               //.AddType<UserQuery>()               

               // .AddAuthorizeDirectiveType()
               
               .Create(), new QueryExecutionOptions { ForceSerialExecution = true, IncludeExceptionDetails = true, TracingPreference = TracingPreference.Always })
               .AddCors(o => o.AddPolicy("MyPolicy", builder =>
               {
                   builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
               }));

            services.AddGraphQLSubscriptions();
        }
    }
}
