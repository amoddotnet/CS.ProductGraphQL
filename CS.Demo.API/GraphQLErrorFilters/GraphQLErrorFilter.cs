using HotChocolate;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zyklus.Shared.Helper;

namespace CS.Demo.API.GraphQLErrorFilters
{
    public class GraphQLErrorFilter : IErrorFilter
    {
        private readonly ILogger<GraphQLErrorFilter> logger;

        public GraphQLErrorFilter(ILogger<GraphQLErrorFilter> logger)
        {
            this.logger = logger;

        }
        public IError OnError(IError error)
        {
            string errorMessage = null;

            if (error.Exception is DataNotFoundException ex)
                errorMessage = $"Data with id {ex.Id} not found";
            else if (error.Exception is CustomException cex)
                errorMessage = cex.Message;
            else if (error.Exception != null && error.Exception.InnerException == null)
                errorMessage = error.Exception.Message;
            else if (error.Exception != null)
                errorMessage = error.Exception.InnerException.Message;
            else
                errorMessage = error.Message;

            if (!string.IsNullOrEmpty(errorMessage))
                logger.LogError(error.Exception, $"{error.Path}: {errorMessage}");

            return error.WithMessage(errorMessage);
        }
    }
}
