using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Demo.API.GraphQLErrorFilters
{
    public class DataNotFoundException : Exception
    {
        public long Id { get; internal set; }
    }
}
