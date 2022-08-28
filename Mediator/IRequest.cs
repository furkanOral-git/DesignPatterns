using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IRequest<TResponse> 
    {
        IRequestHandler<TResponse> GetHandler();
    }
}