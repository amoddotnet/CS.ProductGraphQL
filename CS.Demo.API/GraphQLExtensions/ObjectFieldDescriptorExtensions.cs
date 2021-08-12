using HotChocolate.Types;
using HotChocolate.Types.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CS.Demo.API.Extensions
{
    public static class ObjectFieldDescriptorExtensions
    {
        public static IObjectFieldDescriptor UseUpperCase(
            this IObjectFieldDescriptor descriptor)
        {
            return descriptor.Use(next => async context =>
            {
                await next(context);

                if (context.Result is string s)
                {
                    context.Result = s.ToUpperInvariant();
                }
            });
        }
        public static IObjectFieldDescriptor UseLowerCase(
            this IObjectFieldDescriptor descriptor)
        {
            return descriptor.Use(next => async context =>
            {
                await next(context);

                if (context.Result is string s)
                {
                    context.Result = s.ToLowerInvariant();
                }
            });
        }
        public static IObjectFieldDescriptor UseTitleCase(
            this IObjectFieldDescriptor descriptor)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return descriptor.Use(next => async context =>
            {
                await next(context);

                if (context.Result is string s)
                {
                    context.Result = textInfo.ToTitleCase(s);
                }
            });
        }

    }
}
