using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zyklus.Shared;
using Zyklus.Shared.Common;
using Zyklus.Shared.Filter;
using Zyklus.Shared.Helper;
using Zyklus.Shared.Token;

namespace CS.Demo.API.Infrastructure
{
    public static class CyclusRegisterDependencies
    {
        public static void AddAppDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            CyclusServiceCollection.ServiceDependencyCollection(services);
        }
    }
}
