using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IRequestHandler<TResponse> 
    {
        TResponse Handle();
    }
}