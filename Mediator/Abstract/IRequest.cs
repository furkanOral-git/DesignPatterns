using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Abstract
{
    public interface IRequest<TResponse> 
    {
        IRequestHandler<TResponse> GetHandler();
    }
}